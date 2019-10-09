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

        public int[] cijfers = new int[20];
        
        void writetolabels(int offset, bool mode)
        {
            if (mode)
                for (int i = 1; i <= 40; i++)
                {
                    Control currentLabel = Controls["label" + i];
                    currentLabel.Text = "-";
                }
            else 
                for (int i = 1; i <= cijfers.Length; i++)
                {
                    Control currentLabel = Controls["label" + (i + offset)];
                    currentLabel.Text = $"Element {i - 1} = {cijfers[i - 1]}";
                }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();

            writetolabels(0, true);

            for (int i = 0; i < cijfers.Length; i++)
                cijfers[i] = rnd.Next(500);

            writetolabels(0, false);
        }

        private void Btn_calc_Click(object sender, EventArgs e)
        {
            int vergelijk;

            vergelijk = int.Parse(user_vergelijk.Text);

            for (int i = 0; i < cijfers.Length; i++)
            {
                if (cijfers[i] >= vergelijk)
                    cijfers[i] += 10;
                else
                    cijfers[i] -= 5;
            }

            writetolabels(20, false);

            btn_calc.Enabled = false;
        }
    }
}
