namespace EnglishReminders
{
    partial class AddWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWord));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddWord = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTurkish = new System.Windows.Forms.TextBox();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.btnUndo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnUndo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(66, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kelime(Türkçe) ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Maroon;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(102, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 57);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kelime Ekle";
            // 
            // btnAddWord
            // 
            this.btnAddWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddWord.Font = new System.Drawing.Font("Bahnschrift SemiBold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddWord.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddWord.Location = new System.Drawing.Point(66, 294);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(345, 59);
            this.btnAddWord.TabIndex = 2;
            this.btnAddWord.Text = "Ekle";
            this.btnAddWord.UseVisualStyleBackColor = true;
            this.btnAddWord.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(66, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kelime(English) ";
            // 
            // txtTurkish
            // 
            this.txtTurkish.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTurkish.Location = new System.Drawing.Point(66, 155);
            this.txtTurkish.Name = "txtTurkish";
            this.txtTurkish.Size = new System.Drawing.Size(341, 44);
            this.txtTurkish.TabIndex = 0;
            // 
            // txtEnglish
            // 
            this.txtEnglish.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEnglish.Location = new System.Drawing.Point(66, 233);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(345, 44);
            this.txtEnglish.TabIndex = 1;
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.Transparent;
            this.btnUndo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUndo.Location = new System.Drawing.Point(21, 35);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(57, 57);
            this.btnUndo.TabIndex = 4;
            this.btnUndo.TabStop = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // AddWord
            // 
            this.AcceptButton = this.btnAddWord;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(469, 389);
            this.ControlBox = false;
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.txtTurkish);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.btnAddWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "English Reminders";
            this.Load += new System.EventHandler(this.AddWord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnUndo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTurkish;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.PictureBox btnUndo;
    }
}