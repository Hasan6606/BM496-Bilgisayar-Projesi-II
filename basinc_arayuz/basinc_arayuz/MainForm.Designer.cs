
namespace basinc_arayuz
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.labelAltitude = new System.Windows.Forms.Label();
            this.GroupBoxAltitude = new System.Windows.Forms.GroupBox();
            this.textBoxAltitude = new System.Windows.Forms.TextBox();
            this.chartPressure = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelAccX = new System.Windows.Forms.Label();
            this.labelAccY = new System.Windows.Forms.Label();
            this.labelAccZ = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxIMU = new System.Windows.Forms.GroupBox();
            this.chartGyro = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartAcc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxGyroZ = new System.Windows.Forms.TextBox();
            this.textBoxGyroY = new System.Windows.Forms.TextBox();
            this.textBoxGyroX = new System.Windows.Forms.TextBox();
            this.textBoxAccZ = new System.Windows.Forms.TextBox();
            this.textBoxAccY = new System.Windows.Forms.TextBox();
            this.textBoxAccX = new System.Windows.Forms.TextBox();
            this.labelGyroZ = new System.Windows.Forms.Label();
            this.labelGyroY = new System.Windows.Forms.Label();
            this.labelGyroX = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonRoketiDondurme = new System.Windows.Forms.Button();
            this.groupBoxNumericData = new System.Windows.Forms.GroupBox();
            this.textBoxDurum = new System.Windows.Forms.TextBox();
            this.textBoxJiroskopZ = new System.Windows.Forms.TextBox();
            this.textBoxJiroskopY = new System.Windows.Forms.TextBox();
            this.textBoxJiroskopX = new System.Windows.Forms.TextBox();
            this.textBoxIvmeZ = new System.Windows.Forms.TextBox();
            this.textBoxIvmeY = new System.Windows.Forms.TextBox();
            this.textBoxIvmeX = new System.Windows.Forms.TextBox();
            this.textBoxAci = new System.Windows.Forms.TextBox();
            this.textBoxSicaklik = new System.Windows.Forms.TextBox();
            this.textBoxBoylam = new System.Windows.Forms.TextBox();
            this.textBoxEnlem = new System.Windows.Forms.TextBox();
            this.textBoxIrtifa = new System.Windows.Forms.TextBox();
            this.labelAci = new System.Windows.Forms.Label();
            this.labelSicaklik = new System.Windows.Forms.Label();
            this.labelDurum = new System.Windows.Forms.Label();
            this.labelJiroskopZ = new System.Windows.Forms.Label();
            this.labelJiroskopY = new System.Windows.Forms.Label();
            this.labelJiroskopX = new System.Windows.Forms.Label();
            this.labelIvmeZ = new System.Windows.Forms.Label();
            this.labelIvmeY = new System.Windows.Forms.Label();
            this.labelIvmeX = new System.Windows.Forms.Label();
            this.labelBoylam = new System.Windows.Forms.Label();
            this.labelEnlem = new System.Windows.Forms.Label();
            this.labelIrtifa = new System.Windows.Forms.Label();
            this.groupBoxRoketAci = new System.Windows.Forms.GroupBox();
            this.pictureBoxRoketAcisiDurumu = new System.Windows.Forms.PictureBox();
            this.groupBoxArduinoConnection = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelConnectionStatus = new System.Windows.Forms.Label();
            this.butonDurdur = new System.Windows.Forms.Button();
            this.labelPort = new System.Windows.Forms.Label();
            this.butonBaslat = new System.Windows.Forms.Button();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelVersionNumber = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelLatitude = new System.Windows.Forms.Label();
            this.labelLongitude = new System.Windows.Forms.Label();
            this.textBoxLatitude = new System.Windows.Forms.TextBox();
            this.textBoxLongitude = new System.Windows.Forms.TextBox();
            this.buttonShowLocation = new System.Windows.Forms.Button();
            this.GroupBoxAltitude.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPressure)).BeginInit();
            this.groupBoxIMU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGyro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAcc)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxNumericData.SuspendLayout();
            this.groupBoxRoketAci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoketAcisiDurumu)).BeginInit();
            this.groupBoxArduinoConnection.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM6";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // labelAltitude
            // 
            this.labelAltitude.AutoSize = true;
            this.labelAltitude.Location = new System.Drawing.Point(12, 29);
            this.labelAltitude.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAltitude.Name = "labelAltitude";
            this.labelAltitude.Size = new System.Drawing.Size(71, 17);
            this.labelAltitude.TabIndex = 0;
            this.labelAltitude.Text = "Yükseklik:";
            // 
            // GroupBoxAltitude
            // 
            this.GroupBoxAltitude.Controls.Add(this.textBoxAltitude);
            this.GroupBoxAltitude.Controls.Add(this.chartPressure);
            this.GroupBoxAltitude.Controls.Add(this.labelAltitude);
            this.GroupBoxAltitude.Location = new System.Drawing.Point(16, 19);
            this.GroupBoxAltitude.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBoxAltitude.Name = "GroupBoxAltitude";
            this.GroupBoxAltitude.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBoxAltitude.Size = new System.Drawing.Size(604, 768);
            this.GroupBoxAltitude.TabIndex = 4;
            this.GroupBoxAltitude.TabStop = false;
            this.GroupBoxAltitude.Text = "Yükseklik";
            // 
            // textBoxAltitude
            // 
            this.textBoxAltitude.Location = new System.Drawing.Point(87, 26);
            this.textBoxAltitude.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAltitude.Name = "textBoxAltitude";
            this.textBoxAltitude.Size = new System.Drawing.Size(76, 23);
            this.textBoxAltitude.TabIndex = 2;
            // 
            // chartPressure
            // 
            chartArea4.Name = "ChartArea1";
            this.chartPressure.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartPressure.Legends.Add(legend4);
            this.chartPressure.Location = new System.Drawing.Point(15, 65);
            this.chartPressure.Margin = new System.Windows.Forms.Padding(2);
            this.chartPressure.Name = "chartPressure";
            this.chartPressure.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series8.BorderWidth = 2;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Legend = "Legend1";
            series8.MarkerBorderWidth = 2;
            series8.Name = "Basınç";
            this.chartPressure.Series.Add(series8);
            this.chartPressure.Size = new System.Drawing.Size(570, 685);
            this.chartPressure.TabIndex = 1;
            this.chartPressure.Text = "pressure";
            // 
            // labelAccX
            // 
            this.labelAccX.AutoSize = true;
            this.labelAccX.Location = new System.Drawing.Point(20, 29);
            this.labelAccX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAccX.Name = "labelAccX";
            this.labelAccX.Size = new System.Drawing.Size(58, 17);
            this.labelAccX.TabIndex = 0;
            this.labelAccX.Text = "İvme X: ";
            // 
            // labelAccY
            // 
            this.labelAccY.AutoSize = true;
            this.labelAccY.Location = new System.Drawing.Point(20, 58);
            this.labelAccY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAccY.Name = "labelAccY";
            this.labelAccY.Size = new System.Drawing.Size(58, 17);
            this.labelAccY.TabIndex = 0;
            this.labelAccY.Text = "İvme Y: ";
            // 
            // labelAccZ
            // 
            this.labelAccZ.AutoSize = true;
            this.labelAccZ.Location = new System.Drawing.Point(20, 85);
            this.labelAccZ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAccZ.Name = "labelAccZ";
            this.labelAccZ.Size = new System.Drawing.Size(58, 17);
            this.labelAccZ.TabIndex = 0;
            this.labelAccZ.Text = "İvme Z: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 232);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 259);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 288);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 0;
            // 
            // groupBoxIMU
            // 
            this.groupBoxIMU.Controls.Add(this.chartGyro);
            this.groupBoxIMU.Controls.Add(this.chartAcc);
            this.groupBoxIMU.Controls.Add(this.labelAccX);
            this.groupBoxIMU.Controls.Add(this.textBoxGyroZ);
            this.groupBoxIMU.Controls.Add(this.textBoxGyroY);
            this.groupBoxIMU.Controls.Add(this.textBoxGyroX);
            this.groupBoxIMU.Controls.Add(this.textBoxAccZ);
            this.groupBoxIMU.Controls.Add(this.textBoxAccY);
            this.groupBoxIMU.Controls.Add(this.textBoxAccX);
            this.groupBoxIMU.Controls.Add(this.labelAccY);
            this.groupBoxIMU.Controls.Add(this.labelGyroZ);
            this.groupBoxIMU.Controls.Add(this.labelGyroY);
            this.groupBoxIMU.Controls.Add(this.labelGyroX);
            this.groupBoxIMU.Controls.Add(this.labelAccZ);
            this.groupBoxIMU.Location = new System.Drawing.Point(635, 19);
            this.groupBoxIMU.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxIMU.Name = "groupBoxIMU";
            this.groupBoxIMU.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxIMU.Size = new System.Drawing.Size(1140, 768);
            this.groupBoxIMU.TabIndex = 5;
            this.groupBoxIMU.TabStop = false;
            this.groupBoxIMU.Text = "IMU Verileri";
            // 
            // chartGyro
            // 
            chartArea5.Name = "ChartArea1";
            this.chartGyro.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartGyro.Legends.Add(legend5);
            this.chartGyro.Location = new System.Drawing.Point(571, 114);
            this.chartGyro.Margin = new System.Windows.Forms.Padding(2);
            this.chartGyro.Name = "chartGyro";
            series9.BorderWidth = 2;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Legend = "Legend1";
            series9.Name = "gyroX";
            series10.BorderWidth = 2;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Legend = "Legend1";
            series10.Name = "gyroY";
            series11.BorderWidth = 2;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series11.Legend = "Legend1";
            series11.Name = "gyroZ";
            this.chartGyro.Series.Add(series9);
            this.chartGyro.Series.Add(series10);
            this.chartGyro.Series.Add(series11);
            this.chartGyro.Size = new System.Drawing.Size(560, 636);
            this.chartGyro.TabIndex = 4;
            this.chartGyro.Text = "gyro";
            // 
            // chartAcc
            // 
            chartArea6.Name = "ChartArea1";
            this.chartAcc.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartAcc.Legends.Add(legend6);
            this.chartAcc.Location = new System.Drawing.Point(23, 114);
            this.chartAcc.Margin = new System.Windows.Forms.Padding(2);
            this.chartAcc.Name = "chartAcc";
            series12.BorderWidth = 2;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series12.Legend = "Legend1";
            series12.Name = "accX";
            series13.BorderWidth = 2;
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series13.Legend = "Legend1";
            series13.Name = "accY";
            series14.BorderWidth = 2;
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series14.Legend = "Legend1";
            series14.Name = "accZ";
            this.chartAcc.Series.Add(series12);
            this.chartAcc.Series.Add(series13);
            this.chartAcc.Series.Add(series14);
            this.chartAcc.Size = new System.Drawing.Size(560, 636);
            this.chartAcc.TabIndex = 3;
            this.chartAcc.Text = "acc";
            // 
            // textBoxGyroZ
            // 
            this.textBoxGyroZ.Location = new System.Drawing.Point(261, 82);
            this.textBoxGyroZ.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxGyroZ.Name = "textBoxGyroZ";
            this.textBoxGyroZ.Size = new System.Drawing.Size(76, 23);
            this.textBoxGyroZ.TabIndex = 2;
            // 
            // textBoxGyroY
            // 
            this.textBoxGyroY.Location = new System.Drawing.Point(261, 55);
            this.textBoxGyroY.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxGyroY.Name = "textBoxGyroY";
            this.textBoxGyroY.Size = new System.Drawing.Size(76, 23);
            this.textBoxGyroY.TabIndex = 2;
            // 
            // textBoxGyroX
            // 
            this.textBoxGyroX.Location = new System.Drawing.Point(261, 26);
            this.textBoxGyroX.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxGyroX.Name = "textBoxGyroX";
            this.textBoxGyroX.Size = new System.Drawing.Size(76, 23);
            this.textBoxGyroX.TabIndex = 2;
            // 
            // textBoxAccZ
            // 
            this.textBoxAccZ.Location = new System.Drawing.Point(86, 82);
            this.textBoxAccZ.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAccZ.Name = "textBoxAccZ";
            this.textBoxAccZ.Size = new System.Drawing.Size(76, 23);
            this.textBoxAccZ.TabIndex = 2;
            // 
            // textBoxAccY
            // 
            this.textBoxAccY.Location = new System.Drawing.Point(86, 55);
            this.textBoxAccY.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAccY.Name = "textBoxAccY";
            this.textBoxAccY.Size = new System.Drawing.Size(76, 23);
            this.textBoxAccY.TabIndex = 2;
            // 
            // textBoxAccX
            // 
            this.textBoxAccX.Location = new System.Drawing.Point(86, 26);
            this.textBoxAccX.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAccX.Name = "textBoxAccX";
            this.textBoxAccX.Size = new System.Drawing.Size(76, 23);
            this.textBoxAccX.TabIndex = 2;
            // 
            // labelGyroZ
            // 
            this.labelGyroZ.AutoSize = true;
            this.labelGyroZ.Location = new System.Drawing.Point(175, 81);
            this.labelGyroZ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGyroZ.Name = "labelGyroZ";
            this.labelGyroZ.Size = new System.Drawing.Size(82, 17);
            this.labelGyroZ.TabIndex = 0;
            this.labelGyroZ.Text = "Jiroskop Z: ";
            // 
            // labelGyroY
            // 
            this.labelGyroY.AutoSize = true;
            this.labelGyroY.Location = new System.Drawing.Point(175, 55);
            this.labelGyroY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGyroY.Name = "labelGyroY";
            this.labelGyroY.Size = new System.Drawing.Size(82, 17);
            this.labelGyroY.TabIndex = 0;
            this.labelGyroY.Text = "Jiroskop Y: ";
            // 
            // labelGyroX
            // 
            this.labelGyroX.AutoSize = true;
            this.labelGyroX.Location = new System.Drawing.Point(175, 29);
            this.labelGyroX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGyroX.Name = "labelGyroX";
            this.labelGyroX.Size = new System.Drawing.Size(82, 17);
            this.labelGyroX.TabIndex = 0;
            this.labelGyroX.Text = "Jiroskop X: ";
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tabControl1.Location = new System.Drawing.Point(6, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1802, 833);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonRoketiDondurme);
            this.tabPage1.Controls.Add(this.groupBoxNumericData);
            this.tabPage1.Controls.Add(this.groupBoxRoketAci);
            this.tabPage1.Controls.Add(this.groupBoxArduinoConnection);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1794, 803);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sayısal Veriler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonRoketiDondurme
            // 
            this.buttonRoketiDondurme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonRoketiDondurme.Location = new System.Drawing.Point(1185, 18);
            this.buttonRoketiDondurme.Name = "buttonRoketiDondurme";
            this.buttonRoketiDondurme.Size = new System.Drawing.Size(104, 45);
            this.buttonRoketiDondurme.TabIndex = 8;
            this.buttonRoketiDondurme.Text = "Roketi Döndür";
            this.buttonRoketiDondurme.UseVisualStyleBackColor = true;
            this.buttonRoketiDondurme.Visible = false;
            this.buttonRoketiDondurme.Click += new System.EventHandler(this.buttonRoketiDondurme_Click);
            // 
            // groupBoxNumericData
            // 
            this.groupBoxNumericData.Controls.Add(this.textBoxDurum);
            this.groupBoxNumericData.Controls.Add(this.textBoxJiroskopZ);
            this.groupBoxNumericData.Controls.Add(this.textBoxJiroskopY);
            this.groupBoxNumericData.Controls.Add(this.textBoxJiroskopX);
            this.groupBoxNumericData.Controls.Add(this.textBoxIvmeZ);
            this.groupBoxNumericData.Controls.Add(this.textBoxIvmeY);
            this.groupBoxNumericData.Controls.Add(this.textBoxIvmeX);
            this.groupBoxNumericData.Controls.Add(this.textBoxAci);
            this.groupBoxNumericData.Controls.Add(this.textBoxSicaklik);
            this.groupBoxNumericData.Controls.Add(this.textBoxBoylam);
            this.groupBoxNumericData.Controls.Add(this.textBoxEnlem);
            this.groupBoxNumericData.Controls.Add(this.textBoxIrtifa);
            this.groupBoxNumericData.Controls.Add(this.labelAci);
            this.groupBoxNumericData.Controls.Add(this.labelSicaklik);
            this.groupBoxNumericData.Controls.Add(this.labelDurum);
            this.groupBoxNumericData.Controls.Add(this.labelJiroskopZ);
            this.groupBoxNumericData.Controls.Add(this.labelJiroskopY);
            this.groupBoxNumericData.Controls.Add(this.labelJiroskopX);
            this.groupBoxNumericData.Controls.Add(this.labelIvmeZ);
            this.groupBoxNumericData.Controls.Add(this.labelIvmeY);
            this.groupBoxNumericData.Controls.Add(this.labelIvmeX);
            this.groupBoxNumericData.Controls.Add(this.labelBoylam);
            this.groupBoxNumericData.Controls.Add(this.labelEnlem);
            this.groupBoxNumericData.Controls.Add(this.labelIrtifa);
            this.groupBoxNumericData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupBoxNumericData.Location = new System.Drawing.Point(34, 222);
            this.groupBoxNumericData.Name = "groupBoxNumericData";
            this.groupBoxNumericData.Size = new System.Drawing.Size(563, 319);
            this.groupBoxNumericData.TabIndex = 6;
            this.groupBoxNumericData.TabStop = false;
            this.groupBoxNumericData.Text = "Veriler";
            // 
            // textBoxDurum
            // 
            this.textBoxDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBoxDurum.Location = new System.Drawing.Point(405, 269);
            this.textBoxDurum.Name = "textBoxDurum";
            this.textBoxDurum.Size = new System.Drawing.Size(132, 23);
            this.textBoxDurum.TabIndex = 29;
            // 
            // textBoxJiroskopZ
            // 
            this.textBoxJiroskopZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBoxJiroskopZ.Location = new System.Drawing.Point(405, 229);
            this.textBoxJiroskopZ.Name = "textBoxJiroskopZ";
            this.textBoxJiroskopZ.Size = new System.Drawing.Size(132, 23);
            this.textBoxJiroskopZ.TabIndex = 28;
            // 
            // textBoxJiroskopY
            // 
            this.textBoxJiroskopY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBoxJiroskopY.Location = new System.Drawing.Point(405, 189);
            this.textBoxJiroskopY.Name = "textBoxJiroskopY";
            this.textBoxJiroskopY.Size = new System.Drawing.Size(132, 23);
            this.textBoxJiroskopY.TabIndex = 27;
            // 
            // textBoxJiroskopX
            // 
            this.textBoxJiroskopX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBoxJiroskopX.Location = new System.Drawing.Point(405, 149);
            this.textBoxJiroskopX.Name = "textBoxJiroskopX";
            this.textBoxJiroskopX.Size = new System.Drawing.Size(132, 23);
            this.textBoxJiroskopX.TabIndex = 26;
            // 
            // textBoxIvmeZ
            // 
            this.textBoxIvmeZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBoxIvmeZ.Location = new System.Drawing.Point(405, 109);
            this.textBoxIvmeZ.Name = "textBoxIvmeZ";
            this.textBoxIvmeZ.Size = new System.Drawing.Size(132, 23);
            this.textBoxIvmeZ.TabIndex = 25;
            // 
            // textBoxIvmeY
            // 
            this.textBoxIvmeY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBoxIvmeY.Location = new System.Drawing.Point(405, 69);
            this.textBoxIvmeY.Name = "textBoxIvmeY";
            this.textBoxIvmeY.Size = new System.Drawing.Size(132, 23);
            this.textBoxIvmeY.TabIndex = 24;
            // 
            // textBoxIvmeX
            // 
            this.textBoxIvmeX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBoxIvmeX.Location = new System.Drawing.Point(405, 29);
            this.textBoxIvmeX.Name = "textBoxIvmeX";
            this.textBoxIvmeX.Size = new System.Drawing.Size(132, 23);
            this.textBoxIvmeX.TabIndex = 23;
            // 
            // textBoxAci
            // 
            this.textBoxAci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBoxAci.Location = new System.Drawing.Point(144, 189);
            this.textBoxAci.Name = "textBoxAci";
            this.textBoxAci.Size = new System.Drawing.Size(132, 23);
            this.textBoxAci.TabIndex = 22;
            // 
            // textBoxSicaklik
            // 
            this.textBoxSicaklik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBoxSicaklik.Location = new System.Drawing.Point(144, 149);
            this.textBoxSicaklik.Name = "textBoxSicaklik";
            this.textBoxSicaklik.Size = new System.Drawing.Size(132, 23);
            this.textBoxSicaklik.TabIndex = 21;
            // 
            // textBoxBoylam
            // 
            this.textBoxBoylam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBoxBoylam.Location = new System.Drawing.Point(144, 109);
            this.textBoxBoylam.Name = "textBoxBoylam";
            this.textBoxBoylam.Size = new System.Drawing.Size(132, 23);
            this.textBoxBoylam.TabIndex = 20;
            // 
            // textBoxEnlem
            // 
            this.textBoxEnlem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBoxEnlem.Location = new System.Drawing.Point(144, 69);
            this.textBoxEnlem.Name = "textBoxEnlem";
            this.textBoxEnlem.Size = new System.Drawing.Size(132, 23);
            this.textBoxEnlem.TabIndex = 19;
            // 
            // textBoxIrtifa
            // 
            this.textBoxIrtifa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBoxIrtifa.Location = new System.Drawing.Point(144, 29);
            this.textBoxIrtifa.Name = "textBoxIrtifa";
            this.textBoxIrtifa.Size = new System.Drawing.Size(132, 23);
            this.textBoxIrtifa.TabIndex = 17;
            // 
            // labelAci
            // 
            this.labelAci.AutoSize = true;
            this.labelAci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelAci.Location = new System.Drawing.Point(24, 192);
            this.labelAci.Name = "labelAci";
            this.labelAci.Size = new System.Drawing.Size(31, 17);
            this.labelAci.TabIndex = 16;
            this.labelAci.Text = "Açı:";
            // 
            // labelSicaklik
            // 
            this.labelSicaklik.AutoSize = true;
            this.labelSicaklik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelSicaklik.Location = new System.Drawing.Point(24, 152);
            this.labelSicaklik.Name = "labelSicaklik";
            this.labelSicaklik.Size = new System.Drawing.Size(59, 17);
            this.labelSicaklik.TabIndex = 15;
            this.labelSicaklik.Text = "Sıcaklık:";
            // 
            // labelDurum
            // 
            this.labelDurum.AutoSize = true;
            this.labelDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelDurum.Location = new System.Drawing.Point(307, 272);
            this.labelDurum.Name = "labelDurum";
            this.labelDurum.Size = new System.Drawing.Size(54, 17);
            this.labelDurum.TabIndex = 14;
            this.labelDurum.Text = "Durum:";
            // 
            // labelJiroskopZ
            // 
            this.labelJiroskopZ.AutoSize = true;
            this.labelJiroskopZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelJiroskopZ.Location = new System.Drawing.Point(307, 232);
            this.labelJiroskopZ.Name = "labelJiroskopZ";
            this.labelJiroskopZ.Size = new System.Drawing.Size(78, 17);
            this.labelJiroskopZ.TabIndex = 13;
            this.labelJiroskopZ.Text = "Jiroskop Z:";
            // 
            // labelJiroskopY
            // 
            this.labelJiroskopY.AutoSize = true;
            this.labelJiroskopY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelJiroskopY.Location = new System.Drawing.Point(307, 192);
            this.labelJiroskopY.Name = "labelJiroskopY";
            this.labelJiroskopY.Size = new System.Drawing.Size(78, 17);
            this.labelJiroskopY.TabIndex = 12;
            this.labelJiroskopY.Text = "Jiroskop Y:";
            // 
            // labelJiroskopX
            // 
            this.labelJiroskopX.AutoSize = true;
            this.labelJiroskopX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelJiroskopX.Location = new System.Drawing.Point(307, 152);
            this.labelJiroskopX.Name = "labelJiroskopX";
            this.labelJiroskopX.Size = new System.Drawing.Size(78, 17);
            this.labelJiroskopX.TabIndex = 11;
            this.labelJiroskopX.Text = "Jiroskop X:";
            // 
            // labelIvmeZ
            // 
            this.labelIvmeZ.AutoSize = true;
            this.labelIvmeZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelIvmeZ.Location = new System.Drawing.Point(307, 112);
            this.labelIvmeZ.Name = "labelIvmeZ";
            this.labelIvmeZ.Size = new System.Drawing.Size(54, 17);
            this.labelIvmeZ.TabIndex = 10;
            this.labelIvmeZ.Text = "İvme Z:";
            // 
            // labelIvmeY
            // 
            this.labelIvmeY.AutoSize = true;
            this.labelIvmeY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelIvmeY.Location = new System.Drawing.Point(307, 72);
            this.labelIvmeY.Name = "labelIvmeY";
            this.labelIvmeY.Size = new System.Drawing.Size(54, 17);
            this.labelIvmeY.TabIndex = 9;
            this.labelIvmeY.Text = "İvme Y:";
            // 
            // labelIvmeX
            // 
            this.labelIvmeX.AutoSize = true;
            this.labelIvmeX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelIvmeX.Location = new System.Drawing.Point(307, 32);
            this.labelIvmeX.Name = "labelIvmeX";
            this.labelIvmeX.Size = new System.Drawing.Size(54, 17);
            this.labelIvmeX.TabIndex = 8;
            this.labelIvmeX.Text = "İvme X:";
            // 
            // labelBoylam
            // 
            this.labelBoylam.AutoSize = true;
            this.labelBoylam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelBoylam.Location = new System.Drawing.Point(24, 112);
            this.labelBoylam.Name = "labelBoylam";
            this.labelBoylam.Size = new System.Drawing.Size(99, 17);
            this.labelBoylam.TabIndex = 7;
            this.labelBoylam.Text = "Roket Boylam:";
            // 
            // labelEnlem
            // 
            this.labelEnlem.AutoSize = true;
            this.labelEnlem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelEnlem.Location = new System.Drawing.Point(24, 72);
            this.labelEnlem.Name = "labelEnlem";
            this.labelEnlem.Size = new System.Drawing.Size(92, 17);
            this.labelEnlem.TabIndex = 6;
            this.labelEnlem.Text = "Roket Enlem:";
            // 
            // labelIrtifa
            // 
            this.labelIrtifa.AutoSize = true;
            this.labelIrtifa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelIrtifa.Location = new System.Drawing.Point(24, 32);
            this.labelIrtifa.Name = "labelIrtifa";
            this.labelIrtifa.Size = new System.Drawing.Size(39, 17);
            this.labelIrtifa.TabIndex = 4;
            this.labelIrtifa.Text = "İrtifa:";
            // 
            // groupBoxRoketAci
            // 
            this.groupBoxRoketAci.Controls.Add(this.pictureBoxRoketAcisiDurumu);
            this.groupBoxRoketAci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupBoxRoketAci.Location = new System.Drawing.Point(633, 18);
            this.groupBoxRoketAci.Name = "groupBoxRoketAci";
            this.groupBoxRoketAci.Size = new System.Drawing.Size(523, 523);
            this.groupBoxRoketAci.TabIndex = 7;
            this.groupBoxRoketAci.TabStop = false;
            this.groupBoxRoketAci.Text = "Roket Açısı Durumu Görseli";
            // 
            // pictureBoxRoketAcisiDurumu
            // 
            this.pictureBoxRoketAcisiDurumu.Location = new System.Drawing.Point(28, 29);
            this.pictureBoxRoketAcisiDurumu.Name = "pictureBoxRoketAcisiDurumu";
            this.pictureBoxRoketAcisiDurumu.Size = new System.Drawing.Size(464, 467);
            this.pictureBoxRoketAcisiDurumu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRoketAcisiDurumu.TabIndex = 0;
            this.pictureBoxRoketAcisiDurumu.TabStop = false;
            // 
            // groupBoxArduinoConnection
            // 
            this.groupBoxArduinoConnection.Controls.Add(this.label1);
            this.groupBoxArduinoConnection.Controls.Add(this.labelDateTime);
            this.groupBoxArduinoConnection.Controls.Add(this.label2);
            this.groupBoxArduinoConnection.Controls.Add(this.labelConnectionStatus);
            this.groupBoxArduinoConnection.Controls.Add(this.butonDurdur);
            this.groupBoxArduinoConnection.Controls.Add(this.labelPort);
            this.groupBoxArduinoConnection.Controls.Add(this.butonBaslat);
            this.groupBoxArduinoConnection.Controls.Add(this.comboBoxPort);
            this.groupBoxArduinoConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupBoxArduinoConnection.Location = new System.Drawing.Point(34, 18);
            this.groupBoxArduinoConnection.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxArduinoConnection.Name = "groupBoxArduinoConnection";
            this.groupBoxArduinoConnection.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxArduinoConnection.Size = new System.Drawing.Size(563, 173);
            this.groupBoxArduinoConnection.TabIndex = 3;
            this.groupBoxArduinoConnection.TabStop = false;
            this.groupBoxArduinoConnection.Text = "Arduino Bağlantısı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bağlantı Durumu:";
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(141, 131);
            this.labelDateTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(110, 17);
            this.labelDateTime.TabIndex = 5;
            this.labelDateTime.Text = "Tarih Ve Zaman";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tarih Ve Zaman:";
            // 
            // labelConnectionStatus
            // 
            this.labelConnectionStatus.AutoSize = true;
            this.labelConnectionStatus.Location = new System.Drawing.Point(141, 90);
            this.labelConnectionStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelConnectionStatus.Name = "labelConnectionStatus";
            this.labelConnectionStatus.Size = new System.Drawing.Size(113, 17);
            this.labelConnectionStatus.TabIndex = 3;
            this.labelConnectionStatus.Text = "Bağlantı Durumu";
            // 
            // butonDurdur
            // 
            this.butonDurdur.Location = new System.Drawing.Point(435, 21);
            this.butonDurdur.Margin = new System.Windows.Forms.Padding(2);
            this.butonDurdur.Name = "butonDurdur";
            this.butonDurdur.Size = new System.Drawing.Size(102, 45);
            this.butonDurdur.TabIndex = 2;
            this.butonDurdur.Text = "Durdur";
            this.butonDurdur.UseVisualStyleBackColor = true;
            this.butonDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.labelPort.Location = new System.Drawing.Point(20, 35);
            this.labelPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(77, 18);
            this.labelPort.TabIndex = 0;
            this.labelPort.Text = "SerialPort:";
            // 
            // butonBaslat
            // 
            this.butonBaslat.Location = new System.Drawing.Point(310, 21);
            this.butonBaslat.Margin = new System.Windows.Forms.Padding(2);
            this.butonBaslat.Name = "butonBaslat";
            this.butonBaslat.Size = new System.Drawing.Size(102, 45);
            this.butonBaslat.TabIndex = 2;
            this.butonBaslat.Text = "Başlat";
            this.butonBaslat.UseVisualStyleBackColor = true;
            this.butonBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(101, 32);
            this.comboBoxPort.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(188, 25);
            this.comboBoxPort.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBoxIMU);
            this.tabPage2.Controls.Add(this.GroupBoxAltitude);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1794, 803);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Veri Grafikleri";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.Controls.Add(this.buttonShowLocation);
            this.tabPage3.Controls.Add(this.textBoxLongitude);
            this.tabPage3.Controls.Add(this.textBoxLatitude);
            this.tabPage3.Controls.Add(this.labelLongitude);
            this.tabPage3.Controls.Add(this.labelLatitude);
            this.tabPage3.Controls.Add(this.webView21);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1794, 803);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Google Maps";
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(0, 74);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(1794, 729);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 1D;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1914, 116);
            this.panel1.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(174, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1508, 116);
            this.panel3.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1682, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(232, 116);
            this.panel4.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 116);
            this.panel2.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 961);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1914, 50);
            this.panel5.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Silver;
            this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(212, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1492, 50);
            this.panel7.TabIndex = 7;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Silver;
            this.panel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel8.BackgroundImage")));
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(1704, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(210, 50);
            this.panel8.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Controls.Add(this.labelVersionNumber);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(212, 50);
            this.panel6.TabIndex = 5;
            // 
            // labelVersionNumber
            // 
            this.labelVersionNumber.AutoSize = true;
            this.labelVersionNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelVersionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelVersionNumber.Location = new System.Drawing.Point(73, 24);
            this.labelVersionNumber.Name = "labelVersionNumber";
            this.labelVersionNumber.Size = new System.Drawing.Size(63, 17);
            this.labelVersionNumber.TabIndex = 18;
            this.labelVersionNumber.Text = "Versiyon";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Silver;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 116);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(50, 845);
            this.panel9.TabIndex = 9;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Silver;
            this.panel10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel10.BackgroundImage")));
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(1864, 116);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(50, 845);
            this.panel10.TabIndex = 10;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Silver;
            this.panel11.Controls.Add(this.tabControl1);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(50, 116);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1814, 845);
            this.panel11.TabIndex = 11;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // labelLatitude
            // 
            this.labelLatitude.AutoSize = true;
            this.labelLatitude.Location = new System.Drawing.Point(25, 30);
            this.labelLatitude.Name = "labelLatitude";
            this.labelLatitude.Size = new System.Drawing.Size(51, 17);
            this.labelLatitude.TabIndex = 1;
            this.labelLatitude.Text = "Enlem:";
            // 
            // labelLongitude
            // 
            this.labelLongitude.AutoSize = true;
            this.labelLongitude.Location = new System.Drawing.Point(305, 30);
            this.labelLongitude.Name = "labelLongitude";
            this.labelLongitude.Size = new System.Drawing.Size(58, 17);
            this.labelLongitude.TabIndex = 2;
            this.labelLongitude.Text = "Boylam:";
            // 
            // textBoxLatitude
            // 
            this.textBoxLatitude.Location = new System.Drawing.Point(82, 27);
            this.textBoxLatitude.Name = "textBoxLatitude";
            this.textBoxLatitude.Size = new System.Drawing.Size(192, 23);
            this.textBoxLatitude.TabIndex = 3;
            // 
            // textBoxLongitude
            // 
            this.textBoxLongitude.Location = new System.Drawing.Point(369, 27);
            this.textBoxLongitude.Name = "textBoxLongitude";
            this.textBoxLongitude.Size = new System.Drawing.Size(192, 23);
            this.textBoxLongitude.TabIndex = 4;
            // 
            // buttonShowLocation
            // 
            this.buttonShowLocation.Location = new System.Drawing.Point(602, 18);
            this.buttonShowLocation.Name = "buttonShowLocation";
            this.buttonShowLocation.Size = new System.Drawing.Size(122, 41);
            this.buttonShowLocation.TabIndex = 5;
            this.buttonShowLocation.Text = "Konumu Göster";
            this.buttonShowLocation.UseVisualStyleBackColor = true;
            this.buttonShowLocation.Click += new System.EventHandler(this.buttonShowLocation_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1914, 1011);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roket Uçuş Kontrol Yazılımı Yer İstaysonu Arayüzü";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBoxAltitude.ResumeLayout(false);
            this.GroupBoxAltitude.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPressure)).EndInit();
            this.groupBoxIMU.ResumeLayout(false);
            this.groupBoxIMU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGyro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAcc)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBoxNumericData.ResumeLayout(false);
            this.groupBoxNumericData.PerformLayout();
            this.groupBoxRoketAci.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoketAcisiDurumu)).EndInit();
            this.groupBoxArduinoConnection.ResumeLayout(false);
            this.groupBoxArduinoConnection.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label labelAltitude;
        private System.Windows.Forms.GroupBox GroupBoxAltitude;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPressure;
        private System.Windows.Forms.TextBox textBoxAltitude;
        private System.Windows.Forms.Label labelAccX;
        private System.Windows.Forms.Label labelAccY;
        private System.Windows.Forms.Label labelAccZ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBoxIMU;
        private System.Windows.Forms.TextBox textBoxGyroZ;
        private System.Windows.Forms.TextBox textBoxGyroY;
        private System.Windows.Forms.TextBox textBoxGyroX;
        private System.Windows.Forms.TextBox textBoxAccZ;
        private System.Windows.Forms.TextBox textBoxAccY;
        private System.Windows.Forms.TextBox textBoxAccX;
        private System.Windows.Forms.Label labelGyroZ;
        private System.Windows.Forms.Label labelGyroY;
        private System.Windows.Forms.Label labelGyroX;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAcc;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGyro;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.GroupBox groupBoxArduinoConnection;
        private System.Windows.Forms.Label labelConnectionStatus;
        private System.Windows.Forms.Button butonDurdur;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Button butonBaslat;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.GroupBox groupBoxNumericData;
        private System.Windows.Forms.Label labelIvmeZ;
        private System.Windows.Forms.Label labelIvmeY;
        private System.Windows.Forms.Label labelIvmeX;
        private System.Windows.Forms.Label labelBoylam;
        private System.Windows.Forms.Label labelEnlem;
        private System.Windows.Forms.Label labelIrtifa;
        private System.Windows.Forms.Label labelJiroskopZ;
        private System.Windows.Forms.Label labelJiroskopY;
        private System.Windows.Forms.Label labelJiroskopX;
        private System.Windows.Forms.Label labelAci;
        private System.Windows.Forms.Label labelSicaklik;
        private System.Windows.Forms.Label labelDurum;
        private System.Windows.Forms.TextBox textBoxAci;
        private System.Windows.Forms.TextBox textBoxSicaklik;
        private System.Windows.Forms.TextBox textBoxBoylam;
        private System.Windows.Forms.TextBox textBoxEnlem;
        private System.Windows.Forms.TextBox textBoxIrtifa;
        private System.Windows.Forms.TextBox textBoxDurum;
        private System.Windows.Forms.TextBox textBoxJiroskopZ;
        private System.Windows.Forms.TextBox textBoxJiroskopY;
        private System.Windows.Forms.TextBox textBoxJiroskopX;
        private System.Windows.Forms.TextBox textBoxIvmeZ;
        private System.Windows.Forms.TextBox textBoxIvmeY;
        private System.Windows.Forms.TextBox textBoxIvmeX;
        private System.Windows.Forms.GroupBox groupBoxRoketAci;
        private System.Windows.Forms.PictureBox pictureBoxRoketAcisiDurumu;
        private System.Windows.Forms.Button buttonRoketiDondurme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label labelVersionNumber;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.Label labelLongitude;
        private System.Windows.Forms.Label labelLatitude;
        private System.Windows.Forms.TextBox textBoxLongitude;
        private System.Windows.Forms.TextBox textBoxLatitude;
        private System.Windows.Forms.Button buttonShowLocation;
    }
}

