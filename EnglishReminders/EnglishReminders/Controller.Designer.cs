namespace EnglishReminders
{
    partial class Controller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Controller));
            this.lstWords = new System.Windows.Forms.ListBox();
            this.btnAddWord = new System.Windows.Forms.Button();
            this.btnDeleteWord = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblSelected = new System.Windows.Forms.Label();
            this.lblEnglishMean = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblIDAppearance = new System.Windows.Forms.Label();
            this.lblSelectedAppearance = new System.Windows.Forms.Label();
            this.lblEnglishApperance = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstWords
            // 
            this.lstWords.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lstWords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstWords.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstWords.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lstWords.FormattingEnabled = true;
            this.lstWords.ItemHeight = 21;
            this.lstWords.Location = new System.Drawing.Point(23, 45);
            this.lstWords.Name = "lstWords";
            this.lstWords.Size = new System.Drawing.Size(251, 338);
            this.lstWords.TabIndex = 0;
            this.lstWords.SelectedIndexChanged += new System.EventHandler(this.lstWords_SelectedIndexChanged);
            // 
            // btnAddWord
            // 
            this.btnAddWord.BackColor = System.Drawing.Color.MediumBlue;
            this.btnAddWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddWord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddWord.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddWord.Location = new System.Drawing.Point(280, 45);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(94, 49);
            this.btnAddWord.TabIndex = 1;
            this.btnAddWord.Text = "Ekle";
            this.btnAddWord.UseVisualStyleBackColor = false;
            this.btnAddWord.Click += new System.EventHandler(this.btnAddWord_Click);
            // 
            // btnDeleteWord
            // 
            this.btnDeleteWord.BackColor = System.Drawing.Color.MediumBlue;
            this.btnDeleteWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteWord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteWord.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteWord.Location = new System.Drawing.Point(280, 109);
            this.btnDeleteWord.Name = "btnDeleteWord";
            this.btnDeleteWord.Size = new System.Drawing.Size(94, 49);
            this.btnDeleteWord.TabIndex = 2;
            this.btnDeleteWord.Text = "Sil";
            this.btnDeleteWord.UseVisualStyleBackColor = false;
            this.btnDeleteWord.Click += new System.EventHandler(this.btnDeleteWord_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lstWords);
            this.groupBox2.Controls.Add(this.btnAddWord);
            this.groupBox2.Controls.Add(this.btnDeleteWord);
            this.groupBox2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(31, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 430);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kelimeler";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnExit.Location = new System.Drawing.Point(238, 489);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(190, 38);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Uygulamaya Dön";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.BackColor = System.Drawing.Color.Transparent;
            this.lblSelected.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSelected.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSelected.Location = new System.Drawing.Point(116, 497);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(56, 22);
            this.lblSelected.TabIndex = 11;
            this.lblSelected.Text = "label1";
            // 
            // lblEnglishMean
            // 
            this.lblEnglishMean.AutoSize = true;
            this.lblEnglishMean.BackColor = System.Drawing.Color.Transparent;
            this.lblEnglishMean.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnglishMean.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEnglishMean.Location = new System.Drawing.Point(118, 526);
            this.lblEnglishMean.Name = "lblEnglishMean";
            this.lblEnglishMean.Size = new System.Drawing.Size(59, 22);
            this.lblEnglishMean.TabIndex = 12;
            this.lblEnglishMean.Text = "label2";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblId.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblId.Location = new System.Drawing.Point(73, 469);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(101, 22);
            this.lblId.TabIndex = 13;
            this.lblId.Text = "lblSelected";
            // 
            // lblIDAppearance
            // 
            this.lblIDAppearance.AutoSize = true;
            this.lblIDAppearance.BackColor = System.Drawing.Color.DarkMagenta;
            this.lblIDAppearance.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIDAppearance.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIDAppearance.Location = new System.Drawing.Point(31, 469);
            this.lblIDAppearance.Name = "lblIDAppearance";
            this.lblIDAppearance.Size = new System.Drawing.Size(41, 22);
            this.lblIDAppearance.TabIndex = 13;
            this.lblIDAppearance.Text = "ID : ";
            // 
            // lblSelectedAppearance
            // 
            this.lblSelectedAppearance.AutoSize = true;
            this.lblSelectedAppearance.BackColor = System.Drawing.Color.DarkMagenta;
            this.lblSelectedAppearance.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSelectedAppearance.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSelectedAppearance.Location = new System.Drawing.Point(31, 497);
            this.lblSelectedAppearance.Name = "lblSelectedAppearance";
            this.lblSelectedAppearance.Size = new System.Drawing.Size(79, 22);
            this.lblSelectedAppearance.TabIndex = 13;
            this.lblSelectedAppearance.Text = "Türkçe : ";
            // 
            // lblEnglishApperance
            // 
            this.lblEnglishApperance.AutoSize = true;
            this.lblEnglishApperance.BackColor = System.Drawing.Color.DarkMagenta;
            this.lblEnglishApperance.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnglishApperance.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEnglishApperance.Location = new System.Drawing.Point(31, 525);
            this.lblEnglishApperance.Name = "lblEnglishApperance";
            this.lblEnglishApperance.Size = new System.Drawing.Size(84, 22);
            this.lblEnglishApperance.TabIndex = 13;
            this.lblEnglishApperance.Text = "English : ";
            // 
            // Controller
            // 
            this.AcceptButton = this.btnExit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(470, 566);
            this.ControlBox = false;
            this.Controls.Add(this.lblEnglishApperance);
            this.Controls.Add(this.lblSelectedAppearance);
            this.Controls.Add(this.lblIDAppearance);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblEnglishMean);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Controller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "English Reminders";
            this.Load += new System.EventHandler(this.Controller_Load);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddWord;
        private System.Windows.Forms.Button btnDeleteWord;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ListBox lstWords;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Label lblEnglishMean;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblIDAppearance;
        private System.Windows.Forms.Label lblSelectedAppearance;
        private System.Windows.Forms.Label lblEnglishApperance;
    }
}