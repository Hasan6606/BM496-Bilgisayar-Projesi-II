using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Globalization;
using System.Security.Cryptography;

namespace basinc_arayuz
{
    public partial class MainForm : Form
    {
        private string data;
        private int chartXMin = 0;
        private int chartXMax = 20;
        private int pressureChartYMin = 0;
        private int pressureChartYMax = 50;
        private int accChartYMin = -10;
        private int accChartYMax = +10;
        private int gyroChartYMin = -100;
        private int gyroChartYMax = +100;

        private string _appPath = null;
        private string _roketPngPath = null;
        private Bitmap _roketImage = null;
        private double _angle = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string _appPath = System.IO.Directory.GetCurrentDirectory();
            string _roketPngPath = _appPath + "\\roket.png";
            _roketImage = new Bitmap(_roketPngPath);

            String[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comboBoxPort.Items.Add(port);
            }

            textBoxAltitude.ReadOnly = true;

            this.Invoke((MethodInvoker)delegate
            {
                labelConnectionStatus.Text = "Bağlantı Yok";
                labelConnectionStatus.ForeColor = Color.Red;
                pictureBoxRoketAcisiDurumu.Image = _roketImage;
                labelVersionNumber.Text = "V1.0";
            });

            timer2.Start();
            //showGoogleMaps("39.98345813971346", "32.87661518535403");
        }

