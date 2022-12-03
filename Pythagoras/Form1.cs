using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pythagoras
{
    public partial class Form1 : Form
    {
        Double a, b, c,answer;
        public Form1()
        {
           
            InitializeComponent();
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Double A=Convert.ToDouble(txtA.Text);
            Double B =Convert.ToDouble (txtB.Text);
            Double C =Convert.ToDouble (txtC.Text);

            if (radA.Checked == true)
            {
                txtA.Clear();
                txtA.Enabled = false;

                answer = (((B*B) + (C*C));

                txtA.Text=answer.ToString();

            }

        }
    }
}
