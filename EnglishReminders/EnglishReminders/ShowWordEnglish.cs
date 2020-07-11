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
    public partial class ShowWordEnglish : Form
    {
        public ShowWordEnglish()
        {
            InitializeComponent();
        }
        WordManager wm = new WordManager();
        Words word;
        public User user { get; set; }
 
        private void ShowWordEnglish_Load(object sender, EventArgs e)
        {

            
            this.BackgroundImage = Properties.Resources.gradient_blue_pink_abstract_art_wallpaper_preview;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            btnOk.BackgroundImage = Properties.Resources.btnImage;
            btnOk.BackgroundImageLayout = ImageLayout.Stretch;
            word = wm.getRandomWord(user);
            if (word == null)
            {
                MessageBox.Show("Sorularımız Bu kadar :| Tekrar Denemek İçin Yeniden Giriş Yapıp Sıfırlayabiilirsiniz..");
                Application.Exit();
            }
            else
            {
               word.English= char.ToUpper(word.English[0]).ToString() + word.English.Substring(1);
                lblQuest.Text = word.English;
            }
     
        }



        private void button1_Click(object sender, EventArgs e)
        {
            ScoreManager sm = new ScoreManager();
            string answer = txtAnswer.Text;
            if (answer == "Exit Çıkış")
            {
                Application.Exit();
            }
            if (answer.ToLower() == word.Turkish.ToLower())
            {
                MessageBox.Show("DOĞRU :)", "Doğru Cevap", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                wm.changeAnsweredWord(word, user);
                sm.updateScore(user, true);
                this.Close();
            }
            else
            {
                MessageBox.Show("YANLIŞ :(" + " Doğru Cevap : " + word.Turkish, "Yanlış Cevap", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sm.updateScore(user, false);
                this.Close();
            }
        }
    }
}
