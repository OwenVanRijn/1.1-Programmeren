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
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_calc_Click(object sender, EventArgs e)
        {
            int zijdes;
            string output = "";

            zijdes = int.Parse(user_zijdes.Text);

            for (int i = 0; i < zijdes; i++)
            {
                for (int i2 = 0; i2 < zijdes; i2++)
                {
                    if (i2 == 0 || i2 == zijdes - 1 || i == 0 || i == zijdes - 1)
                        output += "X";
                    else
                        output += " ";
                }
                output += "\n";
            }

            lbl_box.Text = output;
        }
    }
}
