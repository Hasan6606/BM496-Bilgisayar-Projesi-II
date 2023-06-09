using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basinc_arayuz
{
    public partial class LoginForm : Form
    {
        private bool isTrueUserName = false;
        private bool isTruePassword = false;

        public LoginForm()
        {
            InitializeComponent();
            textBoxPassword.UseSystemPasswordChar = true;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // Linq to SQL yardımıyla config dosyasından okunan veritabanı bilgileri göre veritabanı bağlantısını yapar
            var dc = new YerIstasyonuDataContext(Session.ConnectionString);
            var users = dc.Users.ToList();

            // Kulllanıcılar listesinde yer alan kişilerin login olmasını sağlar
            foreach (var item in users)
            {
                if (textBoxUserName.Text == item.UserName)
                {
                    isTrueUserName = true;

                    if (textBoxPassword.Text == item.Password)
                    {
                        isTruePassword = true;
                        MessageBox.Show("Başarıyla admin girişi yapılmıştır.", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        MainForm mf = new MainForm();
                        mf.ShowDialog();
                        break;
                    }
                }
            }

            if (isTrueUserName == false)
            {
                MessageBox.Show("Bu kullanıcı adında yetkili kişi bulunmamaktadır.", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (isTruePassword == false)
            {
                MessageBox.Show("Şifrenizi yanlış girdiniz.", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin_Click(this, new EventArgs());
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            textBoxUserName.Text = "admin";
            textBoxPassword.Text = "qwq1234.";
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
