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
    public partial class Check : Form
    {
        public Check()
        {
            InitializeComponent();
        }

        private void Check_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBox1.Text, @"[\d]{9}[ - \]{[\d]{9}"))
            {
                MessageBox.Show("Error: Check number was invalid. Please try again.");
            }
            else
            {
                MessageBox.Show("Check Accepted");
                CheckRec rec = new CheckRec();
                rec.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 mm = new Form1();
            mm.Show();
        }
    }
}
