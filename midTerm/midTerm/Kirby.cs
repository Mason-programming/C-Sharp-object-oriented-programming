using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midTerm
{
    public partial class Kirby : Form
    {


       string Fname = null;
       string address = null;
       string Phone;
       int amount;
       bool mailList; 
        public Kirby()
        {
            InitializeComponent();
        }
      
        //close button 
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        // display button that displays the current data 
        private void button1_Click(object sender, EventArgs e)
        {
            Fname = richTextBox1.Text;
            address = richTextBox2.Text;
            Phone = textBox1.Text; 

            bool checkAmount = int.TryParse(richTextBox3.Text, out amount);

            mailList = radioButton1.Checked; 
            // checks if values have been entered and creates preferred customer class object 
            if (checkAmount && Fname != "" && address != "" && Phone != "")
            {
                PerferredCustomer C1 = new PerferredCustomer(1, mailList,Fname, address,Phone);
                C1.amountPurchased = amount;
                C1.discount = amount; 
                MessageBox.Show("First Name: "+ C1.name + "\n" +
                                "Address: " + C1.Address + "\n" +
                                "Phone Number: " + C1.TelephoneNumber + "\n" + 
                                "Purchased Amount: $" + C1.amountPurchased + "\n" + 
                                "Future Discount Amount: " + string.Format("{0:N2}",C1.discount) + "%" + "\n"); 
            }
            else
            {
                MessageBox.Show("Input string was not in the correct format");
            }
          
            
        }

        // clear the form button 
        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            richTextBox3.Text = "";
            radioButton1.Checked = false;
            textBox1.Text = "";
        }
    }
}
