using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opdracht5
{
    public partial class Form1 : Form
    {
        static int Addition(int getal1, int getal2)
        {
            return (getal1 + getal2);
        }
        static int Subtraction(int getal1, int getal2)
        {
            return (getal1 - getal2);
        }
        static int Multiply(int getal1, int getal2)
        {
            return (getal1 * getal2);
        }
        static double Divide(int getal1, int getal2)
        {
            return ((double)getal1 / getal2);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Calc_add_Click(object sender, EventArgs e)
        {
            int[] getallen = new int[2];
            int output;

            getallen[0] = int.Parse(user_getal1.Text);
            getallen[1] = int.Parse(user_getal2.Text);

            output = Addition(getallen[0], getallen[1]);

            lbl_uitkomst.Text = output.ToString();
        }

        private void Calc_sub_Click(object sender, EventArgs e)
        {
            int[] getallen = new int[2];
            int output;

            getallen[0] = int.Parse(user_getal1.Text);
            getallen[1] = int.Parse(user_getal2.Text);

            output = Subtraction(getallen[0], getallen[1]);

            lbl_uitkomst.Text = output.ToString();
        }

        private void Calc_mul_Click(object sender, EventArgs e)
        {
            int[] getallen = new int[2];
            int output;

            getallen[0] = int.Parse(user_getal1.Text);
            getallen[1] = int.Parse(user_getal2.Text);

            output = Multiply(getallen[0], getallen[1]);

            lbl_uitkomst.Text = output.ToString();
        }

        private void Calc_div_Click(object sender, EventArgs e)
        {
            int[] getallen = new int[2];
            double output;

            getallen[0] = int.Parse(user_getal1.Text);
            getallen[1] = int.Parse(user_getal2.Text);

            output = Divide(getallen[0], getallen[1]);

            lbl_uitkomst.Text = output.ToString();
        }
    }
}
