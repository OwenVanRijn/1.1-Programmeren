using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opdracht9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_calc_Click(object sender, EventArgs e)
        {
            bool sportsoort;
            int leeftijd, lidtijd;
            double contributie;

            sportsoort = radio_voetbal.Checked;
            leeftijd = int.Parse(user_leeftijd.Text);
            lidtijd = int.Parse(user_lidtijd.Text);

            if (sportsoort)
                contributie = 175.00;
            else
                contributie = 225.00;

            if (leeftijd >= 40)
                contributie -= 25.00;

            if (lidtijd >= 10)
                contributie -= 20.00;

            lbl_totaal.Text = string.Format("€ {0:0.00}", contributie);
        }
    }
}
