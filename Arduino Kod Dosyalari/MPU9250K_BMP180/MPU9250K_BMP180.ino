#include <Wire.h>
#include <MPU9250.h>             //Library Sensor Library.
#include <SFE_BMP180.h>          //Pressure Sensor Library.
#include <Kalman.h>              //İmported Kalman Filter Module.
#include <SimpleKalmanFilter.h>  ////İmported Kalman Filter Library.
#include <TinyGPSPlus.h>
#include "Arduino.h"
#include "LoRa_E32.h"

SimpleKalmanFilter pressureKalmanFilter(1, 1, 0.01);  //pressureKalmanFilter(firstValue,resultValue,constrantVariable)
MPU9250 IMU(Wire, 0X68);
SoftwareSerial mySerial(11, 5);  // Arduino RX <-- e32 TX, Arduino TX --> e32 RX
LoRa_E32 e32ttl(&mySerial, 3, 7, 6);


const int MPU9250_ADDRESS = 0x68;
const int ACCEL_XOUT_H = 0x3B;
const int GYRO_XOUT_H = 0x43;
const long SERIAL_REFRESH_TIME = 100;
long refresh_time;

Kalman kalmanX;
Kalman kalmanY;
Kalman kalmanZ;

SFE_BMP180 pressure;

float accX, accY, accZ;
float gyroX, gyroY, gyroZ;
float angleX, angleY, angleZ, gyroZangle, gyroXangle, gyroYangle;
float kalmanXangle, kalmanYangle, kalmanZangle;
float ax, ay, az, gx, gy, gz;

float baseline;  // baseline pressure
float irtifa, ivme_x, ivme_y,  ivme_z, gyro_x, gyro_y, gyro_z, sicaklik, aci;

struct Signal {

  byte irtifa[8];
  byte ivme_x[4];
  byte ivme_y[4];
  byte ivme_z[4];
  byte gyro_x[5];
  byte gyro_y[5];
  byte gyro_z[5];
  byte sicaklik[4];
  byte aci[5];

} veri;

double getPressure() {
  char status;
  double T, P;
  
  status = pressure.startTemperature();
  if (status != 0) {
    delay(status);
    status = pressure.getTemperature(T);
    if (status != 0) {
      status = pressure.startPressure(3);
      if (status != 0) {
        delay(status);
        status = pressure.getPressure(P, T);
        if (status != 0) {
          return (P);
        }
      }
    }
  }
}

// GPS Enlem ve Boylam Konum Tanımla
 void displayInfo() {
 

  Serial.print(F("Latitude: "));
  Serial.print(gps.location.lat(), 6);
  Serial.print(F(","));
  Serial.print(F("Longtitude: "));
  Serial.print(gps.location.lng(), 6);
  Serial.print(F(","));
  Serial.print(F("irtifa: "));
  Serial.println(gps.altitude.meters(), 6);

   *(float*)(konum.lat) = gps.location.lat();
  *(float*)(konum.lng) = gps.location.lng();
   *(float*)(konum.irtifa) = gps.altitude.meters();

  if (millis() > kanalbekleme_sure2 + kanalbekleme_bekleme2) {
     kanalbekleme_sure2 = millis();

    Serial.println("Send message to 00 01 23");
     ResponseStatus rs = e32ttl.sendFixedMessage(0, 1, 23, &veri, sizeof(Signal));
     Serial.print(rs.getResponseDescription());
   }

   else {
     //Serial.println(F("No gps data"));
   }
 }

void setup() {
  // put your setup code here, to run once:

  Serial.begin(115200);
  while (!Serial) {
    ;  // wait for serial port to connect. Needed for native USB
  }

  Serial1.begin(9600);
  e32ttl.begin();

  //Seri Haberleşme Protokol Metod Blokları  
  Wire.begin();
  IMU.begin();
  Wire.beginTransmission(MPU9250_ADDRESS);
  Wire.write(0x6B);
  Wire.write(0x00);
  Wire.endTransmission(true);
  IMU.calibrateAccel();
  IMU.setAccelRange(MPU9250::ACCEL_RANGE_2G);
  IMU.setGyroRange(MPU9250::GYRO_RANGE_250DPS);
  kalmanX.setAngle(0);
  kalmanY.setAngle(0);

//Basınç Kontrol Blok 
  if (!pressure.begin()) {
    Serial.println("BMP180 Pressure Sensor Error!");
    while (1)
      ;  // Pause forever.
  }
  baseline = getPressure();
}

