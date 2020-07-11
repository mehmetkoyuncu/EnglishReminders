using EnglishReminders.Entites;
using EnglishReminders.Entites.Common;
using EnglishReminders.Managers;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnglishReminders
{
    public partial class App : Form
    {
        public App()
        {

            InitializeComponent();
        }

        public User Usr { get; set; }

        public static int number { get; set; }

        private void App_Load(object sender, EventArgs e)
        {


            WordManager vm = new WordManager();
            number = vm.getAllWords(Usr).Count();

            CommonUser.Users = Usr;

            //Dil Seçimi
            cmbChooseLanguage.Items.Add("Türkçe Sor");
            cmbChooseLanguage.Items.Add("İngilizce Sor");
            cmbChooseLanguage.Items.Add("Rastgele Sor");

            //Gerekli işlemler yapılır.
            this.BackgroundImage = Properties.Resources.gradient_blue_pink_abstract_art_wallpaper_preview;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            btnBegin.BackgroundImage = Properties.Resources.btnImage;
            btnBegin.BackgroundImageLayout = ImageLayout.Stretch;
            btnUndo.BackgroundImage = Properties.Resources.unnamed;
            btnUndo.BackgroundImageLayout = ImageLayout.Stretch;
            pctStting.BackgroundImage = Properties.Resources.gnome_settings_default_applications;
            pctStting.BackgroundImageLayout = ImageLayout.Stretch;
            btnUserGuide.BackgroundImage = Properties.Resources.icons8_user_manual_96;
            btnUserGuide.BackgroundImageLayout = ImageLayout.Stretch;
            rbNow.Checked = true;

            //Combobox'daki itemlerden bir indexin seçilmesi
            cmbChooseLanguage.SelectedIndex = 2;

            //Kullanıcı isminin yazdırlması
            lblUser.Text = Usr.Name;

            //Score tablosundaki verilerin yazdırılması
            ScoreManager sm = new ScoreManager();
            Score score = sm.getScore(Usr);
            lblScore.Text = score.ScorePoint.ToString();
            lblCorrectCount.Text = score.CorrectCout.ToString();
            lblWrongCount.Text = score.WrongCount.ToString();



        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            try
            {

                //Combox'tan veri seçilmemesi halinde hata dönülmesi
                if (cmbChooseLanguage.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen dil seçimi yapınız..");
                    return;
                }



                //Zamanlayıcı ile tekrar süresini belirleme
                if (rbNow.Checked)
                    timer1.Interval = 20000;//900000;
                else if (rbHalf.Checked)
                    timer1.Interval = 1800000;
                else if (rb1.Checked)
                    timer1.Interval = 3600000;
                else if (rb2.Checked)
                    timer1.Interval = 7200000;
                else if (rb3.Checked)
                    timer1.Interval = 10800000;
                else if (rb6.Checked)
                    timer1.Interval = 21600000;
                else if (rb12.Checked)
                    timer1.Interval = 43200000;
                else if (rb24.Checked)
                    timer1.Interval = 86400000;
                else
                {
                    MessageBox.Show("Lütfen bir tekrar edilecek bir zaman dilimi seçiniz..");
                }
                StateApp sa = new StateApp();
                ScoreManager sm = new ScoreManager();
                Score score = new Score();
                timer1.Enabled = true;
                this.Hide();
                score = sm.getScore(this.Usr);
                sa.score = score;
                sa.user = Usr;
                sa.Show();
                //Zamanlayıcının çalıştırılması
             

            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu..");
                return;
            }

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            //Dil Seçimi-Türkçe
            if (cmbChooseLanguage.SelectedIndex == 0)
            {
                ShowWord word = new ShowWord();
                word.usr = Usr;
                word.ShowDialog();
            }
            //Dil Seçimi-İngilizce
            else if (cmbChooseLanguage.SelectedIndex == 1)
            {
                ShowWordEnglish wordDialog = new ShowWordEnglish();
                wordDialog.user = Usr;
                wordDialog.ShowDialog();
            }
            //Dil Seçimi-Rastgele
            else if (cmbChooseLanguage.SelectedIndex == 2)
            {
                Random r = new Random();
                int rand = r.Next(0, 10);
                if (rand % 2 == 0)
                {
                    ShowWord word = new ShowWord();
                    word.usr = Usr;
                    word.ShowDialog();
                }
                else
                {


                    ShowWordEnglish wordDialog = new ShowWordEnglish();
                    wordDialog.user = Usr;
                    wordDialog.ShowDialog();
                }
            }


        }
        private void pctStting_Click_1(object sender, EventArgs e)
        {
            //Ayarlar sayfasına yönlendirme
            Controller contForm = new Controller();
            contForm.usr = this.Usr;
            contForm.Show();
            this.Close();
        }

        private void App_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Bilgilerin sıfırlanması
            WordManager wm = new WordManager();
            wm.Reset(Usr);
            ScoreManager sm = new ScoreManager();
            Score score = sm.resetScore(Usr);
            this.lblCorrectCount.Text = score.CorrectCout.ToString();
            this.lblScore.Text = score.ScorePoint.ToString();
            this.lblWrongCount.Text = score.WrongCount.ToString();
            MessageBox.Show("Puan Bilgisi ve Diğer Bilgiler Sıfırlandı !");
        }

    


    

        private void btnUndo_Click(object sender, EventArgs e)
        {
            //Giriş Sayfasına Yönlendirme
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Close();
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
