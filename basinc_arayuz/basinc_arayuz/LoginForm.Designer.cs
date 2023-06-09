
namespace basinc_arayuz
{
    partial class LoginForm
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
            this.groupBoxLoginInformation = new System.Windows.Forms.GroupBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.groupBoxLoginInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLoginInformation
            // 
            this.groupBoxLoginInformation.Controls.Add(this.buttonLogin);
            this.groupBoxLoginInformation.Controls.Add(this.textBoxPassword);
            this.groupBoxLoginInformation.Controls.Add(this.textBoxUserName);
            this.groupBoxLoginInformation.Controls.Add(this.labelPassword);
            this.groupBoxLoginInformation.Controls.Add(this.labelUserName);
            this.groupBoxLoginInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupBoxLoginInformation.Location = new System.Drawing.Point(12, 12);
            this.groupBoxLoginInformation.Name = "groupBoxLoginInformation";
            this.groupBoxLoginInformation.Size = new System.Drawing.Size(352, 197);
            this.groupBoxLoginInformation.TabIndex = 0;
            this.groupBoxLoginInformation.TabStop = false;
            this.groupBoxLoginInformation.Text = "Giriş Bilgileri";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(157, 138);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(127, 35);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Giriş Yap";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(157, 92);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(127, 23);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyDown);
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(157, 50);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(127, 23);
            this.textBoxUserName.TabIndex = 2;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(38, 95);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(41, 17);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Şifre:";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(38, 50);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(88, 17);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "Kullanıcı Adı:";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 228);
            this.Controls.Add(this.groupBoxLoginInformation);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Girişi Formu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.groupBoxLoginInformation.ResumeLayout(false);
            this.groupBoxLoginInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLoginInformation;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button buttonLogin;
    }
}