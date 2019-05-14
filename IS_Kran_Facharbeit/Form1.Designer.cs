namespace IS_Kran_Facharbeit
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.KransteuerungPnl = new System.Windows.Forms.Panel();
            this.NokiaBootAnimPictureBx = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NokiaAnAus = new System.Windows.Forms.Button();
            this.ProgrammsteuerungPnl = new System.Windows.Forms.Panel();
            this.InfoBtn = new System.Windows.Forms.Button();
            this.ZuruecksetzenBtn = new System.Windows.Forms.Button();
            this.SchliessenBtn = new System.Windows.Forms.Button();
            this.KranPnl = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.NokiaBootTimer = new System.Windows.Forms.Timer(this.components);
            this.KransteuerungPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NokiaBootAnimPictureBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ProgrammsteuerungPnl.SuspendLayout();
            this.KranPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // KransteuerungPnl
            // 
            this.KransteuerungPnl.Controls.Add(this.NokiaBootAnimPictureBx);
            this.KransteuerungPnl.Controls.Add(this.pictureBox1);
            this.KransteuerungPnl.Controls.Add(this.NokiaAnAus);
            this.KransteuerungPnl.Location = new System.Drawing.Point(852, 12);
            this.KransteuerungPnl.Name = "KransteuerungPnl";
            this.KransteuerungPnl.Size = new System.Drawing.Size(293, 670);
            this.KransteuerungPnl.TabIndex = 0;
            // 
            // NokiaBootAnimPictureBx
            // 
            this.NokiaBootAnimPictureBx.Enabled = false;
            this.NokiaBootAnimPictureBx.Image = ((System.Drawing.Image)(resources.GetObject("NokiaBootAnimPictureBx.Image")));
            this.NokiaBootAnimPictureBx.Location = new System.Drawing.Point(47, 200);
            this.NokiaBootAnimPictureBx.Name = "NokiaBootAnimPictureBx";
            this.NokiaBootAnimPictureBx.Size = new System.Drawing.Size(200, 363);
            this.NokiaBootAnimPictureBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NokiaBootAnimPictureBx.TabIndex = 0;
            this.NokiaBootAnimPictureBx.TabStop = false;
            this.NokiaBootAnimPictureBx.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::IS_Kran_Facharbeit.Properties.Resources.Nokia_Smartphone;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = global::IS_Kran_Facharbeit.Properties.Resources.Nokia_Smartphone;
            this.pictureBox1.Location = new System.Drawing.Point(14, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 516);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // NokiaAnAus
            // 
            this.NokiaAnAus.Location = new System.Drawing.Point(102, 21);
            this.NokiaAnAus.Name = "NokiaAnAus";
            this.NokiaAnAus.Size = new System.Drawing.Size(83, 75);
            this.NokiaAnAus.TabIndex = 0;
            this.NokiaAnAus.Text = "An/Aus";
            this.NokiaAnAus.UseVisualStyleBackColor = true;
            this.NokiaAnAus.Click += new System.EventHandler(this.NokiaAnAus_Click);
            // 
            // ProgrammsteuerungPnl
            // 
            this.ProgrammsteuerungPnl.Controls.Add(this.InfoBtn);
            this.ProgrammsteuerungPnl.Controls.Add(this.ZuruecksetzenBtn);
            this.ProgrammsteuerungPnl.Controls.Add(this.SchliessenBtn);
            this.ProgrammsteuerungPnl.Location = new System.Drawing.Point(12, 12);
            this.ProgrammsteuerungPnl.Name = "ProgrammsteuerungPnl";
            this.ProgrammsteuerungPnl.Size = new System.Drawing.Size(834, 65);
            this.ProgrammsteuerungPnl.TabIndex = 1;
            // 
            // InfoBtn
            // 
            this.InfoBtn.Location = new System.Drawing.Point(264, 21);
            this.InfoBtn.Name = "InfoBtn";
            this.InfoBtn.Size = new System.Drawing.Size(75, 23);
            this.InfoBtn.TabIndex = 2;
            this.InfoBtn.Text = "Info";
            this.InfoBtn.UseVisualStyleBackColor = true;
            // 
            // ZuruecksetzenBtn
            // 
            this.ZuruecksetzenBtn.Location = new System.Drawing.Point(140, 21);
            this.ZuruecksetzenBtn.Name = "ZuruecksetzenBtn";
            this.ZuruecksetzenBtn.Size = new System.Drawing.Size(81, 23);
            this.ZuruecksetzenBtn.TabIndex = 1;
            this.ZuruecksetzenBtn.Text = "Zurücksetzen";
            this.ZuruecksetzenBtn.UseVisualStyleBackColor = true;
            // 
            // SchliessenBtn
            // 
            this.SchliessenBtn.Location = new System.Drawing.Point(26, 21);
            this.SchliessenBtn.Name = "SchliessenBtn";
            this.SchliessenBtn.Size = new System.Drawing.Size(75, 23);
            this.SchliessenBtn.TabIndex = 0;
            this.SchliessenBtn.Text = "Schließen";
            this.SchliessenBtn.UseVisualStyleBackColor = true;
            this.SchliessenBtn.Click += new System.EventHandler(this.SchliessenBtn_Click);
            // 
            // KranPnl
            // 
            this.KranPnl.Controls.Add(this.button1);
            this.KranPnl.Location = new System.Drawing.Point(12, 83);
            this.KranPnl.Name = "KranPnl";
            this.KranPnl.Size = new System.Drawing.Size(834, 599);
            this.KranPnl.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(431, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // NokiaBootTimer
            // 
            this.NokiaBootTimer.Interval = 3900;
            this.NokiaBootTimer.Tick += new System.EventHandler(this.NokiaBootTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1157, 695);
            this.Controls.Add(this.KranPnl);
            this.Controls.Add(this.ProgrammsteuerungPnl);
            this.Controls.Add(this.KransteuerungPnl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KransteuerungPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NokiaBootAnimPictureBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ProgrammsteuerungPnl.ResumeLayout(false);
            this.KranPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel KransteuerungPnl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button NokiaAnAus;
        private System.Windows.Forms.Panel ProgrammsteuerungPnl;
        private System.Windows.Forms.Button InfoBtn;
        private System.Windows.Forms.Button ZuruecksetzenBtn;
        private System.Windows.Forms.Button SchliessenBtn;
        private System.Windows.Forms.Panel KranPnl;
        public System.Windows.Forms.Timer NokiaBootTimer;
        private System.Windows.Forms.PictureBox NokiaBootAnimPictureBx;
        private System.Windows.Forms.Button button1;
    }
}

