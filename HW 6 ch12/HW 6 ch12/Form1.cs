using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_6_ch12
{
    public partial class Form1 : Form
    {
        int weight; 
       

        public Form1()
        {
            InitializeComponent();
        }

        private void weighrsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void killogramsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                
                weight = Int32.Parse(textBox1.Text);
                if(weight > 0)
                {
                       weightConvertor w = new weightConvertor(weight);
                    richTextBox1.Text = w.kilograms().ToString() + " Kilograms"; 
                }
                else
                {
                    MessageBox.Show("enter a positive numbe"); 
                }
                
            }
            catch
            {
                MessageBox.Show("Please enter a number.");
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void gramsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                weight = Int32.Parse(textBox1.Text);
                if(weight > 0)
                {
                    weightConvertor w = new weightConvertor(weight);
                    richTextBox1.Text = w.Grams().ToString() + " Grams"; 
                }
                else
                {
                    MessageBox.Show("enter a positive number");
                }

            }
            catch
            {
                MessageBox.Show("Please Enter A number.");
            }
        }

        private void poundsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                weight = Int32.Parse(textBox1.Text);
                if (weight > 0)
                {
                    weightConvertor w = new weightConvertor(weight);
                    richTextBox1.Text = w.Pounds.ToString() + " Pounds";
                }
                else
                {
                    MessageBox.Show("enter a postivie number");
                }

            }
            catch
            {
                MessageBox.Show("Please Enter A number.");
            }
        }

        private void ouncesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                weight = Int32.Parse(textBox1.Text);
                if (weight > 0)
                {
                    weightConvertor w = new weightConvertor(weight);
                    richTextBox1.Text = w.Ounces().ToString() + " Ounces";
                }
                else
                {
                    MessageBox.Show("Enter a postivie number");
                }

            }
            catch
            {
                MessageBox.Show("Please Enter A number.");
            }

        }
    }
}
