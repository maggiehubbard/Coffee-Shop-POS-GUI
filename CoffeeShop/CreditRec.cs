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
    public partial class CreditRec : Form
    {
        public CreditRec()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CreditRec_Load(object sender, EventArgs e)
        {
            double tax = ReusableCode.CalcSub() * 0.06;
            double grandTotal = tax + ReusableCode.CalcSub();
            string msg = $"Subtotal: ${ReusableCode.CalcSub().ToString("F")}" + Environment.NewLine +
            $"Tax: ${(ReusableCode.CalcTax()).ToString("F")}" + Environment.NewLine +
            $"Grand Total: ${(ReusableCode.CalcGT()).ToString("F")}" + Environment.NewLine +
            $"Method of Payment: Credit Card";
            
            textBox1.Text = msg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Environment.Exit(1);
        }
    }
}
