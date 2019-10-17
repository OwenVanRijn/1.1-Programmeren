using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opdracht7
{
    public partial class Form1 : Form
    {
        static void CelsiustoKelvin(ref double graden, out string gradentype)
        {
            graden += 273;
            gradentype = "K";
        }
        static void CelsiustoFahrenheit(ref double graden, out string gradentype)
        {
            graden = (graden * 9 / 5) + 32;
            gradentype = "°F";
        }
        static void FahrenheittoCelsius(ref double graden, out string gradentype)
        {
            graden = (graden - 32) * 5 / 9;
            gradentype = "°C";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_calc_Click(object sender, EventArgs e)
        {
            double graden;
            string gradentype;

            graden = double.Parse(user_graden.Text);

            if (radio_ctok.Checked)
                CelsiustoKelvin(ref graden, out gradentype);
            else if (radio_ctof.Checked)
                CelsiustoFahrenheit(ref graden, out gradentype);
            else
                FahrenheittoCelsius(ref graden, out gradentype);

            lbl_out.Text = $"{graden:0.00} {gradentype}";
        }
    }
}
