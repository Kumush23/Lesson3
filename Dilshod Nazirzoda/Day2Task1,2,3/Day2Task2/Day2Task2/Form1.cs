using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day2Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Variable
            int YearVariable = int.Parse(textBox1.Text);
            int MonthVariable =int.Parse(textBox2.Text);
            int WeekVariable = int.Parse(textBox3.Text);

            int Year;
            int Month;
            int Week;

            Year = YearVariable * 365;
            Month = MonthVariable * 30;
            Week = WeekVariable * 7;

            label4.Text = (Year + Month + Week).ToString();



            


            
        }
    }
}
