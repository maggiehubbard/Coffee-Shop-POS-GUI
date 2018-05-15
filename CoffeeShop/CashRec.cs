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
    public partial class CashRec : Form
    {
        public CashRec()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CashRec_Load(object sender, EventArgs e)
        {
            double tax = ReusableCode.CalcSub() * 0.06;
            double grandTotal = tax + ReusableCode.CalcSub();
            string msg = $"Subtotal: ${ReusableCode.CalcSub().ToString("F")}" + Environment.NewLine +
            $"Tax: ${(ReusableCode.CalcTax()).ToString("F")}" + Environment.NewLine +
            $"Grand Total: ${(ReusableCode.CalcGT()).ToString("F")}" + Environment.NewLine +
            $"Method of Payment: Cash" + Environment.NewLine +
            $"Amount Tendered: ${(ReusableCode.amtTendered).ToString("F")}" + Environment.NewLine +
            $"Change Owed: ${(ReusableCode.amtTendered - ReusableCode.CalcGT()).ToString("F")}";

            textBox1.Text = msg;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Environment.Exit(1);
        }
    }
}
