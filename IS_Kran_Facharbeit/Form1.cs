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
        public bool geschenkImWagen = false;
        public bool weihnachtsmannLosgefahren = false;
        public int sekundenÜbrig = 30;

        public Form1()
        {
            InitializeComponent();
            LaufkatzePictureBx.Location = laufkatzePosition;
            //Tablet "ausschalten", wird hier gemacht, damit beim arbeiten im Entwurf die PictureBx nicht im Weg ist
            Tablet_OFFPictureBx.BringToFront();
        }

        #region//Schliessen
        private void SchliessenBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region// An/Aus Animationen

        void NokiaPower()
        {
            //starten der Boot, bzw. Shutdown Animationen des Nokia Smartphones
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

        //Animationerkärung:
        //Die Animationen funktionieren durch das enablen (auch visible) der NokiaBootAnimPictureBx
        //Die Animation wird anhand eines Timers gestoppt, der enabled wird wenn die Animation gestartet wird und disabled wenn sie zu Ende ist
        //Anhand der FUnktionen wird auch das "Anschalten" des Tablets durchgeführt
        
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

        //Beenden der Animationen
        private void NokiaBootTimer_Tick(object sender, EventArgs e)
        {
            NokiaBootAnimStop();
        }
        private void NokiaShutDownTimer_Tick(object sender, EventArgs e)
        {
            NokiaShutDownScreenStop();
        }
        #endregion


        #region//An/Aus
        //On/Off Button des Nokia Smartphones
        private void NokiaAnAus_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (nokiaAnim == false)
            {
                NokiaAnAus.BackgroundImage = NokiaPowerImgList.Images[1];
                mouseOverNokiaPowerButton = true;
            }

        }

        private void NokiaAnAus_MouseLeave_1(object sender, EventArgs e)
        {
            if (mouseOverNokiaPowerButton == true)
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


        #region//Info
        private void InfoBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Dieses Programm wurde von Hanno Witzleb und Eliah Lohr zu Bildungszweken erstellt.\n" +
                "Das vorliegende Produkt ist, abzüglich jeglicher verwendeter Grafiken dritter, " +
                "nichtkommerzialisiertes geistiges Eigentum von Impulsm Entertainment. " +
                "Das sogenannte 'Gif' beim Telefonstartvorgang, der Markenname 'Nokia' und die Nokia Telefone sind geistiges Eigentum der Nokia Corporation. " +
                "Die Rechte dritter bleiben unberührt. Komerzielle verbreitung des Softwareprodukts stellt " +
                "eine Verletzung der Rechte gegenüber Impulsm Entertainment und dritter dar." +
                "\n\nimpulsmentertainment.de - 2019/Q2", "Produktinformationen", MessageBoxButtons.OK);
        }
        #endregion

        #region//ButtonVisible
        //Funktionen, damit die Buttons im Smartphone nur sichtbar sind, wenn es an ist
        //Diese werden in den AnimationStop Funktionen gecallt
        void SetLaufkatzeButtonsVisible()
        {
            LaufkatzeHochBtn.Visible = true;
            LaufkatzeLinksButton.Visible = true;
            LaufkatzeRechtsBtn.Visible = true;
            LaufkatzeUntenBtn.Visible = true;
            LastGreifenBtn.Visible = true;
            Geschwindigkeit1Btn.Visible = true;
            Geschwindigkeit2Btn.Visible = true;
            Geschwindigkeit3Btn.Visible = true;
        }
        void SetLaufkatzeButtonsNotVisible()
        {
            LaufkatzeHochBtn.Visible = false;
            LaufkatzeLinksButton.Visible = false;
            LaufkatzeRechtsBtn.Visible = false;
            LaufkatzeUntenBtn.Visible = false;
            LastGreifenBtn.Visible = false;
            Geschwindigkeit1Btn.Visible = false;
            Geschwindigkeit2Btn.Visible = false;
            Geschwindigkeit3Btn.Visible = false;
        }
        #endregion

        #region//Bewegung
        void Laufkatzebewegen (Point bewegung)
        {
            //Diese Funktion wird in LaufkatzeBewegungsTimer_Tick gecallt und führt somit alle par millisekunden diesen code aus
            //Der Point laufkatzeBewegungsrichtung wird durch die Bewegungs Buttons im Smartphone abgeändert
            //Diese befinden sich in den Regionen "Bewegung starten" und "Bewegung stoppen"
            if(nokiaAnim == false && nokiaAngeschaltet == true)
            {
                //ändern der Variablen ob die Last gerade angehängt ist oder nicht, wichtig für Bestimmung ob sich bewegt werden kann
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
                        //falls last angehängt, bewegt dise sich mit
                        LastPictureBx.Location = new Point(laufkatzePosition.X - 6, laufkatzePosition.Y + LastPictureBx.Size.Height - 5);
                    }
                }
            }

            LaufkatzenElementeBewegen();
        }
        void LaufkatzenElementeBewegen()
        {
            //Aktualisierung der extra Elemte die sich mitbewegen, wie bspw. der Seile
            LaufkatzenSeil1Btn.Location = new Point(laufkatzePosition.X + 4, 135);
            LaufkatzenSeil1Btn.Size = new Size(2, laufkatzePosition.Y -135);

            LaufkatzenSeil2Btn.Location = new Point(laufkatzePosition.X + 8, 135);
            LaufkatzenSeil2Btn.Size = new Size(2, laufkatzePosition.Y - 135);

            //kleines Seil zwischen Haken und Last wenn angehängt
            if(lastGegriffen == true)
            {
                LaufkatzenSeil3Btn.Location = new Point(laufkatzePosition.X + 5, laufkatzePosition.Y + 23);
                LaufkatzenSeil3Btn.Size = new Size(3, 10);
            }
            else
                LaufkatzenSeil3Btn.Location = new Point(770, 300);

            SeilBoxPictureBox.Location = new Point(laufkatzePosition.X - 1, 130);
        }
        #endregion

        #region//GeschindigkeitÄndern
        void LaufkatzeBewegungsTimerIntervalÄndern(int neuerInterval)
        {
            LaufkatzeBewegungTimer.Interval = neuerInterval;
        }

        //ändern des Intervals des Timers und damit die Häufigkeit mit der sich die Laufkatze bewegt
        //ändern der Bilder der GeschwindigkeitsButtons um zu verdeutlichen wleche gerade ausgewählt ist
        private void Geschwindigkeit1Btn_Click(object sender, EventArgs e)
        {
            LaufkatzeBewegungsTimerIntervalÄndern(25);
            Geschwindigkeit1Btn.BackgroundImage = (Bitmap)Properties.Resources._1x;
            Geschwindigkeit2Btn.BackgroundImage = (Bitmap)Properties.Resources._2x_non;
            Geschwindigkeit3Btn.BackgroundImage = (Bitmap)Properties.Resources._3x_non;
        }

        private void Geschwindigkeit2Btn_Click(object sender, EventArgs e)
        {
            LaufkatzeBewegungsTimerIntervalÄndern(15);
            Geschwindigkeit1Btn.BackgroundImage = (Bitmap)Properties.Resources._1x_non;
            Geschwindigkeit2Btn.BackgroundImage = (Bitmap)Properties.Resources._2x;
            Geschwindigkeit3Btn.BackgroundImage = (Bitmap)Properties.Resources._3x_non;
        }

        private void Geschwindigkeit3Btn_Click(object sender, EventArgs e)
        {
            LaufkatzeBewegungsTimerIntervalÄndern(3);
            Geschwindigkeit1Btn.BackgroundImage = (Bitmap)Properties.Resources._1x_non;
            Geschwindigkeit2Btn.BackgroundImage = (Bitmap)Properties.Resources._2x_non;
            Geschwindigkeit3Btn.BackgroundImage = (Bitmap)Properties.Resources._3x;
        }
        #endregion

        #region//Bewegung starten
        //während die Buttons gedrückt werden wird der die Bewegungsrichtung gesetzt, die dann mit dem LaufkatzeBewegungTimer_Tick ausgeführt werden
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
        //Durch die bewegungsmethode die wir nutzen ist es wichtig wenn nichts mehr gedrückt wird, die BewegungsRichtung auf null zu setzen
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

        #region//Greifen/Loslassen
        void LastGreifen()
        {
            if (ImBereich(laufkatzePosition, LastPictureBx.Location, 50, 0, 20, 20) && !weihnachtsmannLosgefahren && sekundenÜbrig >= 5)
            {
                while(laufkatzePosition.Y + LaufkatzePictureBx.Size.Height + LastPictureBx.Size.Height > 530)
                {
                    laufkatzePosition.Y -= 1;
                }

                lastGegriffen = true;
                LastGreifenBtn.BackgroundImage = (Bitmap)Properties.Resources.locked;
            }
        }

        void LastLoslassen()
        {
            if(lastGegriffen == true)
            {
                lastGegriffen = false;
                LastGreifenBtn.BackgroundImage = (Bitmap)Properties.Resources.unlocked;
            }
        }
        private void LastGreifenBtn_Click(object sender, EventArgs e)
        {
            if (lastGegriffen == false)
                LastGreifen();
            else
                LastLoslassen();
        }
        #endregion

        #region//Positionchecks
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
        #endregion

        #region//Timer Ticks
        private void LastFallTimer_Tick(object sender, EventArgs e)
        {
            //Im Endeffekt die Gravitation der Last, die nur dann aktiv ist, wenn es nicht angehängt ist und nicht kollidieren würde
            if(lastGegriffen == false && geschenkImWagen == false)
            {
                if (LastPictureBx.Location.Y + LastPictureBx.Size.Height < boden && NichtKollidieren(new Point(LastPictureBx.Location.X + 1, LastPictureBx.Location.Y  + 5)))
                {
                    LastPictureBx.Location = new Point(LastPictureBx.Location.X, LastPictureBx.Location.Y + 1);
                }
                else if(geschenkGebracht == true)
                {
                    geschenkImWagen = true;
                }
            }
        }

        private void GeschenkeAusgeteiltTimer_Tick(object sender, EventArgs e)
        {
            //Feedback ob die Last am richtigen Ort ist
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
            else if(geschenkGebracht == true)
            {
                WeihnachtsmannInfoLbl2.Text = "Super!, du bist eine große Hilfe \nfür den Weihnachtsmann!";
            }
            else
            {
                WeihnachtsmannInfoLbl2.Text = "";
                geschenkGebracht = false;
            }

            //tatsächliches Bewegen des Weihnachtsmannes und der Last, wenn die Last geliefert wurde
            if (weihnachtsmannLosgefahren)
            {
                LastPictureBx.Location = new Point(LastPictureBx.Location.X + 2, LastPictureBx.Location.Y);
                WeihnachtsmannPictureBox.Location = new Point(WeihnachtsmannPictureBox.Location.X + 2, WeihnachtsmannPictureBox.Location.Y);
            }
        }


        private void ZeitÜbrigTimer_Tick(object sender, EventArgs e)
        {
            //Timer visualisierung
            if(sekundenÜbrig > 0)
            {
                sekundenÜbrig--;
                TimerLbl.Text = "Der Weihnachtsmann fährt in \n" + sekundenÜbrig + " Sekunden los!";
            }

            //Die Weihnachtsmannfahrt in Gang treten und den Nochmal Button erscheinen lassen
            if(sekundenÜbrig == 0)
            {
                if(geschenkGebracht == true)
                {
                    ZeitÜbrigTimer.Enabled = false;
                    weihnachtsmannLosgefahren = true;
                    TimerLbl.Text = "Der Weihnachtsmann ist \nlosgefahren!";
                    NeuerVersuchBtn.Enabled = true;
                    NeuerVersuchBtn.Visible = true;
                }
                else
                {
                    ZeitÜbrigTimer.Enabled = false;
                    TimerLbl.Text = "Du hast es nicht geschafft dem\nWeihnachtsmann sein Geschenk\nzu bringen. :(";
                    NeuerVersuchBtn.Enabled = true;
                    NeuerVersuchBtn.Visible = true;
                }

            }
        }
        #endregion

        #region//Zurücksetzen
        void FormZuruecksetzen()
        {
            //Zurücksetzung aller Objekte auf ihren Ausgangsort
            //Bools auf Ausgangsstand zurücksetzen, die nicht durch Timer kontrolliert werden

            lastGegriffen = false;
            laufkatzePosition = new Point(250, 155);
            LastPictureBx.Location = new Point(296, 493);
            WeihnachtsmannPictureBox.Location = new Point(400, 449);
            sekundenÜbrig = 30;
            weihnachtsmannLosgefahren = false;
            geschenkGebracht = false;
            geschenkImWagen = false;
            ZeitÜbrigTimer.Enabled = true;

            NeuerVersuchBtn.Enabled = false;
            NeuerVersuchBtn.Visible = false;
        }

        private void NeuerVersuchBtn_Click(object sender, EventArgs e)
        {
            FormZuruecksetzen();
            TimerLbl.Text = "Der Weihnachtsmann fährt in \n30 Sekunden los!";
        }

        private void ZuruecksetzenBtn_Click(object sender, EventArgs e)
        {
            FormZuruecksetzen();
        }
        #endregion
    }
}
