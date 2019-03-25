using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASSIGNMENT_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double resistance1 = double.Parse(textBox1.Text);
                double resistance2 = double.Parse(textBox2.Text);
                double resistance3 = double.Parse(textBox3.Text);
                double resistance4 = double.Parse(textBox4.Text);

                Double total_resistance = resistance1 + resistance2 + resistance3 + resistance4;
                MessageBox.Show("total_resistance = " + total_resistance.ToString("0.00") + "ohms");

            }
            catch
            {
                MessageBox.Show("error in inputting values.");
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
