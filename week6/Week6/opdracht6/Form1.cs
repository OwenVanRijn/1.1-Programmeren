using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opdracht6
{
    public partial class Form1 : Form
    {
        public int ingetal, uitkomst;

        static void KwadraatByReference(ref int getal)
        {
            getal *= getal;
        }

        static void KwadraatByReferenceOut(int getal, out int kwadraat)
        {
            kwadraat = getal * getal;
        }

        static int KwadraatByValue(int getal)
        {
            return (getal * getal);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_calc_out_Click(object sender, EventArgs e)
        {
            ingetal = int.Parse(user_getal.Text);

            KwadraatByReferenceOut(ingetal, out uitkomst);

            lbl_out.Text = uitkomst.ToString();
        }

        private void Btn_calc_val_Click(object sender, EventArgs e)
        {
            ingetal = int.Parse(user_getal.Text);

            uitkomst = KwadraatByValue(ingetal);

            lbl_out.Text = uitkomst.ToString();
        }

        private void Btn_calc_ref_Click(object sender, EventArgs e)
        {
            ingetal = int.Parse(user_getal.Text);

            KwadraatByReference(ref ingetal);

            lbl_out.Text = ingetal.ToString();
        }
    }
}
