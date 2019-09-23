using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht8
{
    public partial class Form1 : Form
    {
        const double btwmultiplier = 0.21;
        const int shirtprijs = 30, broekprijs = 100;
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_calc_Click(object sender, EventArgs e)
        {
            int shirt, broek;
            double prijs, btw, totaal;

            shirt = int.Parse(user_shirt.Text);
            broek = int.Parse(user_broek.Text);

            prijs = shirt * shirtprijs + broek * broekprijs;
            btw = prijs * btwmultiplier;
            totaal = prijs + btw;

            lbl_prijs.Text = string.Format("€ {0:0.00}", prijs);
            lbl_btw.Text = string.Format("€ {0:0.00}", btw);
            lbl_totaal.Text = string.Format("€ {0:0.00}", totaal);

            lbl_datum.Text = DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy");
        }
    }
}
