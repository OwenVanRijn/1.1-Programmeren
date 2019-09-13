using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_calc_Click(object sender, EventArgs e)
        {
            string input, output;
            long hours = 0, minutes = 0, seconds = 0;

            input = user_seconds.Text;
            seconds = long.Parse(input);

            hours = seconds / 3600;
            seconds -= hours * 3600;
            minutes = seconds / 60;
            seconds -= minutes * 60;

            output = string.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);
            lbl_time.Text = output;
        }
    }
}