        // Seriporttan fırlatılan veri eventlarını yakalar
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                data = serialPort1.ReadLine();
                if (data != null)
                {
                    this.Invoke(new EventHandler(displayData_event));
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        // Gelen veriyi split edilerek arayüzde uygun yerlerde gösterir, grafikleri gösterir, açı değerine göre arayüzdeki roketi döndürür
        private void displayData_event(object sender, EventArgs e)
        {
            try
            {
                string[] value = data.Split('|');

                if (value != null)
                {
                    float altitude = float.Parse(value[0], CultureInfo.InvariantCulture.NumberFormat);
                    if (altitude < 0)
                    {
                        altitude *= -1;
                    }

                    textBoxAltitude.Text = Convert.ToString(altitude);
                    textBoxAccX.Text = value[1];
                    textBoxAccY.Text = value[2];
                    textBoxAccZ.Text = value[3];
                    textBoxGyroX.Text = value[4];
                    textBoxGyroY.Text = value[5];
                    textBoxGyroZ.Text = value[6];

                    float accX = float.Parse(value[1], CultureInfo.InvariantCulture.NumberFormat);
                    float accY = float.Parse(value[2], CultureInfo.InvariantCulture.NumberFormat);
                    float accZ = float.Parse(value[3], CultureInfo.InvariantCulture.NumberFormat);
                    float gyroX = float.Parse(value[4], CultureInfo.InvariantCulture.NumberFormat);
                    float gyroY = float.Parse(value[5], CultureInfo.InvariantCulture.NumberFormat);
                    float gyroZ = float.Parse(value[6], CultureInfo.InvariantCulture.NumberFormat);

                    pressureChartYMin = Convert.ToInt32(altitude) - 50;
                    pressureChartYMax = Convert.ToInt32(altitude) + 50;
                    accChartYMin = Convert.ToInt32(accX) - 10;
                    accChartYMax = Convert.ToInt32(accX) + 10;

                    float maxGyroTemp = gyroX;
                    if (gyroX < 0)
                    {
                        maxGyroTemp = (-1) * gyroX;
                    }
                    else
                    {
                        maxGyroTemp = gyroX;
                    }

                    if (gyroY < 0)
                    {
                        if (maxGyroTemp < (-1) * gyroY)
                        {
                            maxGyroTemp = gyroY;
                        }
                    }
                    else
                    {
                        if (maxGyroTemp < gyroY)
                        {
                            maxGyroTemp = gyroY;
                        }
                    }
                    if (gyroZ < 0)
                    {
                        if (maxGyroTemp < (-1) * gyroZ)
                        {
                            maxGyroTemp = gyroZ;
                        }
                    }
                    else
                    {
                        if (maxGyroTemp < gyroZ)
                        {
                            maxGyroTemp = gyroZ;
                        }
                    }
                    gyroChartYMin = Convert.ToInt32(maxGyroTemp) - 100;
                    gyroChartYMax = Convert.ToInt32(maxGyroTemp) + 100;

                    this.chartPressure.Series[0].Points.AddXY((chartXMin + chartXMax) / 2, altitude);
                    this.chartAcc.Series[0].Points.AddXY((chartXMin + chartXMax) / 2, accX);
                    this.chartAcc.Series[1].Points.AddXY((chartXMin + chartXMax) / 2, accY);
                    this.chartAcc.Series[2].Points.AddXY((chartXMin + chartXMax) / 2, accZ);
                    this.chartGyro.Series[0].Points.AddXY((chartXMin + chartXMax) / 2, gyroX);
                    this.chartGyro.Series[1].Points.AddXY((chartXMin + chartXMax) / 2, gyroY);
                    this.chartGyro.Series[2].Points.AddXY((chartXMin + chartXMax) / 2, gyroZ);
                    chartXMin += 1;
                    chartXMax += 1;

                    textBoxIrtifa.Text = Convert.ToString(altitude);
                    textBoxIvmeX.Text = value[1];
                    textBoxIvmeY.Text = value[2];
                    textBoxIvmeZ.Text = value[3];
                    textBoxJiroskopX.Text = value[4];
                    textBoxJiroskopY.Text = value[5];
                    textBoxJiroskopZ.Text = value[6];
                    textBoxSicaklik.Text = value[7];
                    textBoxAci.Text = value[8];
                    _angle = float.Parse(value[8], CultureInfo.InvariantCulture.NumberFormat);
                    //textBoxEnlem.Text = value[9];
                    //textBoxBoylam.Text = value[10];
                    textBoxDurum.Text = "1";

                    this.Invoke((MethodInvoker)delegate
                    {
                        pictureBoxRoketAcisiDurumu.Image = RotateImage(_roketImage, (float)_angle);

                        // Yükseklik belirli değerin üstündeyken çizgi grafiğini kırmızı renk yapar
                        if (altitude > 50.0)
                        {
                            chartPressure.Series[0].Color = Color.Red;
                        }
                        else
                        {
                            chartPressure.Series[0].Color = Color.Blue;
                        }
                    });

                    // Verileri veritabanına yazar
                    var dc = new YerIstasyonuDataContext(Session.ConnectionString);
                    RocketData rocketData = new RocketData();
                    rocketData.Irtifa = value[0];
                    rocketData.IvmeX = value[1];
                    rocketData.IvmeY = value[2];
                    rocketData.IvmeZ = value[3];
                    rocketData.GyroX = value[4];
                    rocketData.GyroY = value[5];
                    rocketData.GyroZ = value[6];
                    rocketData.Sicaklik = value[7];
                    rocketData.Aci = value[8];
                    dc.RocketDatas.InsertOnSubmit(rocketData);
                    dc.SubmitChanges();
                }
                else
                {
                    labelConnectionStatus.Text = "Bağlantı Kopukluğu";
                    textBoxIrtifa.Text = null;
                    textBoxIvmeX.Text = null;
                    textBoxIvmeY.Text = null;
                    textBoxIvmeZ.Text = null;
                    textBoxJiroskopX.Text = null;
                    textBoxJiroskopY.Text = null;
                    textBoxJiroskopZ.Text = null;
                    textBoxSicaklik.Text = null;
                    textBoxAci.Text = null;
                    textBoxEnlem.Text = null;
                    textBoxBoylam.Text = null;
                    textBoxDurum.Text = "0";
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        // Seriport bağlantısını başlatır
        private void btnBaslat_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = "COM6";
                serialPort1.BaudRate = 115200;
                serialPort1.Open();
                butonBaslat.Enabled = false;
                butonDurdur.Enabled = true;
                labelConnectionStatus.Text = "Bağlantı Var";
                labelConnectionStatus.ForeColor = System.Drawing.Color.Green;
                timer1.Start();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        // Seriport bağlantısını durdurur
        private void btnDurdur_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                butonBaslat.Enabled = true;
                butonDurdur.Enabled = false;
                timer1.Stop();
                labelConnectionStatus.Text = "Bağlantı Durduruldu";
                labelConnectionStatus.ForeColor = Color.Red;
                textBoxIrtifa.Text = null;
                textBoxIvmeX.Text = null;
                textBoxIvmeY.Text = null;
                textBoxIvmeZ.Text = null;
                textBoxJiroskopX.Text = null;
                textBoxJiroskopY.Text = null;
                textBoxJiroskopZ.Text = null;
                textBoxSicaklik.Text = null;
                textBoxAci.Text = null;
                textBoxEnlem.Text = null;
                textBoxBoylam.Text = null;
                textBoxDurum.Text = null;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }

            this.Hide();
            LoginForm lg = new LoginForm();
            lg.Show();
        }

        // Sürekli gelen verileri timer ile belirli zaman aralıklarıyla verileri event olarak fırlatır
        private void timer1_Tick(object sender, EventArgs e)
        {
            chartPressure.ChartAreas[0].AxisY.Minimum = pressureChartYMin;
            chartPressure.ChartAreas[0].AxisY.Maximum = pressureChartYMax;
            chartPressure.ChartAreas[0].AxisY.Interval = 10;
            chartPressure.ChartAreas[0].AxisY.ScaleView.Zoom(pressureChartYMin, pressureChartYMax);
            chartPressure.ChartAreas[0].AxisX.Minimum = chartXMin;
            chartPressure.ChartAreas[0].AxisX.Maximum = chartXMax;
            chartPressure.ChartAreas[0].AxisX.ScaleView.Zoom(chartXMin, chartXMax);
            chartPressure.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = Color.Silver;
            chartPressure.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = Color.Silver;
            //pressureChart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            //pressureChart.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";

            chartAcc.ChartAreas[0].AxisY.Minimum = accChartYMin;
            chartAcc.ChartAreas[0].AxisY.Maximum = accChartYMax;
            chartAcc.ChartAreas[0].AxisY.Interval = 1;
            chartAcc.ChartAreas[0].AxisY.ScaleView.Zoom(accChartYMin, accChartYMax);
            chartAcc.ChartAreas[0].AxisX.Minimum = chartXMin;
            chartAcc.ChartAreas[0].AxisX.Maximum = chartXMax;
            chartAcc.ChartAreas[0].AxisX.ScaleView.Zoom(chartXMin, chartXMax);
            chartAcc.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = Color.Silver;
            chartAcc.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = Color.Silver;
            //accGyroChart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            //accGyroChart.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";

            chartGyro.ChartAreas[0].AxisY.Minimum = gyroChartYMin;
            chartGyro.ChartAreas[0].AxisY.Maximum = gyroChartYMax;
            chartGyro.ChartAreas[0].AxisY.Interval = 10;
            chartGyro.ChartAreas[0].AxisY.ScaleView.Zoom(gyroChartYMin, gyroChartYMax);
            chartGyro.ChartAreas[0].AxisX.Minimum = chartXMin;
            chartGyro.ChartAreas[0].AxisX.Maximum = chartXMax;
            chartGyro.ChartAreas[0].AxisX.ScaleView.Zoom(chartXMin, chartXMax);
            chartGyro.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = Color.Silver;
            chartGyro.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = Color.Silver;
            //accGyroChart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            //accGyroChart.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";

            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
        }

        // Roket resmini gelen açı değerine göre döndürür
        private static Bitmap RotateImage(Image roket, float angle)
        {
            Bitmap rotatedBmp = new Bitmap(roket.Width, roket.Height);

            if (roket != null)
            {

                rotatedBmp.SetResolution(roket.HorizontalResolution, roket.VerticalResolution);

                Graphics g = Graphics.FromImage(rotatedBmp);

                g.TranslateTransform(roket.Width / 2, roket.Height / 2);

                g.RotateTransform(angle);

                g.TranslateTransform(-roket.Width / 2, -roket.Height / 2);

                g.DrawImage(roket, new PointF(0, 0));
            }

            return rotatedBmp;
        }

        private void buttonRoketiDondurme_Click(object sender, EventArgs e)
        {
            _angle += 10;
            pictureBoxRoketAcisiDurumu.Image = RotateImage(_roketImage, (float)_angle);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            labelDateTime.Text = DateTime.Now.ToString();
        }

        // Google Earth için asenkron bir Web görünümü oluşur
        private async Task initizatedGPS()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }

        // Enlem ve boylam değerine göre URL değişerek Google Earth'de güncel konumu gösterir
        public async void showGoogleMaps(string lat, string lon)
        {
            try
            {
                await initizatedGPS();
                //StringBuilder str = new StringBuilder();
                //str.Append("https://www.google.com/maps/@");

                //if (lat != string.Empty)
                //{
                //    str.Append(lat + ",");
                //}
                //if (lon != string.Empty)
                //{
                //    str.Append(lon + ",17z" );
                //}
                //webView21.CoreWebView2.Navigate(str.ToString());
                
                string googleEarthUrl = "https://earth.google.com/web/@{0},{1},883.49219205a,192.12964372d,35y,0h,0t,0r";
                string currentLocationUrl = string.Format(googleEarthUrl, lat, lon);
                webView21.CoreWebView2.Navigate(currentLocationUrl);
            }
            catch (Exception ex)
            {

            }
        }

        private void buttonShowLocation_Click(object sender, EventArgs e)
        {
            showGoogleMaps(textBoxLatitude.Text, textBoxLongitude.Text);
        }
    }
}
