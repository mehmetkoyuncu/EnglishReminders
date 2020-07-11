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
    public partial class AddWord : Form
    {
        public AddWord()
        {
            InitializeComponent();
        }

        public User user { get; set; }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                //Başarılı ekleme işlemi
                if (!string.IsNullOrEmpty(txtEnglish.Text) && !string.IsNullOrEmpty(txtTurkish.Text))
                {
                    WordManager wm = new WordManager();
                    int result = wm.AddWord(txtTurkish.Text, txtEnglish.Text, user);
                    MessageBox.Show(result + " Kayıt Eklendi..");
                    txtEnglish.Text = "";
                    txtTurkish.Text = "";

            
                }
                else
                {
                    //Alanların boş olması kontrolü
                    MessageBox.Show("Gerekli Alanları Doldurunuz..");
                    return;
                }
            }
            catch (Exception)
            {
                //Beklenmeyen hatalar
                MessageBox.Show("Beklenmeyen bir hata oluştu. Lütfen Daha sonra tekrar deneyiniz..");
            }
        
        }

  
        private void AddWord_Load(object sender, EventArgs e)
        {
            //Gerekli tasarımsal işlemlerin yapılması
            this.BackgroundImage = Properties.Resources.gradient_blue_pink_abstract_art_wallpaper_preview;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            btnAddWord.BackgroundImage = Properties.Resources.btnImage;
            btnAddWord.BackgroundImageLayout = ImageLayout.Stretch;
            btnUndo.BackgroundImage = Properties.Resources.unnamed;
            btnUndo.BackgroundImageLayout = ImageLayout.Stretch;
        }

  

        private void btnUndo_Click(object sender, EventArgs e)
        {
            //Controller sayfasına geri dönme
            Controller controller = new Controller();
            controller.usr = this.user;
            this.Close();
            controller.Show(); 
        }
    }
}
