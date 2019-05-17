using System;
using System.Drawing;
using System.Windows.Forms;


namespace IS_Kran_Facharbeit
{

    public partial class Form1 : Form
    {
        public bool nokiaAngeschaltet = false;
        public bool nokiaAnim = false;
        public bool mouseOverNokiaPowerButton = false;

        public Point laufkatzeBewegungsRichtung;
        public Point laufkatzePosition = new Point(250, 155);

        public bool lastGegriffen = false;

        public int boden = 524;

        public int geschwindigkeit = 1;

        public bool geschenkGebracht = false;
        public bool weihnachtsmannLosgefahren = false;
        public int sekundenÜbrig = 30;

        public Form1()
        {
            InitializeComponent();
            LaufkatzePictureBx.Location = laufkatzePosition;
            Tablet_OFFPictureBx.BringToFront();
        }


        private void SchliessenBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region// An/Aus Animationen
        void NokiaPower()
        {
            if (nokiaAngeschaltet == false)
            {
                NokiaBootAnimStart();
                NokiaAnAus.BackgroundImage = NokiaPowerImgList.Images[2];
            }
            else if (nokiaAnim == false)
            {
                NokiaShutDownScreenStart();
                NokiaAnAus.BackgroundImage = NokiaPowerImgList.Images[0];
            }
        }

        void NokiaBootAnimStart()
        {
            nokiaAngeschaltet = true;
            NokiaBootAnimPictureBx.Visible = true;
            nokiaAnim = true;
            NokiaBootAnimPictureBx.Enabled = true;
            NokiaBootTimer.Enabled = true;
        }

        void NokiaBootAnimStop()
        {
            NokiaBootAnimPictureBx.Enabled = false;
            NokiaBootTimer.Enabled = false;
            nokiaAnim = false;
            NokiaBootAnimPictureBx.Visible = false;
            SetLaufkatzeButtonsVisible();
            NokiaSmartphonePictureBx.BackgroundImage = (Bitmap)Properties.Resources.Nokia_Smartphone_ON;
            Tablet_OFFPictureBx.SendToBack();
            ZeitÜbrigTimer.Enabled = true;
            sekundenÜbrig = 30;
        }

        void NokiaShutDownScreenStart()
        {
            SetLaufkatzeButtonsNotVisible();
            NokiaBootAnimPictureBx.Visible = true;
            nokiaAnim = true;
            NokiaShutDownTimer.Enabled = true;
            ZeitÜbrigTimer.Enabled = false;
        }

        void NokiaShutDownScreenStop()
        {
            NokiaBootAnimPictureBx.Visible = false;
            nokiaAnim = false;
            NokiaShutDownTimer.Enabled = false;
            nokiaAngeschaltet = !nokiaAngeschaltet;
            NokiaSmartphonePictureBx.BackgroundImage = (Bitmap)Properties.Resources.Nokia_Smartphone_OFF;
            Tablet_OFFPictureBx.BringToFront();
        }

        private void NokiaBootTimer_Tick(object sender, EventArgs e)
        {
            NokiaBootAnimStop();
        }

        private void NokiaShutDownTimer_Tick(object sender, EventArgs e)
        {
            NokiaShutDownScreenStop();
        }
        #endregion

        private void ZuruecksetzenBtn_Click(object sender, EventArgs e)
        {
            lastGegriffen = false;
            laufkatzePosition = new Point(250, 155);
            LastPictureBx.Location = new Point(296, 493);
            WeihnachtsmannPictureBox.Location = new Point(400, 449);
            sekundenÜbrig = 30;
            weihnachtsmannLosgefahren = false;
            ZeitÜbrigTimer.Enabled = true;
        }

        private void InfoBtn_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        #region//ButtonVisible
        void SetLaufkatzeButtonsVisible()
        {
            LaufkatzeHochBtn.Visible = true;
            LaufkatzeLinksButton.Visible = true;
            LaufkatzeRechtsBtn.Visible = true;
            LaufkatzeUntenBtn.Visible = true;
            LastGreifenBtn.Visible = true;
        }
        void SetLaufkatzeButtonsNotVisible()
        {
            LaufkatzeHochBtn.Visible = false;
            LaufkatzeLinksButton.Visible = false;
            LaufkatzeRechtsBtn.Visible = false;
            LaufkatzeUntenBtn.Visible = false;
            LastGreifenBtn.Visible = false;
        }
        #endregion

