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
    public partial class Controller : Form
    {
        public Controller()
        {
            InitializeComponent();
        }
        WordManager wm = new WordManager();

        public User usr { get; set; }
        private void Controller_Load(object sender, EventArgs e)
        {
            //Tüm Kelimeleri ListBox'a Aktarma
            List<Words> wordList = wm.getAllWords(usr);
            foreach (Words item in wordList)
            {
                lstWords.Items.Add(item);
                lstWords.Items.Add(item.English);
                lstWords.Items.Add("----------------------------------------");
            }

            //Gerekli işlemler yapılır.
            this.BackgroundImage = Properties.Resources.gradient_blue_pink_abstract_art_wallpaper_preview;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            lblSelected.Visible = false;
            lblId.Visible = false;
            lblEnglishMean.Visible = false;
            lblEnglishApperance.Visible = false;
            lblIDAppearance.Visible = false;
            lblSelectedAppearance.Visible = false;

        }


        private void btnAddWord_Click(object sender, EventArgs e)
        {
            //Kelime Ekleme
            AddWord aw = new AddWord();
            aw.user = this.usr;
            this.Hide();
            aw.ShowDialog();
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            //Uygulama Sayfasına Dönme
            App app = new App();
            app.Usr = this.usr;
            this.Dispose();
            this.Close();
            app.Show();

        }



        private void btnDeleteWord_Click(object sender, EventArgs e)
        {
           // Kelime Silme ve Hata Kontrolleri
            try
            {
                if (lstWords.SelectedItem != null)
                {
                    if (lstWords.SelectedItem.GetType() == typeof(Words))
                    {
                        Words selectedItem = lstWords.SelectedItem as Words;
                        WordManager wc = new WordManager();
                        int result = wc.DeleteWord(selectedItem.Id, usr);
                        lstWords.Items.Clear();
                        List<Words> wordList = wc.getAllWords(usr);
                        foreach (Words item in wordList)
                        {
                            lstWords.Items.Add(item);
                            lstWords.Items.Add(item.English);
                            lstWords.Items.Add("----------------------------------------");
                        }
                        MessageBox.Show(result + " Kayıt Silindi..");
                    }
                    else
                    {
                        MessageBox.Show("Silmek için Türkçe kelimeyi kullanınız.");
                    }

                }
                else
                {
                    MessageBox.Show("Lütfen bir kelime seçiniz..");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }







        private void lstWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Listbox'da seçilen Türkçe kelimeye göre kullanıcıya verilerin getirilmesi
            lblId.Visible = true;
            lblSelected.Visible = true;
            lblEnglishMean.Visible = true;
            lblEnglishApperance.Visible = true;
            lblIDAppearance.Visible = true;
            lblSelectedAppearance.Visible = true;

            if (lstWords.SelectedItem != null)
            {
                if (lstWords.SelectedItem.GetType() == typeof(Words))
                {
                    Words selectedWord = lstWords.SelectedItem as Words;
                    lblId.Text = selectedWord.Id.ToString();
                    lblSelected.Text = selectedWord.Turkish.ToString();
                    lblEnglishMean.Text = selectedWord.English.ToString();
                }

                else
                {
                    return;
                }
            }
            else
            {
                return;
            }

        }

   
    }
}
