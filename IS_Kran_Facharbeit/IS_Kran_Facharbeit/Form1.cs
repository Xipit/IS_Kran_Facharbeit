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
            NokiaBootAnimStart();
        }

        void NokiaBootAnimStart()
        {
            NokiaBootAnimPictureBx.Enabled = true;
            NokiaBootTimer.Enabled = true;
        }

        void NokiaBootAnimStop()
        {
            NokiaBootAnimPictureBx.Enabled = false;
            NokiaBootTimer.Enabled = false;
        }

        private void NokiaBootTimer_Tick(object sender, EventArgs e)
        {
            NokiaBootAnimStop();

            //MessageBox.Show()
        }
    }
}
