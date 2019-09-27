using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opdracht10
{
    public partial class Form1 : Form
    {
        const double mult = 0.05;
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_calc_Click(object sender, EventArgs e)
        {
            double salaris, verhoging, niewsalaris;

            salaris = double.Parse(user_salaris.Text);
            verhoging = salaris * mult;

            if (verhoging < 75.00)
                verhoging = 75;

            niewsalaris = salaris + verhoging;

            lbl_verhoging.Text = string.Format("€ {0:0.00}", verhoging);
            lbl_nieuw.Text = string.Format("€ {0:0.00}", niewsalaris);
        }
    }
}