void loop() {
// put your main code here, to run repeatedly:
// GPS Encode Seri Okumadaki Kod Blok
 while (Serial1.available() > 0) {
   kanalbekleme_sure = millis();
 if (gps.encode(Serial1.read()))
  displayInfo();
 }



 if (millis() > kanalbekleme_sure + kanalbekleme_bekleme) {
  while (true);
 }

//Ivme Sensör Ana Kod Blok
  Wire.read();
  IMU.readSensor();
  Wire.beginTransmission(MPU9250_ADDRESS);
  Wire.write(ACCEL_XOUT_H);
  Wire.endTransmission(false);
  Wire.requestFrom(MPU9250_ADDRESS, 6, true);
  accX = (Wire.read() << 8 | Wire.read());
  accY = (Wire.read() << 8 | Wire.read());
  accZ = (Wire.read() << 8 | Wire.read());

  Wire.beginTransmission(MPU9250_ADDRESS);
  Wire.write(GYRO_XOUT_H);
  Wire.endTransmission(false);
  Wire.requestFrom(MPU9250_ADDRESS, 6, true);
  gyroX = (Wire.read() << 8 | Wire.read());
  gyroY = (Wire.read() << 8 | Wire.read());
  gyroZ = (Wire.read() << 8 | Wire.read());

  ax = IMU.getAccelX_mss() / 9.8;
  ay = IMU.getAccelY_mss() / 9.8;
  az = IMU.getAccelZ_mss() / 9.8;
  gx = IMU.getGyroX_rads() * 57;
  gy = IMU.getGyroY_rads() * 57;
  gz = IMU.getGyroZ_rads() * 57;

//Kalman ile Açısal Hesaplama Kod Blok
  angleX = (atan2(accY, accZ) + M_PI) * RAD_TO_DEG;
  angleY = (atan2(accX, accZ) + M_PI) * RAD_TO_DEG;
  angleZ = (atan2(accX, accY) + M_PI) * RAD_TO_DEG;

  gyroXangle = gyroX / 131;
  gyroYangle = gyroY / 131;
  gyroZangle = gyroZ / 131;
  kalmanXangle = kalmanX.getAngle(angleX, gyroXangle, 0.5);
  kalmanYangle = kalmanY.getAngle(angleY, gyroYangle, 0.5);
  kalmanZangle = kalmanZ.getAngle(angleZ, gyroZangle, 0.5);


  if (kalmanXangle > 180) {
    kalmanXangle -= 360;
   }
   if (kalmanXangle < -180) {
     kalmanXangle += 360;
   }
   if (kalmanYangle > 180) {
    kalmanYangle -= 360;
   }
   if (kalmanYangle < -180) {
     kalmanYangle += 360;
   }

   //İvme Kalman Kod Bulma
  kalmanXangle = kalmanXangle - 90; 
  Serial.println("Angle X: " + String(kalmanXangle));
  Serial.print("Angle Y: " + String(kalmanYangle));
 Serial.println("Angle Z: " + String(kalmanZangle));

//Basınç Kalman Kod Blok
  float p = getPressure();
  float altitude = pressure.altitude(p, baseline);
  float estimated_altitude = pressureKalmanFilter.updateEstimate(altitude);
  //Serial.print(estimated_altitude,6);

    //Sıcaklık Kod Blok
   if (millis() > refresh_time) {
  Serial.print("Irtifa Verisi: ");
  Serial.print(altitude, 6);
  Serial.print("   ");
  Serial.print(" Basinc: ");
  Serial.print(baseline);
  Serial.print("   ");
  Serial.print("Temp: ");
  Serial.print(IMU.getTemperature_C(), 6);
  Serial.println(" C");
   refresh_time = millis() + SERIAL_REFRESH_TIME;
   }

   //Seri Ekrana Yazılan veriler ve value1 ile adlandırmayla başlıyan veriler RF Haberleşmedeki sıralı iletilen bitler.
  Serial.print(estimated_altitude);  //value0
  Serial.print("|");
  Serial.print(ax);  //value1
  Serial.print("|");
  Serial.print(ay);  //value2
  Serial.print("|");
  Serial.print(az);  //value3
  Serial.print("|");
  Serial.print(gx);  //value4
  Serial.print("|");
  Serial.print(gy);  //value5
  Serial.print("|");
  Serial.print(gz);  //value6
  Serial.print("|");
  Serial.print(IMU.getTemperature_C());  //value7
  Serial.print("|");
  Serial.println(String(kalmanXangle));  //value8
  Serial.print("|");


  *(float*)(veri.irtifa) = estimated_altitude;
  *(float*)(veri.ivme_x) = ax;
  *(float*)(veri.ivme_y) = ay;
  *(float*)(veri.ivme_z) = az;
  *(float*)(veri.gyro_x) = gx;
  *(float*)(veri.gyro_y) = gy;
  *(float*)(veri.gyro_z) = gz;
  *(float*)(veri.sicaklik) = IMU.getTemperature_C();
  *(float*)(veri.aci) = kalmanXangle;

    //Haberleşme Kod Blok
  ResponseStatus rs = e32ttl.sendFixedMessage(0, 1, 23, &veri, sizeof(Signal));

  if (millis() > kanalbekleme_sure2 + kanalbekleme_bekleme2) {
    kanalbekleme_sure2 = millis();

   Serial.println("Send message to 00 01 23");
   ResponseStatus rs = e32ttl.sendFixedMessage(0, 1, 23, &veri, sizeof(Signal));
  Serial.println(rs.getResponseDescription());
   }

  //IMU İLE AÇI HESABI
float output1;
 output1 = sqrt((IMU.getAccelY_mss() * IMU.getAccelY_mss()) + (IMU.getAccelZ_mss() * IMU.getAccelZ_mss()));
 output1 = atan(IMU.getAccelX_mss() / output1);
 output1 = (output1 * 180) / 3.142;
 output1 = 90 - output1;
  Serial.print("Aci: ");
  Serial.println(output1);
  delay(100);
}
