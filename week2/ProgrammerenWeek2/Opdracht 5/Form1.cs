using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_calc_Click(object sender, EventArgs e)
        {
            double[] getallen = new double[3];
            double result = 0;

            getallen[0] = double.Parse(user_getal1.Text);
            getallen[1] = double.Parse(user_getal2.Text);
            getallen[2] = double.Parse(user_getal3.Text);

            result = (getallen[0] + getallen[1] + getallen[2]) / 3;

            lbl_result.Text = result.ToString();
        }
    }
}
