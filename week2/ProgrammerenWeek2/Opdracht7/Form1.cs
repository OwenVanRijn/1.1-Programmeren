using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht7
{
    public partial class Form1 : Form
    {
        const double btwmultiplier = 0.21;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_del_Click(object sender, EventArgs e)
        {
            user_beginkm.Text = "";
            user_eindkm.Text = "";
            user_ppk.Text = "";
            lbl_prijs.Text = "0";
            lbl_btw.Text = "0";
            lbl_totaal.Text = "0";
        }

        private void Btn_calc_Click(object sender, EventArgs e)
        {
            double prijs, btw, beginkm, eindkm, ppk, totaal;

            beginkm = double.Parse(user_beginkm.Text);
            eindkm = double.Parse(user_eindkm.Text);
            ppk = double.Parse(user_ppk.Text);

            prijs = (eindkm - beginkm) * ppk;
            btw = prijs * btwmultiplier;
            totaal = prijs + btw;

            lbl_prijs.Text = prijs.ToString();
            lbl_btw.Text = btw.ToString();
            lbl_totaal.Text = totaal.ToString();
        }
    }
}
