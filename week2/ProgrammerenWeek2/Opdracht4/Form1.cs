using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_calc_Click(object sender, EventArgs e)
        {
            string inputstring;
            double input, result, btw;

            inputstring = user_input.Text;
            input = double.Parse(inputstring);
            btw = input * 0.21;
            result = btw + input;

            lbl_prijs.Text = input.ToString();
            lbl_btw.Text = btw.ToString();
            lbl_totaal.Text = result.ToString();
        }
    }
}