        void Laufkatzebewegen (Point bewegung)
        {
            if(nokiaAnim == false && nokiaAngeschaltet == true)
            {
                int LastPositionOffset = 5 - geschwindigkeit;
                if (lastGegriffen != true)
                    LastPositionOffset = 4 - geschwindigkeit;
                Point Objekt = new Point(LastPictureBx.Location.X + laufkatzeBewegungsRichtung.X, LastPictureBx.Location.Y + LastPositionOffset + laufkatzeBewegungsRichtung.Y);
                if (lastGegriffen != true)
                    Objekt = new Point(laufkatzePosition.X + laufkatzeBewegungsRichtung.X, laufkatzePosition.Y + laufkatzeBewegungsRichtung.Y);


                if (ImBereich(new Point(laufkatzePosition.X + laufkatzeBewegungsRichtung.X, laufkatzePosition.Y + laufkatzeBewegungsRichtung.Y), new Point(450, 300), 165, 195, 208, 10) &&
                   ImBereich(new Point(LastPictureBx.Location.X + laufkatzeBewegungsRichtung.X, LastPictureBx.Location.Y + LastPositionOffset + laufkatzeBewegungsRichtung.Y), new Point(450, 300), 165, 198, 208, 10) &&
                   NichtKollidieren(Objekt))
                {
                    laufkatzePosition = new Point(laufkatzePosition.X + laufkatzeBewegungsRichtung.X, laufkatzePosition.Y + laufkatzeBewegungsRichtung.Y);

                    LaufkatzePictureBx.Location = laufkatzePosition;

                    label1.Text = "" + laufkatzePosition;

                    if(lastGegriffen == true)
                    {
                        LastPictureBx.Location = new Point(laufkatzePosition.X - 6, laufkatzePosition.Y + LastPictureBx.Size.Height - 5);
                    }
                }
            }

            

            LaufkatzenElementeBewegen();
        }

        #region//Bewegung starten
        private void LaufkatzeLinksButton_MouseDown(object sender, MouseEventArgs e)
        {
            laufkatzeBewegungsRichtung = new Point(-geschwindigkeit, 0);
        }
        private void LaufkatzeHochBtn_MouseDown(object sender, MouseEventArgs e)
        {
            laufkatzeBewegungsRichtung = new Point(0, -geschwindigkeit);
        }
        private void LaufkatzeRechtsBtn_MouseDown(object sender, MouseEventArgs e)
        {
            laufkatzeBewegungsRichtung = new Point(geschwindigkeit, 0);
        }
        private void LaufkatzeUntenBtn_MouseDown(object sender, MouseEventArgs e)
        {
            laufkatzeBewegungsRichtung = new Point(0, geschwindigkeit);
        }
        private void BewegungTimer_Tick(object sender, EventArgs e)
        {
            Laufkatzebewegen(laufkatzeBewegungsRichtung);
        }
        #endregion

        #region//Bewegung stoppen
        

        private void LaufkatzeLinksButton_MouseLeave(object sender, EventArgs e)
        {
            laufkatzeBewegungsRichtung = new Point(0, 0);
        }
        private void LaufkatzeLinksButton_MouseUp(object sender, MouseEventArgs e)
        {
            laufkatzeBewegungsRichtung = new Point(0, 0);
        }
        private void LaufkatzeHochBtn_MouseLeave(object sender, EventArgs e)
        {
            laufkatzeBewegungsRichtung = new Point(0, 0);
        }
        private void LaufkatzeHochBtn_MouseUp(object sender, MouseEventArgs e)
        {
            laufkatzeBewegungsRichtung = new Point(0, 0);
        }
        private void LaufkatzeRechtsBtn_MouseLeave(object sender, EventArgs e)
        {
            laufkatzeBewegungsRichtung = new Point(0, 0);
        }
        private void LaufkatzeRechtsBtn_MouseUp(object sender, MouseEventArgs e)
        {
            laufkatzeBewegungsRichtung = new Point(0, 0);
        }
        private void LaufkatzeUntenBtn_MouseLeave(object sender, EventArgs e)
        {
            laufkatzeBewegungsRichtung = new Point(0, 0);
        }
        private void LaufkatzeUntenBtn_MouseUp(object sender, MouseEventArgs e)
        {
            laufkatzeBewegungsRichtung = new Point(0, 0);
        }
        #endregion//Bewegung SToppen

        #region//An/Aus
        //On/Off Button
        private void NokiaAnAus_MouseDown_1(object sender, MouseEventArgs e)
        {
            if(nokiaAnim == false)
            {
                NokiaAnAus.BackgroundImage = NokiaPowerImgList.Images[1];
                mouseOverNokiaPowerButton = true;
            }

        }

        private void NokiaAnAus_MouseLeave_1(object sender, EventArgs e)
        {
            if(mouseOverNokiaPowerButton == true)
            {
                NokiaPower();
                mouseOverNokiaPowerButton = false;
            }

        }

        private void NokiaAnAus_MouseUp_1(object sender, MouseEventArgs e)
        {
            if (mouseOverNokiaPowerButton == true)
            {
                NokiaPower();
                mouseOverNokiaPowerButton = false;
            }
        }
        #endregion

        void LastGreifen()
        {
            if (ImBereich(laufkatzePosition, LastPictureBx.Location, 50, 0, 20, 20) && !weihnachtsmannLosgefahren && sekundenÜbrig >= 5)
            {
                while(laufkatzePosition.Y + LaufkatzePictureBx.Size.Height + LastPictureBx.Size.Height > 530)
                {
                    laufkatzePosition.Y -= 1;
                }

                lastGegriffen = true;
                LastGreifenBtn.BackgroundImage = (Bitmap)Properties.Resources.unlocked;
            }
        }

