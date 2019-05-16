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

        public Point LaufkatzeBewegungsRichtung;
        public Point LaufkatzePosition = new Point(250, 155);

        public bool LastGegriffen = true;

        public int Ground = 524;
        public Pen LaufkatzenSeilenPen = new Pen(Color.Black, 2F);

        public int geschwindigkeit = 1;

        public Form1()
        {
            InitializeComponent();
            LaufkatzePictureBx.Location = LaufkatzePosition;
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
        }

        void NokiaShutDownScreenStart()
        {
            SetLaufkatzeButtonsNotVisible();
            NokiaBootAnimPictureBx.Visible = true;
            nokiaAnim = true;
            NokiaShutDownTimer.Enabled = true;
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
                if (LastGegriffen != true)
                    LastPositionOffset = 4 - geschwindigkeit;

                if (ImBereich(new Point(LaufkatzePosition.X + LaufkatzeBewegungsRichtung.X, LaufkatzePosition.Y + LaufkatzeBewegungsRichtung.Y), new Point(450, 300), 165, 195, 208, 10) &&
                   ImBereich(new Point(LastPictureBx.Location.X + LaufkatzeBewegungsRichtung.X, LastPictureBx.Location.Y + LastPositionOffset + LaufkatzeBewegungsRichtung.Y), new Point(450, 300), 165, 198, 208, 10)&&
                   NichtKollidierenLaufkatze(new Point(LaufkatzePosition.X + LaufkatzeBewegungsRichtung.X, LaufkatzePosition.Y + LaufkatzeBewegungsRichtung.Y)))
                {
                    LaufkatzePosition = new Point(LaufkatzePosition.X + LaufkatzeBewegungsRichtung.X, LaufkatzePosition.Y + LaufkatzeBewegungsRichtung.Y);

                    LaufkatzePictureBx.Location = LaufkatzePosition;

                    label1.Text = "" + LaufkatzePosition;

                    if(LastGegriffen == true)
                    {
                        LastPictureBx.Location = new Point(LaufkatzePosition.X - 6, LaufkatzePosition.Y + LastPictureBx.Size.Height - 5);
                    }
                }
            }

            

            LaufkatzenElementeBewegen();
        }

        #region//Bewegung starten
        private void LaufkatzeLinksButton_MouseDown(object sender, MouseEventArgs e)
        {
            LaufkatzeBewegungsRichtung = new Point(-geschwindigkeit, 0);
        }
        private void LaufkatzeHochBtn_MouseDown(object sender, MouseEventArgs e)
        {
            LaufkatzeBewegungsRichtung = new Point(0, -geschwindigkeit);
        }
        private void LaufkatzeRechtsBtn_MouseDown(object sender, MouseEventArgs e)
        {
            LaufkatzeBewegungsRichtung = new Point(geschwindigkeit, 0);
        }
        private void LaufkatzeUntenBtn_MouseDown(object sender, MouseEventArgs e)
        {
            LaufkatzeBewegungsRichtung = new Point(0, geschwindigkeit);
        }
        private void BewegungTimer_Tick(object sender, EventArgs e)
        {
            Laufkatzebewegen(LaufkatzeBewegungsRichtung);
        }
        #endregion

        #region//Bewegung stoppen
        

        private void LaufkatzeLinksButton_MouseLeave(object sender, EventArgs e)
        {
            LaufkatzeBewegungsRichtung = new Point(0, 0);
        }
        private void LaufkatzeLinksButton_MouseUp(object sender, MouseEventArgs e)
        {
            LaufkatzeBewegungsRichtung = new Point(0, 0);
        }
        private void LaufkatzeHochBtn_MouseLeave(object sender, EventArgs e)
        {
            LaufkatzeBewegungsRichtung = new Point(0, 0);
        }
        private void LaufkatzeHochBtn_MouseUp(object sender, MouseEventArgs e)
        {
            LaufkatzeBewegungsRichtung = new Point(0, 0);
        }
        private void LaufkatzeRechtsBtn_MouseLeave(object sender, EventArgs e)
        {
            LaufkatzeBewegungsRichtung = new Point(0, 0);
        }
        private void LaufkatzeRechtsBtn_MouseUp(object sender, MouseEventArgs e)
        {
            LaufkatzeBewegungsRichtung = new Point(0, 0);
        }
        private void LaufkatzeUntenBtn_MouseLeave(object sender, EventArgs e)
        {
            LaufkatzeBewegungsRichtung = new Point(0, 0);
        }
        private void LaufkatzeUntenBtn_MouseUp(object sender, MouseEventArgs e)
        {
            LaufkatzeBewegungsRichtung = new Point(0, 0);
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
            if (ImBereich(LaufkatzePosition, LastPictureBx.Location, 50, 0, 20, 20))
            {
                while(LaufkatzePosition.Y + LaufkatzePictureBx.Size.Height + LastPictureBx.Size.Height > 530)
                {
                    LaufkatzePosition.Y -= 1;
                }

                LastGegriffen = true;
                LastGreifenBtn.BackgroundImage = (Bitmap)Properties.Resources.unlocked;
            }
        }

        void LastLoslassen()
        {
            if(LastGegriffen == true)
            {
                LastGegriffen = false;
                LastGreifenBtn.BackgroundImage = (Bitmap)Properties.Resources.locked;
            }
        }

        void LaufkatzenElementeBewegen()
        {
            LaufkatzenSeil1Btn.Location = new Point(LaufkatzePosition.X + 4, 135);
            LaufkatzenSeil1Btn.Size = new Size(2, LaufkatzePosition.Y -135);

            LaufkatzenSeil2Btn.Location = new Point(LaufkatzePosition.X + 8, 135);
            LaufkatzenSeil2Btn.Size = new Size(2, LaufkatzePosition.Y - 135);

            if(LastGegriffen == true)
            {
                LaufkatzenSeil3Btn.Location = new Point(LaufkatzePosition.X + 5, LaufkatzePosition.Y + 23);
                LaufkatzenSeil3Btn.Size = new Size(3, 10);
            }
            else
                LaufkatzenSeil3Btn.Location = new Point(770, 300);

            SeilBoxPictureBox.Location = new Point(LaufkatzePosition.X - 1, 130);
        }

        public bool NichtKollidierenLast(Point Objekt)
        {
 
            //Schlittenhinten
            if (ImBereich(Objekt, new Point(400, 450), 31, 25, 13, 23))
            {
                return false;
            }
            //Schlittenboden
            if (ImBereich(Objekt, new Point(440, 460), 33, 25, 20, 30))
            {
                return false;
            }
            //Weihnachtsmann
            if (ImBereich(Objekt, new Point(460, 440), 46, 25, 29, 30))
            {
                return false;
            }


            return true;
        }

        public bool NichtKollidierenLaufkatze(Point Objekt)
        {
            if(LastGegriffen == false && Objekt != LastPictureBx.Location)
            {
                if (ImBereich(Objekt, LastPictureBx.Location, 27, 20, 10, 30))
                {
                    return false;
                }
            }

            //Schlittenhinten
            if (ImBereich(Objekt, new Point(400, 450), 31, 25, 13, 23))
            {
                return false;
            }
            //Schlittenboden
            if (ImBereich(Objekt, new Point(440, 460), 33, 25, 20, 30))
            {
                return false;
            }
            //Weihnachtsmann
            if (ImBereich(Objekt, new Point(460, 440), 46, 25, 29, 30))
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
            if (LastGegriffen == false)
                LastGreifen();
            else
                LastLoslassen();
        }

        private void LastFallTimer_Tick(object sender, EventArgs e)
        {
            if(LastGegriffen == false)
            {
                if (LastPictureBx.Location.Y + LastPictureBx.Size.Height < Ground && NichtKollidierenLast(LastPictureBx.Location))
                {
                    LastPictureBx.Location = new Point(LastPictureBx.Location.X, LastPictureBx.Location.Y + 1);
                }
            }
        }

    }
}
