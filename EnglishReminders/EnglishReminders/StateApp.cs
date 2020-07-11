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
    public partial class StateApp : Form
    {
        public StateApp()
        {
            InitializeComponent();
        }
        public User user { get; set; }
        public Score score { get; set; }

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        private void StateApp_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Right - this.Width, 0);

            this.ControlBox = false;
            this.Text = String.Empty;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImage = Properties.Resources.gradient_blue_pink_abstract_art_wallpaper_preview;
            this.pctLogo.BackgroundImage = Properties.Resources.LoginImage;

            lblName.Text = user.Name;
            lblScore.Text = score.ScorePoint.ToString();
            lblWrong.Text = score.WrongCount.ToString();
            lblCorrect.Text = score.CorrectCout.ToString();
            timer1.Enabled = true;
        }
     

        ///
        /// Handling the window messages
        ///
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ScoreManager sm = new ScoreManager();
            Score score = new Score();
            score = sm.getScore(user);
            lblScore.Text = score.ScorePoint.ToString();
            lblWrong.Text = score.WrongCount.ToString();
            lblCorrect.Text = score.CorrectCout.ToString();
        }

        private void pctLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
