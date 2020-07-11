using EnglishReminders.Entites;
using EnglishReminders.Managers;
using EnglishReminders.Providers;
using EnglishReminders.SeedDataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EnglishReminders
{
    public partial class LoginPage : Form
    {
       public  DatabaseContext context { get; set; }
        public LoginPage()
        {
            InitializeComponent();
            //Hazır verilerin veri tabanına yüklenmesi
            context = new DatabaseContext();
            SeedData.DataSeeding(context);
        }
        //Kayıt Ol sayfasından dönen verilerin alınması için oluşturulan propertyler
        public string uName { get; set; }
        public string Passw { get; set; }


        private void btnLogin_Click(object sender, EventArgs e)
        {

            //Kullanıcı Girişi
            string userName = txtUsername.Text;
            string password = txtPassword.Text;

            //Gelen verilenin boş olma kontrolü
            if (userName != "" && password != "")
            {
                UserManager um = new UserManager();

                //Başarılı Kullanıcı Girişi
                User user = um.UserLogin(txtUsername.Text, txtPassword.Text);
                if (user != null)
                {
                    App apForm = new App();
                    this.Hide();
                    apForm.Usr = user;
                    apForm.Show();
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş !");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre alanı boş bırakılamaz..");
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            //Background Image'leri local resource'dan ekleme
            pictureBox1.Image = Properties.Resources.LoginImage;
            this.BackgroundImage = Properties.Resources.gradient_blue_pink_abstract_art_wallpaper_preview;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogin.BackgroundImage = Properties.Resources.btnImage;
            btnLogin.BackgroundImageLayout = ImageLayout.Stretch;
            btnUserGuide.BackgroundImage = Properties.Resources.icons8_user_manual_96;
            btnUserGuide.BackgroundImageLayout = ImageLayout.Stretch;

            //Kullanıcı kayıt sayfasından gelen verileri yazdırma
            if (!string.IsNullOrEmpty(Passw) && !string.IsNullOrEmpty(uName))
            {
                txtPassword.Text = Passw;
                txtUsername.Text = uName;
            }
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            //Kayıt Ol sayfasına Yönlendirme
            RegisterPage rPage = new RegisterPage();
            this.Hide();
            rPage.Show();
        }

        private void btnUserGuide_Click(object sender, EventArgs e)
        {
            //Kullanım Kılavuzunun açılması
            var fileToOpen = Application.StartupPath.ToString() + "\\Kullanim_Kilavuzu.txt";
            var process = new Process();
            process.StartInfo = new ProcessStartInfo()
            {
                UseShellExecute = true,
                FileName = fileToOpen
            };
            process.Start();
            process.WaitForExit();
        }
    }
}
