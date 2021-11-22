using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day2Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Second = int.Parse(textBox1.Text);
            int Hours = (Second / 60)/60;
            int Minutes = (Second / 60) % 60;
            int Seconds = (Second % 60);
            


            HoursLabel.Text = Hours.ToString();
            MinutesLabel.Text = Minutes.ToString();
            SecondsLabel.Text = Seconds.ToString(); 
        }
    }
}
