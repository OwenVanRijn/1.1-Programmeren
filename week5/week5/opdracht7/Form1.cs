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
            int[] dobbel = new int[6];
            Random rnd = new Random();

            for (int i = 0; i < dobbel.Length; i++)
                dobbel[i] = 0;

            for (int i = 0; i < 6000; i++)
                dobbel[rnd.Next(0, 6)]++;

            for (int i = 1; i <= dobbel.Length; i++)
            {
                Control currentLabel = Controls["label" + i];
                currentLabel.Text = $"Waarde {i} is {dobbel[i - 1]} keer gegooid";
            }
        }
    }
}
