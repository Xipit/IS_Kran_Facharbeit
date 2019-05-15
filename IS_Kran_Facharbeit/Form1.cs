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

        public Form1()
        {
            InitializeComponent();
        }

        private void SchliessenBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NokiaAnAus_Click(object sender, EventArgs e)
        {
            if (nokiaAngeschaltet == false)
            {
                NokiaBootAnimStart();
            }

            if(nokiaAnim == false)
            {
                NokiaShutDownScreenStart();
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
        }

        void NokiaShutDownScreenStart()
        {
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

    }
}
