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
            this.label1 = new System.Windows.Forms.Label();
            this.ProgrammsteuerungPnl = new System.Windows.Forms.Panel();
            this.InfoBtn = new System.Windows.Forms.Button();
            this.ZuruecksetzenBtn = new System.Windows.Forms.Button();
            this.SchliessenBtn = new System.Windows.Forms.Button();
            this.KranPnl = new System.Windows.Forms.Panel();
            this.NokiaBootTimer = new System.Windows.Forms.Timer(this.components);
            this.NokiaShutDownTimer = new System.Windows.Forms.Timer(this.components);
            this.LaufkatzeBewegungTimer = new System.Windows.Forms.Timer(this.components);
            this.NokiaPowerImgList = new System.Windows.Forms.ImageList(this.components);
            this.LastFallTimer = new System.Windows.Forms.Timer(this.components);
            this.LaufkatzenSeil1Btn = new System.Windows.Forms.Button();
            this.LaufkatzenSeil2Btn = new System.Windows.Forms.Button();
            this.LaufkatzenSeil3Btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SeilBoxPictureBox = new System.Windows.Forms.PictureBox();
            this.LaufkatzePictureBx = new System.Windows.Forms.PictureBox();
            this.LastPictureBx = new System.Windows.Forms.PictureBox();
            this.BackgroundImgPictureBx = new System.Windows.Forms.PictureBox();
            this.TabletPictureBx = new System.Windows.Forms.PictureBox();
            this.Tablet_OFFPictureBx = new System.Windows.Forms.PictureBox();
            this.NokiaBootAnimPictureBx = new System.Windows.Forms.PictureBox();
            this.LastGreifenBtn = new System.Windows.Forms.Button();
            this.NokiaAnAus = new System.Windows.Forms.Button();
            this.LaufkatzeHochBtn = new System.Windows.Forms.Button();
            this.LaufkatzeUntenBtn = new System.Windows.Forms.Button();
            this.LaufkatzeRechtsBtn = new System.Windows.Forms.Button();
            this.LaufkatzeLinksButton = new System.Windows.Forms.Button();
            this.NokiaSmartphonePictureBx = new System.Windows.Forms.PictureBox();
            this.KransteuerungPnl.SuspendLayout();
            this.ProgrammsteuerungPnl.SuspendLayout();
            this.KranPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeilBoxPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaufkatzePictureBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastPictureBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundImgPictureBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabletPictureBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tablet_OFFPictureBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NokiaBootAnimPictureBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NokiaSmartphonePictureBx)).BeginInit();
            this.SuspendLayout();
            // 
            // KransteuerungPnl
            // 
            this.KransteuerungPnl.BackColor = System.Drawing.Color.Transparent;
            this.KransteuerungPnl.Controls.Add(this.NokiaBootAnimPictureBx);
            this.KransteuerungPnl.Controls.Add(this.LastGreifenBtn);
            this.KransteuerungPnl.Controls.Add(this.label1);
            this.KransteuerungPnl.Controls.Add(this.NokiaAnAus);
            this.KransteuerungPnl.Controls.Add(this.LaufkatzeHochBtn);
            this.KransteuerungPnl.Controls.Add(this.LaufkatzeUntenBtn);
            this.KransteuerungPnl.Controls.Add(this.LaufkatzeRechtsBtn);
            this.KransteuerungPnl.Controls.Add(this.LaufkatzeLinksButton);
            this.KransteuerungPnl.Controls.Add(this.NokiaSmartphonePictureBx);
            this.KransteuerungPnl.Location = new System.Drawing.Point(852, 12);
            this.KransteuerungPnl.Name = "KransteuerungPnl";
            this.KransteuerungPnl.Size = new System.Drawing.Size(293, 670);
            this.KransteuerungPnl.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // ProgrammsteuerungPnl
            // 
            this.ProgrammsteuerungPnl.BackColor = System.Drawing.Color.Transparent;
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
            this.KranPnl.BackColor = System.Drawing.Color.Transparent;
            this.KranPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.KranPnl.Controls.Add(this.LaufkatzenSeil3Btn);
            this.KranPnl.Controls.Add(this.SeilBoxPictureBox);
            this.KranPnl.Controls.Add(this.LaufkatzePictureBx);
            this.KranPnl.Controls.Add(this.LastPictureBx);
            this.KranPnl.Controls.Add(this.pictureBox1);
            this.KranPnl.Controls.Add(this.LaufkatzenSeil2Btn);
            this.KranPnl.Controls.Add(this.LaufkatzenSeil1Btn);
            this.KranPnl.Controls.Add(this.BackgroundImgPictureBx);
            this.KranPnl.Controls.Add(this.TabletPictureBx);
            this.KranPnl.Controls.Add(this.Tablet_OFFPictureBx);
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
            // LaufkatzeBewegungTimer
            // 
            this.LaufkatzeBewegungTimer.Enabled = true;
            this.LaufkatzeBewegungTimer.Interval = 15;
            this.LaufkatzeBewegungTimer.Tick += new System.EventHandler(this.BewegungTimer_Tick);
            // 
            // NokiaPowerImgList
            // 
            this.NokiaPowerImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("NokiaPowerImgList.ImageStream")));
            this.NokiaPowerImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.NokiaPowerImgList.Images.SetKeyName(0, "aus.jpg");
            this.NokiaPowerImgList.Images.SetKeyName(1, "pressed.jpg");
            this.NokiaPowerImgList.Images.SetKeyName(2, "an.jpg");
            // 
            // LastFallTimer
            // 
            this.LastFallTimer.Enabled = true;
            this.LastFallTimer.Interval = 5;
            this.LastFallTimer.Tick += new System.EventHandler(this.LastFallTimer_Tick);
            // 
            // LaufkatzenSeil1Btn
            // 
            this.LaufkatzenSeil1Btn.BackColor = System.Drawing.Color.Black;
            this.LaufkatzenSeil1Btn.FlatAppearance.BorderSize = 0;
            this.LaufkatzenSeil1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LaufkatzenSeil1Btn.Location = new System.Drawing.Point(644, 139);
            this.LaufkatzenSeil1Btn.Name = "LaufkatzenSeil1Btn";
            this.LaufkatzenSeil1Btn.Size = new System.Drawing.Size(24, 56);
            this.LaufkatzenSeil1Btn.TabIndex = 4;
            this.LaufkatzenSeil1Btn.UseVisualStyleBackColor = false;
            // 
            // LaufkatzenSeil2Btn
            // 
            this.LaufkatzenSeil2Btn.BackColor = System.Drawing.Color.Black;
            this.LaufkatzenSeil2Btn.FlatAppearance.BorderSize = 0;
            this.LaufkatzenSeil2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LaufkatzenSeil2Btn.Location = new System.Drawing.Point(706, 139);
            this.LaufkatzenSeil2Btn.Name = "LaufkatzenSeil2Btn";
            this.LaufkatzenSeil2Btn.Size = new System.Drawing.Size(24, 56);
            this.LaufkatzenSeil2Btn.TabIndex = 5;
            this.LaufkatzenSeil2Btn.UseVisualStyleBackColor = false;
            // 
            // LaufkatzenSeil3Btn
            // 
            this.LaufkatzenSeil3Btn.BackColor = System.Drawing.Color.Black;
            this.LaufkatzenSeil3Btn.FlatAppearance.BorderSize = 0;
            this.LaufkatzenSeil3Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LaufkatzenSeil3Btn.Location = new System.Drawing.Point(770, 297);
            this.LaufkatzenSeil3Btn.Name = "LaufkatzenSeil3Btn";
            this.LaufkatzenSeil3Btn.Size = new System.Drawing.Size(27, 30);
            this.LaufkatzenSeil3Btn.TabIndex = 6;
            this.LaufkatzenSeil3Btn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::IS_Kran_Facharbeit.Properties.Resources.WeihnachtsmannFertig;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(400, 449);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(353, 75);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // SeilBoxPictureBox
            // 
            this.SeilBoxPictureBox.BackgroundImage = global::IS_Kran_Facharbeit.Properties.Resources.rechteck;
            this.SeilBoxPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SeilBoxPictureBox.Location = new System.Drawing.Point(264, 129);
            this.SeilBoxPictureBox.Name = "SeilBoxPictureBox";
            this.SeilBoxPictureBox.Size = new System.Drawing.Size(16, 10);
            this.SeilBoxPictureBox.TabIndex = 8;
            this.SeilBoxPictureBox.TabStop = false;
            // 
            // LaufkatzePictureBx
            // 
            this.LaufkatzePictureBx.BackgroundImage = global::IS_Kran_Facharbeit.Properties.Resources.haken;
            this.LaufkatzePictureBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LaufkatzePictureBx.Location = new System.Drawing.Point(458, 287);
            this.LaufkatzePictureBx.Name = "LaufkatzePictureBx";
            this.LaufkatzePictureBx.Size = new System.Drawing.Size(15, 28);
            this.LaufkatzePictureBx.TabIndex = 2;
            this.LaufkatzePictureBx.TabStop = false;
            // 
            // LastPictureBx
            // 
            this.LastPictureBx.BackgroundImage = global::IS_Kran_Facharbeit.Properties.Resources.last;
            this.LastPictureBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LastPictureBx.Location = new System.Drawing.Point(296, 493);
            this.LastPictureBx.Name = "LastPictureBx";
            this.LastPictureBx.Size = new System.Drawing.Size(25, 31);
            this.LastPictureBx.TabIndex = 3;
            this.LastPictureBx.TabStop = false;
            // 
            // BackgroundImgPictureBx
            // 
            this.BackgroundImgPictureBx.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImgPictureBx.BackgroundImage = global::IS_Kran_Facharbeit.Properties.Resources.kran;
            this.BackgroundImgPictureBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackgroundImgPictureBx.Location = new System.Drawing.Point(71, 73);
            this.BackgroundImgPictureBx.Name = "BackgroundImgPictureBx";
            this.BackgroundImgPictureBx.Size = new System.Drawing.Size(473, 451);
            this.BackgroundImgPictureBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackgroundImgPictureBx.TabIndex = 0;
            this.BackgroundImgPictureBx.TabStop = false;
            // 
            // TabletPictureBx
            // 
            this.TabletPictureBx.BackgroundImage = global::IS_Kran_Facharbeit.Properties.Resources.tablet;
            this.TabletPictureBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TabletPictureBx.Location = new System.Drawing.Point(26, 23);
            this.TabletPictureBx.Name = "TabletPictureBx";
            this.TabletPictureBx.Size = new System.Drawing.Size(784, 551);
            this.TabletPictureBx.TabIndex = 1;
            this.TabletPictureBx.TabStop = false;
            // 
            // Tablet_OFFPictureBx
            // 
            this.Tablet_OFFPictureBx.BackColor = System.Drawing.Color.Black;
            this.Tablet_OFFPictureBx.Location = new System.Drawing.Point(71, 70);
            this.Tablet_OFFPictureBx.Name = "Tablet_OFFPictureBx";
            this.Tablet_OFFPictureBx.Size = new System.Drawing.Size(695, 456);
            this.Tablet_OFFPictureBx.TabIndex = 7;
            this.Tablet_OFFPictureBx.TabStop = false;
            // 
            // NokiaBootAnimPictureBx
            // 
            this.NokiaBootAnimPictureBx.Cursor = System.Windows.Forms.Cursors.AppStarting;
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
            // LastGreifenBtn
            // 
            this.LastGreifenBtn.BackgroundImage = global::IS_Kran_Facharbeit.Properties.Resources.locked;
            this.LastGreifenBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LastGreifenBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LastGreifenBtn.FlatAppearance.BorderSize = 0;
            this.LastGreifenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LastGreifenBtn.Location = new System.Drawing.Point(124, 338);
            this.LastGreifenBtn.Name = "LastGreifenBtn";
            this.LastGreifenBtn.Size = new System.Drawing.Size(46, 45);
            this.LastGreifenBtn.TabIndex = 3;
            this.LastGreifenBtn.UseVisualStyleBackColor = true;
            this.LastGreifenBtn.Visible = false;
            this.LastGreifenBtn.Click += new System.EventHandler(this.LastGreifenBtn_Click);
            // 
            // NokiaAnAus
            // 
            this.NokiaAnAus.BackColor = System.Drawing.Color.Black;
            this.NokiaAnAus.BackgroundImage = global::IS_Kran_Facharbeit.Properties.Resources.aus;
            this.NokiaAnAus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NokiaAnAus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NokiaAnAus.FlatAppearance.BorderSize = 0;
            this.NokiaAnAus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NokiaAnAus.Location = new System.Drawing.Point(105, 12);
            this.NokiaAnAus.Name = "NokiaAnAus";
            this.NokiaAnAus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NokiaAnAus.Size = new System.Drawing.Size(90, 90);
            this.NokiaAnAus.TabIndex = 7;
            this.NokiaAnAus.UseVisualStyleBackColor = false;
            this.NokiaAnAus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NokiaAnAus_MouseDown_1);
            this.NokiaAnAus.MouseLeave += new System.EventHandler(this.NokiaAnAus_MouseLeave_1);
            this.NokiaAnAus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NokiaAnAus_MouseUp_1);
            // 
            // LaufkatzeHochBtn
            // 
            this.LaufkatzeHochBtn.BackColor = System.Drawing.Color.Transparent;
            this.LaufkatzeHochBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LaufkatzeHochBtn.BackgroundImage")));
            this.LaufkatzeHochBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LaufkatzeHochBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LaufkatzeHochBtn.FlatAppearance.BorderSize = 0;
            this.LaufkatzeHochBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LaufkatzeHochBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LaufkatzeHochBtn.Location = new System.Drawing.Point(122, 286);
            this.LaufkatzeHochBtn.Name = "LaufkatzeHochBtn";
            this.LaufkatzeHochBtn.Size = new System.Drawing.Size(50, 50);
            this.LaufkatzeHochBtn.TabIndex = 6;
            this.LaufkatzeHochBtn.UseVisualStyleBackColor = false;
            this.LaufkatzeHochBtn.Visible = false;
            this.LaufkatzeHochBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LaufkatzeHochBtn_MouseDown);
            this.LaufkatzeHochBtn.MouseLeave += new System.EventHandler(this.LaufkatzeHochBtn_MouseLeave);
            this.LaufkatzeHochBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LaufkatzeHochBtn_MouseUp);
            // 
            // LaufkatzeUntenBtn
            // 
            this.LaufkatzeUntenBtn.BackColor = System.Drawing.Color.Transparent;
            this.LaufkatzeUntenBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LaufkatzeUntenBtn.BackgroundImage")));
            this.LaufkatzeUntenBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LaufkatzeUntenBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LaufkatzeUntenBtn.FlatAppearance.BorderSize = 0;
            this.LaufkatzeUntenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LaufkatzeUntenBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LaufkatzeUntenBtn.Location = new System.Drawing.Point(122, 386);
            this.LaufkatzeUntenBtn.Name = "LaufkatzeUntenBtn";
            this.LaufkatzeUntenBtn.Size = new System.Drawing.Size(50, 50);
            this.LaufkatzeUntenBtn.TabIndex = 5;
            this.LaufkatzeUntenBtn.UseVisualStyleBackColor = false;
            this.LaufkatzeUntenBtn.Visible = false;
            this.LaufkatzeUntenBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LaufkatzeUntenBtn_MouseDown);
            this.LaufkatzeUntenBtn.MouseLeave += new System.EventHandler(this.LaufkatzeUntenBtn_MouseLeave);
            this.LaufkatzeUntenBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LaufkatzeUntenBtn_MouseUp);
            // 
            // LaufkatzeRechtsBtn
            // 
            this.LaufkatzeRechtsBtn.BackColor = System.Drawing.Color.Transparent;
            this.LaufkatzeRechtsBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LaufkatzeRechtsBtn.BackgroundImage")));
            this.LaufkatzeRechtsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LaufkatzeRechtsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LaufkatzeRechtsBtn.FlatAppearance.BorderSize = 0;
            this.LaufkatzeRechtsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LaufkatzeRechtsBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LaufkatzeRechtsBtn.Location = new System.Drawing.Point(172, 336);
            this.LaufkatzeRechtsBtn.Name = "LaufkatzeRechtsBtn";
            this.LaufkatzeRechtsBtn.Size = new System.Drawing.Size(50, 50);
            this.LaufkatzeRechtsBtn.TabIndex = 3;
            this.LaufkatzeRechtsBtn.UseVisualStyleBackColor = false;
            this.LaufkatzeRechtsBtn.Visible = false;
            this.LaufkatzeRechtsBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LaufkatzeRechtsBtn_MouseDown);
            this.LaufkatzeRechtsBtn.MouseLeave += new System.EventHandler(this.LaufkatzeRechtsBtn_MouseLeave);
            this.LaufkatzeRechtsBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LaufkatzeRechtsBtn_MouseUp);
            // 
            // LaufkatzeLinksButton
            // 
            this.LaufkatzeLinksButton.BackColor = System.Drawing.Color.Transparent;
            this.LaufkatzeLinksButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LaufkatzeLinksButton.BackgroundImage")));
            this.LaufkatzeLinksButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LaufkatzeLinksButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LaufkatzeLinksButton.FlatAppearance.BorderSize = 0;
            this.LaufkatzeLinksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LaufkatzeLinksButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LaufkatzeLinksButton.Location = new System.Drawing.Point(71, 336);
            this.LaufkatzeLinksButton.Name = "LaufkatzeLinksButton";
            this.LaufkatzeLinksButton.Size = new System.Drawing.Size(50, 50);
            this.LaufkatzeLinksButton.TabIndex = 2;
            this.LaufkatzeLinksButton.UseVisualStyleBackColor = false;
            this.LaufkatzeLinksButton.Visible = false;
            this.LaufkatzeLinksButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LaufkatzeLinksButton_MouseDown);
            this.LaufkatzeLinksButton.MouseLeave += new System.EventHandler(this.LaufkatzeLinksButton_MouseLeave);
            this.LaufkatzeLinksButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LaufkatzeLinksButton_MouseUp);
            // 
            // NokiaSmartphonePictureBx
            // 
            this.NokiaSmartphonePictureBx.BackColor = System.Drawing.Color.Transparent;
            this.NokiaSmartphonePictureBx.BackgroundImage = global::IS_Kran_Facharbeit.Properties.Resources.Nokia_Smartphone_OFF;
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
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1157, 695);
            this.Controls.Add(this.KranPnl);
            this.Controls.Add(this.ProgrammsteuerungPnl);
            this.Controls.Add(this.KransteuerungPnl);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KransteuerungPnl.ResumeLayout(false);
            this.KransteuerungPnl.PerformLayout();
            this.ProgrammsteuerungPnl.ResumeLayout(false);
            this.KranPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeilBoxPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaufkatzePictureBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastPictureBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundImgPictureBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabletPictureBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tablet_OFFPictureBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NokiaBootAnimPictureBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NokiaSmartphonePictureBx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel KransteuerungPnl;
        private System.Windows.Forms.PictureBox NokiaSmartphonePictureBx;
        private System.Windows.Forms.Panel ProgrammsteuerungPnl;
        private System.Windows.Forms.Button InfoBtn;
        private System.Windows.Forms.Button ZuruecksetzenBtn;
        private System.Windows.Forms.Button SchliessenBtn;
        private System.Windows.Forms.Panel KranPnl;
        public System.Windows.Forms.Timer NokiaBootTimer;
        private System.Windows.Forms.PictureBox NokiaBootAnimPictureBx;
        private System.Windows.Forms.Timer NokiaShutDownTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LaufkatzeLinksButton;
        private System.Windows.Forms.Timer LaufkatzeBewegungTimer;
        private System.Windows.Forms.Button LaufkatzeUntenBtn;
        private System.Windows.Forms.Button LaufkatzeRechtsBtn;
        private System.Windows.Forms.Button LaufkatzeHochBtn;
        private System.Windows.Forms.Button NokiaAnAus;
        private System.Windows.Forms.ImageList NokiaPowerImgList;
        private System.Windows.Forms.PictureBox BackgroundImgPictureBx;
        private System.Windows.Forms.PictureBox TabletPictureBx;
        private System.Windows.Forms.PictureBox LaufkatzePictureBx;
        private System.Windows.Forms.PictureBox LastPictureBx;
        private System.Windows.Forms.Button LastGreifenBtn;
        private System.Windows.Forms.Timer LastFallTimer;
        private System.Windows.Forms.Button LaufkatzenSeil1Btn;
        private System.Windows.Forms.Button LaufkatzenSeil2Btn;
        private System.Windows.Forms.Button LaufkatzenSeil3Btn;
        private System.Windows.Forms.PictureBox Tablet_OFFPictureBx;
        private System.Windows.Forms.PictureBox SeilBoxPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

