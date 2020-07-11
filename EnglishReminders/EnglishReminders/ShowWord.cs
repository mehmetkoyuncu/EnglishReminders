using EnglishReminders.Entites;
using EnglishReminders.Entites.Common;
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
    public partial class ShowWord : Form
    {
        public ShowWord()
        {
            InitializeComponent();
        }
        WordManager wm = new WordManager();
        Words word;
        public User usr { get; set; }
        private void ShowWord_Load(object sender, EventArgs e)
        {

            this.usr = CommonUser.Users;
            this.BackgroundImage = Properties.Resources.gradient_blue_pink_abstract_art_wallpaper_preview;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            btnOk.BackgroundImage = Properties.Resources.btnImage;
            btnOk.BackgroundImageLayout = ImageLayout.Stretch;
            word = wm.getRandomWord(usr);
            if (word == null)
            {
                MessageBox.Show("Sorularımız Bu kadar :| Tekrar Denemek İçin Yeniden Giriş Yapıp Sıfırlayabiilirsiniz..");
                Application.Exit();
            }
            else
            {
                word.Turkish = char.ToUpper(word.Turkish[0]).ToString()+word.Turkish.Substring(1); 
                lblQuest.Text = word.Turkish;
            }
  
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ScoreManager sm = new ScoreManager();
            string answer = txtAnswer.Text;
            if (answer == "Exit Çıkış")
            {
                Application.Exit();
            }
            if (answer.ToLower() == word.English.ToLower())
            {
                MessageBox.Show("DOĞRU :)", "Doğru Cevap", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                wm.changeAnsweredWord(word, usr);
                sm.updateScore(usr, true);
                this.Close();
            }
            else
            {
                MessageBox.Show("YANLIŞ :(" + " Doğru Cevap : " + word.English, "Yanlış Cevap", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sm.updateScore(usr, false);
                this.Close();
            }

        }
    }
}
