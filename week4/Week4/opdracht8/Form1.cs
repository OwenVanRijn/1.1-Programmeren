using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opdracht8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_calc_Click(object sender, EventArgs e)
        {
            int n, somoptel = 0, somformule;

            n = int.Parse(user_n.Text);

            for (int i = 1; i <= n; i++)
                somoptel += i;

            somformule = n * (n + 1) / 2;

            lbl_som_optel.Text = somoptel.ToString();
            lbl_som_formule.Text = somformule.ToString();
        }
    }
}
