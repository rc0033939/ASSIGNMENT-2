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
                // try catch is used to to stop any mistakes.
                double resistance1 = double.Parse(textBox1.Text);
                double resistance2 = double.Parse(textBox2.Text);
                double resistance3 = double.Parse(textBox3.Text);
                double resistance4 = double.Parse(textBox4.Text);
                //this code above is reading what is in the text box.

                Double total_resistance = resistance1 + resistance2 + resistance3 + resistance4;
                MessageBox.Show("total_resistance = " + total_resistance.ToString("0.00") + "ohms");
                // this code allows the series restistance to be calculated and gives a total resistance.
            }
            catch
            {
                MessageBox.Show("error in inputting values.");
                // used this to show if there is an error.
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

        private void button2_Click(object sender, EventArgs e)
        {
            // we set the values to zero before the statements.
            double resistance5 = 0.0;
            double resistance6 = 0.0;
            double resistance7 = 0.0;
            double resistance8 = 0.0;

            try
            {
                if(textBox6.Text == "0")
                {
                    resistance5 = double.PositiveInfinity;
                }
                else
                {
                    resistance5 = double.Parse(textBox6.Text);
                }
             
                if(textBox7.Text == "0")
                {
                    resistance6 = double.PositiveInfinity;
                }
                else
                {
                    resistance6 = double.Parse(textBox7.Text);
                }
                   
                if(textBox8.Text == "0")
                {
                            resistance7 = double.PositiveInfinity;
                }
                        else
                        {
                            resistance7 = double.Parse(textBox8.Text);
                        }
                   
                            if(textBox9.Text == "0")
                                {
                                resistance8 = double.PositiveInfinity;
                            }
                            else
                            {
                                resistance8 = double.Parse(textBox9.Text);
                            }
// positive infinity is used to replace having a zero
                            
               
 

                Double total_resistance =(1.0/ (1.0/resistance5 + 1.0/resistance6 + 1.0/resistance7 + 1.0/resistance8));
                MessageBox.Show("total_resistance = " + total_resistance.ToString("0.00") + "ohms");
                //this code calculates the total parellel.
            }
            catch
            {
                MessageBox.Show("error in inputting values.");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
