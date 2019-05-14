﻿using System;
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
        public bool nokiaBootAnim = false;

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

            if(nokiaBootAnim == false)
                nokiaAngeschaltet = !nokiaAngeschaltet;
        }

        void NokiaBootAnimStart()
        {
            nokiaBootAnim = true;
            NokiaBootAnimPictureBx.Enabled = true;
            NokiaBootTimer.Enabled = true;
            nokiaAngeschaltet = true;

        }

        void NokiaBootAnimStop()
        {
            NokiaBootAnimPictureBx.Enabled = false;
            NokiaBootTimer.Enabled = false;
            nokiaBootAnim = false;
        }

        private void NokiaBootTimer_Tick(object sender, EventArgs e)
        {
            NokiaBootAnimStop();
        }
    }
}
