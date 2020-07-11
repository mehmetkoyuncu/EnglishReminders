namespace EnglishReminders
{
    partial class App
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rbNow = new System.Windows.Forms.RadioButton();
            this.rbHalf = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb6 = new System.Windows.Forms.RadioButton();
            this.rb12 = new System.Windows.Forms.RadioButton();
            this.rb24 = new System.Windows.Forms.RadioButton();
            this.btnBegin = new System.Windows.Forms.Button();
            this.cmbChooseLanguage = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWrongCount = new System.Windows.Forms.Label();
            this.lblCorrectCount = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pctStting = new System.Windows.Forms.PictureBox();
            this.btnUndo = new System.Windows.Forms.PictureBox();
            this.btnUserGuide = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctStting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUndo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUserGuide)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rbNow
            // 
            this.rbNow.AutoSize = true;
            this.rbNow.BackColor = System.Drawing.Color.Transparent;
            this.rbNow.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbNow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbNow.Location = new System.Drawing.Point(15, 46);
            this.rbNow.Name = "rbNow";
            this.rbNow.Size = new System.Drawing.Size(145, 26);
            this.rbNow.TabIndex = 1;
            this.rbNow.TabStop = true;
            this.rbNow.Text = "15 dakikada bir kez";
            this.rbNow.UseVisualStyleBackColor = false;
            // 
            // rbHalf
            // 
            this.rbHalf.AutoSize = true;
            this.rbHalf.BackColor = System.Drawing.Color.Transparent;
            this.rbHalf.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbHalf.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbHalf.Location = new System.Drawing.Point(15, 76);
            this.rbHalf.Name = "rbHalf";
            this.rbHalf.Size = new System.Drawing.Size(147, 26);
            this.rbHalf.TabIndex = 2;
            this.rbHalf.TabStop = true;
            this.rbHalf.Text = "30 dakikada bir kez";
            this.rbHalf.UseVisualStyleBackColor = false;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.BackColor = System.Drawing.Color.Transparent;
            this.rb1.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rb1.Location = new System.Drawing.Point(15, 106);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(122, 26);
            this.rb1.TabIndex = 3;
            this.rb1.TabStop = true;
            this.rb1.Text = "1 saatte bir kez";
            this.rb1.UseVisualStyleBackColor = false;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.BackColor = System.Drawing.Color.Transparent;
            this.rb2.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rb2.Location = new System.Drawing.Point(15, 136);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(124, 26);
            this.rb2.TabIndex = 4;
            this.rb2.TabStop = true;
            this.rb2.Text = "2 saatte bir kez";
            this.rb2.UseVisualStyleBackColor = false;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.BackColor = System.Drawing.Color.Transparent;
            this.rb3.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rb3.Location = new System.Drawing.Point(15, 166);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(124, 26);
            this.rb3.TabIndex = 5;
            this.rb3.TabStop = true;
            this.rb3.Text = "3 saatte bir kez";
            this.rb3.UseVisualStyleBackColor = false;
            // 
            // rb6
            // 
            this.rb6.AutoSize = true;
            this.rb6.BackColor = System.Drawing.Color.Transparent;
            this.rb6.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rb6.Location = new System.Drawing.Point(15, 196);
            this.rb6.Name = "rb6";
            this.rb6.Size = new System.Drawing.Size(124, 26);
            this.rb6.TabIndex = 6;
            this.rb6.TabStop = true;
            this.rb6.Text = "6 saatte bir kez";
            this.rb6.UseVisualStyleBackColor = false;
            // 
            // rb12
            // 
            this.rb12.AutoSize = true;
            this.rb12.BackColor = System.Drawing.Color.Transparent;
            this.rb12.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rb12.Location = new System.Drawing.Point(15, 226);
            this.rb12.Name = "rb12";
            this.rb12.Size = new System.Drawing.Size(129, 26);
            this.rb12.TabIndex = 7;
            this.rb12.TabStop = true;
            this.rb12.Text = "12 saatte bir kez";
            this.rb12.UseVisualStyleBackColor = false;
            // 
            // rb24
            // 
            this.rb24.AutoSize = true;
            this.rb24.BackColor = System.Drawing.Color.Transparent;
            this.rb24.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb24.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rb24.Location = new System.Drawing.Point(15, 256);
            this.rb24.Name = "rb24";
            this.rb24.Size = new System.Drawing.Size(131, 26);
            this.rb24.TabIndex = 8;
            this.rb24.TabStop = true;
            this.rb24.Text = "24 saatte bir kez";
            this.rb24.UseVisualStyleBackColor = false;
            // 
            // btnBegin
            // 
            this.btnBegin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBegin.Font = new System.Drawing.Font("Bahnschrift Light", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBegin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBegin.Location = new System.Drawing.Point(277, 102);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(250, 92);
            this.btnBegin.TabIndex = 9;
            this.btnBegin.Text = "Başla";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // cmbChooseLanguage
            // 
            this.cmbChooseLanguage.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbChooseLanguage.FormattingEnabled = true;
            this.cmbChooseLanguage.Location = new System.Drawing.Point(30, 52);
            this.cmbChooseLanguage.Name = "cmbChooseLanguage";
            this.cmbChooseLanguage.Size = new System.Drawing.Size(194, 32);
            this.cmbChooseLanguage.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbNow);
            this.groupBox1.Controls.Add(this.rbHalf);
            this.groupBox1.Controls.Add(this.rb1);
            this.groupBox1.Controls.Add(this.rb2);
            this.groupBox1.Controls.Add(this.rb24);
            this.groupBox1.Controls.Add(this.rb3);
            this.groupBox1.Controls.Add(this.rb12);
            this.groupBox1.Controls.Add(this.rb6);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(21, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 313);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tekrar Süresi";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cmbChooseLanguage);
            this.groupBox2.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(21, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 108);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sorulacak Dil";
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUser.Location = new System.Drawing.Point(142, 35);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(385, 36);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "label1";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnReset);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.lblWrongCount);
            this.groupBox3.Controls.Add(this.lblCorrectCount);
            this.groupBox3.Controls.Add(this.lblScore);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(277, 212);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 313);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Puan Bİlgisi";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Brown;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(28, 256);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(194, 36);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Puan Bilgisini Sıfırla";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(10, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bilinmeyen Sayısı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bilinen Sayısı :";
            // 
            // lblWrongCount
            // 
            this.lblWrongCount.AutoSize = true;
            this.lblWrongCount.BackColor = System.Drawing.Color.Transparent;
            this.lblWrongCount.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWrongCount.Location = new System.Drawing.Point(174, 146);
            this.lblWrongCount.Name = "lblWrongCount";
            this.lblWrongCount.Size = new System.Drawing.Size(63, 28);
            this.lblWrongCount.TabIndex = 0;
            this.lblWrongCount.Text = "Puan : ";
            // 
            // lblCorrectCount
            // 
            this.lblCorrectCount.AutoSize = true;
            this.lblCorrectCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCorrectCount.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCorrectCount.Location = new System.Drawing.Point(174, 107);
            this.lblCorrectCount.Name = "lblCorrectCount";
            this.lblCorrectCount.Size = new System.Drawing.Size(63, 28);
            this.lblCorrectCount.TabIndex = 0;
            this.lblCorrectCount.Text = "Puan : ";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblScore.Location = new System.Drawing.Point(174, 60);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(81, 36);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Puan : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Puan : ";
            // 
            // pctStting
            // 
            this.pctStting.BackColor = System.Drawing.Color.Transparent;
            this.pctStting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctStting.Location = new System.Drawing.Point(421, 531);
            this.pctStting.Name = "pctStting";
            this.pctStting.Size = new System.Drawing.Size(50, 50);
            this.pctStting.TabIndex = 6;
            this.pctStting.TabStop = false;
            this.pctStting.Click += new System.EventHandler(this.pctStting_Click_1);
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.Transparent;
            this.btnUndo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUndo.Location = new System.Drawing.Point(36, 21);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(50, 50);
            this.btnUndo.TabIndex = 8;
            this.btnUndo.TabStop = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnUserGuide
            // 
            this.btnUserGuide.BackColor = System.Drawing.Color.Transparent;
            this.btnUserGuide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserGuide.Location = new System.Drawing.Point(477, 531);
            this.btnUserGuide.Name = "btnUserGuide";
            this.btnUserGuide.Size = new System.Drawing.Size(50, 50);
            this.btnUserGuide.TabIndex = 9;
            this.btnUserGuide.TabStop = false;
            this.btnUserGuide.Click += new System.EventHandler(this.btnUserGuide_Click);
            // 
            // App
            // 
            this.AcceptButton = this.btnBegin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(563, 587);
            this.ControlBox = false;
            this.Controls.Add(this.btnUserGuide);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.pctStting);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBegin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "English Reminders";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.App_FormClosed);
            this.Load += new System.EventHandler(this.App_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctStting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUndo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUserGuide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbNow;
        private System.Windows.Forms.RadioButton rbHalf;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb6;
        private System.Windows.Forms.RadioButton rb12;
        private System.Windows.Forms.RadioButton rb24;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.ComboBox cmbChooseLanguage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pctStting;
        private System.Windows.Forms.Button btnReset;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblWrongCount;
        private System.Windows.Forms.Label lblCorrectCount;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox btnUndo;
        private System.Windows.Forms.PictureBox btnUserGuide;
    }
}