using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace IS_Kran_Facharbeit
{

    public partial class Form1 : Form
    {
        public bool nokiaAngeschaltet = false;
        public bool nokiaAnim = false;

        public Point LaufkatzeBewegungsRichtung;
        public Point LaufkatzePosition;

        public Form1()
        {
            InitializeComponent();
        }


        private void SchliessenBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        void NokiaPower()
        {
            if (nokiaAngeschaltet == false)
            {
                NokiaBootAnimStart();
            }

            if (nokiaAnim == false)
            {
                NokiaShutDownScreenStart();
            }
        }

        /*private void NokiaAnAus_Click(object sender, EventArgs e)
        {
            NokiaAnAus();

        }*/

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
        }

        private void NokiaBootTimer_Tick(object sender, EventArgs e)
        {
            NokiaBootAnimStop();
        }

        private void NokiaShutDownTimer_Tick(object sender, EventArgs e)
        {
            NokiaShutDownScreenStop();
        }


        private void ZuruecksetzenBtn_Click(object sender, EventArgs e)
        {

        }

        private void InfoBtn_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        void SetLaufkatzeButtonsVisible()
        {
            LaufkatzeHochBtn.Visible = true;
            LaufkatzeLinksButton.Visible = true;
            LaufkatzeRechtsBtn.Visible = true;
            LaufkatzeUntenBtn.Visible = true;
        }
        void SetLaufkatzeButtonsNotVisible()
        {
            LaufkatzeHochBtn.Visible = false;
            LaufkatzeLinksButton.Visible = false;
            LaufkatzeRechtsBtn.Visible = false;
            LaufkatzeUntenBtn.Visible = false;
        }

        void Laufkatzebewegen (Point bewegung)
        {
            if(nokiaAnim == false && nokiaAngeschaltet == true)
            {
                LaufkatzePosition = new Point(LaufkatzePosition.X + LaufkatzeBewegungsRichtung.X, LaufkatzePosition.Y + LaufkatzeBewegungsRichtung.Y);

                label1.Text = "" + LaufkatzePosition;
            }


        }

        //Bewegung starten
        private void LaufkatzeLinksButton_MouseDown(object sender, MouseEventArgs e)
        {
            LaufkatzeBewegungsRichtung = new Point(-1, 0);
        }
        private void LaufkatzeHochBtn_MouseDown(object sender, MouseEventArgs e)
        {
            LaufkatzeBewegungsRichtung = new Point(0, -1);
        }
        private void LaufkatzeRechtsBtn_MouseDown(object sender, MouseEventArgs e)
        {
            LaufkatzeBewegungsRichtung = new Point(1, 0);
        }
        private void LaufkatzeUntenBtn_MouseDown(object sender, MouseEventArgs e)
        {
            LaufkatzeBewegungsRichtung = new Point(0, 1);
        }
        private void BewegungTimer_Tick(object sender, EventArgs e)
        {
            Laufkatzebewegen(LaufkatzeBewegungsRichtung);
        }


        //Bewegung stoppen

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


        //On/Off Button
        private void NokiaAnAus_MouseDown(object sender, MouseEventArgs e)
        {
            NokiaAnAus.BackgroundImage = new Bitmap(IS_Kran_Facharbeit.Properties.Resources.leftrightbuttons);
        }

        private void NokiaAnAus_MouseLeave(object sender, EventArgs e)
        {
            NokiaPower();
        }

        private void NokiaAnAus_MouseUp(object sender, MouseEventArgs e)
        {
            NokiaPower();
        }
    }
}
