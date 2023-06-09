#include "Arduino.h"
#include "LoRa_E32.h"   //Lora Kütüphanesi
#include <SoftwareSerial.h> //Seri Haberleşme Kütüphanesi

// Donanımsal pin bağlantı tanımlama
SoftwareSerial mySerial(11, 5);
LoRa_E32 e32ttl(&mySerial);

float irtifa, ivme_x, ivme_y, ivme_z, gyro_x, gyro_y, gyro_z, sicaklik, aci;

//İletilecek yapının tekrarlı ilteceği değişken tanımlaması
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


void setup() {
  // put your setup code here, to run once:

  Serial.begin(115200);
  while (!Serial) {
    ;
  }
  delay(100);
  //Lora bağlantısını başlatma
  e32ttl.begin();

  Serial.println("start listening");
  Serial.println();
}

void loop() {
  // put your main code here, to run repeatedly:
 
 Serial.println("Veri bekleniyor...");
  //Alıcı Modda tanımlıyoruz.
   ResponseStructContainer rsc = e32ttl.receiveMessage(sizeof(Signal));
   struct Signal data = *(Signal*)rsc.data;

  Serial.println("Veri alındı...");

  Serial.println(F("Gelen mesaj: "));
  Serial.print(F("irtifa: "));
  Serial.print(*(float*)(data.irtifa));
  Serial.print("|");
  Serial.print(", ivme x: ");
  Serial.print(*(float*)(data.ivme_x));
  Serial.print("|");
  Serial.print(", ivme y: ");
  Serial.print(*(float*)(data.ivme_y));
  Serial.print("|");
  Serial.print(", ivme z: ");
  Serial.print(*(float*)(data.ivme_z));
  Serial.print("|");
  Serial.print(", gyro x: ");
  Serial.print(*(float*)(data.gyro_x));
  Serial.print("|");
  Serial.print(", gyro y : ");
  Serial.print(*(float*)(data.gyro_y));
  Serial.print("|");
  Serial.print(", gyro z : ");
  Serial.print(*(float*)(data.gyro_z));
  Serial.print("|");
  Serial.print(", sicaklik: ");
  Serial.print(*(float*)(data.sicaklik));
  Serial.print("|");
  Serial.print(", aci : ");
  Serial.println(*(float*)(data.aci));
//İlk işlemde kontrol mantığıyla geri kapatıp döngü bloğuna geçiş sağlanıyor.
  rsc.close();

//Döngüde UART seri haberleşmeden veri geliyorsa sürekli döngü içindeki kod bloğu çalışacaktır.
//Seri haberleşme olmama durumunda veri iletimi olmayacaktır.
  while (e32ttl.available() > 1) {
    Serial.println("Veri bekleniyor...");

    ResponseStructContainer rsc = e32ttl.receiveMessage(sizeof(Signal));
    struct Signal data = *(Signal*)rsc.data;

    Serial.print(*(float*)(data.irtifa));
    Serial.print("|");
    //Serial.print(", ivme x: ");
    Serial.print(*(float*)(data.ivme_x));
    Serial.print("|");
    //Serial.print(", ivme y: ");
    Serial.print(*(float*)(data.ivme_y));
    Serial.print("|");
    //Serial.print(", ivme z: ");
    Serial.print(*(float*)(data.ivme_z));
    Serial.print("|");
    //Serial.print(", gyro x: ");
    Serial.print(*(float*)(data.gyro_x));
    Serial.print("|");
    //Serial.print(", gyro y : ");
    Serial.print(*(float*)(data.gyro_y));
    Serial.print("|");
    //Serial.print(", gyro z : ");
    Serial.print(*(float*)(data.gyro_z));
    Serial.print("|");
    //Serial.print(", sicaklik: ");
    Serial.print(*(float*)(data.sicaklik));
    Serial.print("|");
    //Serial.print(", aci : ");
    Serial.println(*(float*)(data.aci));

    rsc.close();
  }
}
