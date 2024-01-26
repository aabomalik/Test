using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            if (pn_HederNavpar.Width == 250)
            {
                pn_HederNavpar.Width = 250;
                pn_Titlenav.Visible = false;
                pn_HederNavpar.Height = 400;

            }
            else
            {
                pn_HederNavpar.Width = 250;
                pn_Titlenav.Visible = true;
                pn_HederNavpar.Height = 433;

            }
        }
    }
}
