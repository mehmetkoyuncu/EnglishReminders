using EnglishReminders.Entites;
using EnglishReminders.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EnglishReminders
{
    public partial class RegisterPage : Form
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void RegisterPage_Load(object sender, EventArgs e)
        {
      

        }
        //Giriş sayfası için nesne oluşturulması
        LoginPage loginPAge = new LoginPage();


        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            UserManager um = new UserManager();

            //Texbox'ın boş olmasıı kontrolü
            if (txtUsername.Text == "" || txtAdSoyad.Text == "" || txtPassword.Text == "" || txtRepeatPassword.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz..");
            }
            else
            {
                //Şifre uyum kontrolü
                if (txtPassword.Text != txtRepeatPassword.Text)
                {
                    MessageBox.Show("'Şifre' ve 'Şifre Tekrar' Alanı Uyuşmuyor..");
                }
                else
                {
                   User usr = new User();
                   usr= um.UserRegister(txtUsername.Text);
                    
                    //Kullanıcı adı kontrolü, başarılı kayıt ve veriler ile birlikte giriş sayfasına dönüş
                    if (usr == null)
                    {
                        int result = um.AddUser(txtUsername.Text, txtPassword.Text, txtAdSoyad.Text);
                        MessageBox.Show(result + " Kayıt Başarıyla Gerçekleşti.");
                 
                        loginPAge.uName = txtUsername.Text;
                        loginPAge.Passw = txtPassword.Text;
                        loginPAge.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adı mevcut");
                    }
                  
                }
            }
        
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            //Sayfadan Çıkış
            this.Close();
            loginPAge.Show();

        }

        private void RegisterPage_Load_1(object sender, EventArgs e)
        {
            //Background-image Düzenleme
            this.BackgroundImage = Properties.Resources.gradient_blue_pink_abstract_art_wallpaper_preview;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegister.BackgroundImage = Properties.Resources.btnImage;
            btnRegister.BackgroundImageLayout = ImageLayout.Stretch;
            btnUndo.BackgroundImage = Properties.Resources.unnamed;
            btnUndo.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
