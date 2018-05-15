using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class Cash : Form
    {
        public Cash()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            bool valid = double.TryParse(textBox1.Text, out ReusableCode.amtTendered);
            
            if (!valid)
            {
                MessageBox.Show("Error: That was NOT a valid number! Please try again.");
            }
            else
            {
                if (ReusableCode.amtTendered < ReusableCode.CalcSub())
                {
                    MessageBox.Show("Error: Amount tendered does NOT exceed amount owed!");
                }
                else
                {
                    CashRec cashrec = new CashRec();
                    cashrec.Show();
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void Cash_Load(object sender, EventArgs e)
        {
            double tax = ReusableCode.CalcSub() * 0.06;
            double grandTotal = tax + ReusableCode.CalcSub();
            string msg = $"Subtotal: ${ReusableCode.CalcSub().ToString("F")}" + Environment.NewLine +
                $"Tax: ${(ReusableCode.CalcTax()).ToString("F")}" + Environment.NewLine +
                $"Grand Total: ${(ReusableCode.CalcGT()).ToString("F")}";

            textBox2.Text = msg;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