        void LastLoslassen()
        {
            if(lastGegriffen == true)
            {
                lastGegriffen = false;
                LastGreifenBtn.BackgroundImage = (Bitmap)Properties.Resources.locked;
            }
        }

        void LaufkatzenElementeBewegen()
        {
            LaufkatzenSeil1Btn.Location = new Point(laufkatzePosition.X + 4, 135);
            LaufkatzenSeil1Btn.Size = new Size(2, laufkatzePosition.Y -135);

            LaufkatzenSeil2Btn.Location = new Point(laufkatzePosition.X + 8, 135);
            LaufkatzenSeil2Btn.Size = new Size(2, laufkatzePosition.Y - 135);

            if(lastGegriffen == true)
            {
                LaufkatzenSeil3Btn.Location = new Point(laufkatzePosition.X + 5, laufkatzePosition.Y + 23);
                LaufkatzenSeil3Btn.Size = new Size(3, 10);
            }
            else
                LaufkatzenSeil3Btn.Location = new Point(770, 300);

            SeilBoxPictureBox.Location = new Point(laufkatzePosition.X - 1, 130);
        }

        public bool NichtKollidieren(Point Objekt)
        {
            if(lastGegriffen == false && Objekt != new Point(LastPictureBx.Location.X + 1, LastPictureBx.Location.Y + 5))
            {
                if (ImBereich(Objekt, LastPictureBx.Location, 27, 20, 10, 30))
                {
                    return false;
                }
            }

                //Schlittenhinten
                if (ImBereich(Objekt, new Point(400, 450), 1, 100, 20, 18))
                {
                    return false;
                }
                //Schlittenboden
                if (ImBereich(Objekt, new Point(440, 460), 3, 100, 50, 25))
                {
                    return false;
                }
                //Weihnachtsmann
                if (ImBereich(Objekt, new Point(460, 440), 16, 100, 36, 20))
                {
                    return false;
                }
            

            return true;
            
        }

        public bool ImBereich(Point Objekt, Point Subjekt, int ÜberY, int UnterY, int RechtsX, int LinksX)
        {
            if (Objekt.Y > Subjekt.Y - ÜberY &&
                Objekt.Y < Subjekt.Y + UnterY &&
                Objekt.X > Subjekt.X - RechtsX &&
                Objekt.X < Subjekt.X + LinksX)
            {
                return true;
            }

            return false;
        }

        private void LastGreifenBtn_Click(object sender, EventArgs e)
        {
            if (lastGegriffen == false)
                LastGreifen();
            else
                LastLoslassen();
        }

        private void LastFallTimer_Tick(object sender, EventArgs e)
        {
            if(lastGegriffen == false)
            {
                if (LastPictureBx.Location.Y + LastPictureBx.Size.Height < boden && NichtKollidieren(new Point(LastPictureBx.Location.X + 1, LastPictureBx.Location.Y  + 5)))
                {
                    LastPictureBx.Location = new Point(LastPictureBx.Location.X, LastPictureBx.Location.Y + 1);
                }
            }
        }

        private void GeschenkeAusgeteiltTimer_Tick(object sender, EventArgs e)
        {
            if(ImBereich(LastPictureBx.Location, new Point(420, 450), 20, 100, 20, 100))
            {
                if(lastGegriffen == true)
                {
                    WeihnachtsmannInfoLbl2.Text = "Das Geschenk ist fast da";
                    geschenkGebracht = false;
                }
                else
                {
                    WeihnachtsmannInfoLbl2.Text = "Super!, du bist eine große Hilfe \nfür den Weihnachtsmann!";
                    geschenkGebracht = true;
                    if (sekundenÜbrig >= 5)
                        sekundenÜbrig = 5;
                }
            }
            else
            {
                WeihnachtsmannInfoLbl2.Text = "";
                geschenkGebracht = false;
            }

            if(weihnachtsmannLosgefahren)
            {
                LastPictureBx.Location = new Point(LastPictureBx.Location.X + 2, LastPictureBx.Location.Y);
                WeihnachtsmannPictureBox.Location = new Point(WeihnachtsmannPictureBox.Location.X + 2, LastPictureBx.Location.Y);
            }
        }

        void WeihnachtsmannFahrt()
        {

        }

        private void ZeitÜbrigTimer_Tick(object sender, EventArgs e)
        {
            if(sekundenÜbrig > 0)
            {
                sekundenÜbrig--;
                TimerLbl.Text = "Der Weihnachtsmann fährt in \n" + sekundenÜbrig + " Sekunden los!";
            }

            if(sekundenÜbrig == 0)
            {
                if(geschenkGebracht == true)
                {
                    ZeitÜbrigTimer.Enabled = false;
                    weihnachtsmannLosgefahren = true;
                }
                else
                {
                    ZeitÜbrigTimer.Enabled = false;
                    TimerLbl.Text = "Due hast es nicht geschafft dem \nWeihnachtsmann sein Geschenk \nzu bringen. :(";
                }

            }
        }
    }
}
