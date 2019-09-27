using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opdracht12
{
    public partial class Form1 : Form
    {
        const double basisprijs = 12.00;
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_calc_Click(object sender, EventArgs e)
        {
            double prijs;
            int leeftijd;

            prijs = basisprijs;
            leeftijd = int.Parse(user_leeftijd.Text);

            if (leeftijd < 5 || leeftijd >= 55)
                prijs = 0;
            else if (leeftijd >= 5 && leeftijd <= 12)
                prijs *= 0.5;

            lbl_biosprijs.Text = string.Format("€ {0:0.00}", prijs);
        }
    }
}
