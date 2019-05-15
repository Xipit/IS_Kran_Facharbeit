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
            this.NokiaAnAus = new System.Windows.Forms.Button();
            this.ProgrammsteuerungPnl = new System.Windows.Forms.Panel();
            this.InfoBtn = new System.Windows.Forms.Button();
            this.ZuruecksetzenBtn = new System.Windows.Forms.Button();
            this.SchliessenBtn = new System.Windows.Forms.Button();
            this.KranPnl = new System.Windows.Forms.Panel();
            this.NokiaBootTimer = new System.Windows.Forms.Timer(this.components);
            this.NokiaShutDownTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.NokiaBootAnimPictureBx = new System.Windows.Forms.PictureBox();
            this.NokiaSmartphonePictureBx = new System.Windows.Forms.PictureBox();
            this.KransteuerungPnl.SuspendLayout();
            this.ProgrammsteuerungPnl.SuspendLayout();
            this.KranPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NokiaBootAnimPictureBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NokiaSmartphonePictureBx)).BeginInit();
            this.SuspendLayout();
            // 
            // KransteuerungPnl
            // 
            this.KransteuerungPnl.Controls.Add(this.NokiaBootAnimPictureBx);
            this.KransteuerungPnl.Controls.Add(this.NokiaSmartphonePictureBx);
            this.KransteuerungPnl.Controls.Add(this.NokiaAnAus);
            this.KransteuerungPnl.Location = new System.Drawing.Point(852, 12);
            this.KransteuerungPnl.Name = "KransteuerungPnl";
            this.KransteuerungPnl.Size = new System.Drawing.Size(293, 670);
            this.KransteuerungPnl.TabIndex = 0;
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
            this.InfoBtn.Click += new System.EventHandler(this.InfoBtn_Click);
            // 
            // ZuruecksetzenBtn
            // 
            this.ZuruecksetzenBtn.Location = new System.Drawing.Point(140, 21);
            this.ZuruecksetzenBtn.Name = "ZuruecksetzenBtn";
            this.ZuruecksetzenBtn.Size = new System.Drawing.Size(81, 23);
            this.ZuruecksetzenBtn.TabIndex = 1;
            this.ZuruecksetzenBtn.Text = "Zurücksetzen";
            this.ZuruecksetzenBtn.UseVisualStyleBackColor = true;
            this.ZuruecksetzenBtn.Click += new System.EventHandler(this.ZuruecksetzenBtn_Click);
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
            this.KranPnl.Controls.Add(this.label1);
            this.KranPnl.Location = new System.Drawing.Point(12, 83);
            this.KranPnl.Name = "KranPnl";
            this.KranPnl.Size = new System.Drawing.Size(834, 599);
            this.KranPnl.TabIndex = 2;
            // 
            // NokiaBootTimer
            // 
            this.NokiaBootTimer.Interval = 3900;
            this.NokiaBootTimer.Tick += new System.EventHandler(this.NokiaBootTimer_Tick);
            // 
            // NokiaShutDownTimer
            // 
            this.NokiaShutDownTimer.Interval = 1000;
            this.NokiaShutDownTimer.Tick += new System.EventHandler(this.NokiaShutDownTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(539, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
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
            // NokiaSmartphonePictureBx
            // 
            this.NokiaSmartphonePictureBx.BackColor = System.Drawing.Color.Transparent;
            this.NokiaSmartphonePictureBx.BackgroundImage = global::IS_Kran_Facharbeit.Properties.Resources.Nokia_Smartphone;
            this.NokiaSmartphonePictureBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NokiaSmartphonePictureBx.ErrorImage = global::IS_Kran_Facharbeit.Properties.Resources.Nokia_Smartphone;
            this.NokiaSmartphonePictureBx.Location = new System.Drawing.Point(14, 119);
            this.NokiaSmartphonePictureBx.Name = "NokiaSmartphonePictureBx";
            this.NokiaSmartphonePictureBx.Size = new System.Drawing.Size(267, 516);
            this.NokiaSmartphonePictureBx.TabIndex = 1;
            this.NokiaSmartphonePictureBx.TabStop = false;
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
            this.ProgrammsteuerungPnl.ResumeLayout(false);
            this.KranPnl.ResumeLayout(false);
            this.KranPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NokiaBootAnimPictureBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NokiaSmartphonePictureBx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel KransteuerungPnl;
        private System.Windows.Forms.PictureBox NokiaSmartphonePictureBx;
        private System.Windows.Forms.Button NokiaAnAus;
        private System.Windows.Forms.Panel ProgrammsteuerungPnl;
        private System.Windows.Forms.Button InfoBtn;
        private System.Windows.Forms.Button ZuruecksetzenBtn;
        private System.Windows.Forms.Button SchliessenBtn;
        private System.Windows.Forms.Panel KranPnl;
        public System.Windows.Forms.Timer NokiaBootTimer;
        private System.Windows.Forms.PictureBox NokiaBootAnimPictureBx;
        private System.Windows.Forms.Timer NokiaShutDownTimer;
        private System.Windows.Forms.Label label1;
    }
}

