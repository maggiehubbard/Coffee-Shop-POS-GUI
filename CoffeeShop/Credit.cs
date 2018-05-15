using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class Credit : Form
    {
        public Credit()
        {
            InitializeComponent();
        }

        private void Credit_Load(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBox1.Text, @"^[\d]{4}[ \. -][\d]{4}[ \. -][\d]{4}[ \. -][\d]{4}$"))
            {
                MessageBox.Show("Error: Credit Card number was invalid.Please try again.");
            }
            else if (!Regex.IsMatch(textBox2.Text, @"[\d]{2}[/][\d]{2}"))
            {
                MessageBox.Show("Error: Credit Card expiration month/year was invalid.Please try again.");
            }
            else if (!Regex.IsMatch(textBox3.Text, @"[\d]{3}"))
            {
                MessageBox.Show("Error: Credit Card CVV was invalid.Please try again.");
            }
            else
            {
                MessageBox.Show("Credit Card was approved! Enjoy!");
                CreditRec rec = new CreditRec();
                rec.Show();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 toMM = new Form1();
            toMM.Show();
        }
    }
}
