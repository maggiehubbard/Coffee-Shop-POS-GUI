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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            SOD sl = new SOD(); //opens a new snack or drink form
            sl.ShowDialog(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//lists items in shopping cart
        {
            if (ReusableCode.ShoppingCart.Count <= 0)
            {
                MessageBox.Show("**Nothing to Display!**");
            }

            else
            {
                string message = " \n";
                for (int i = 0; i < ReusableCode.ShoppingCart.Count; i++)
                {
                    message += $"{i + 1} - {ReusableCode.ShoppingCart[i].ToString()} x {ReusableCode.QuantityList[i].ToString()} \n";

                }
                MessageBox.Show($"LIST ITEMS:\n {message}");
            }
    }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ReusableCode.ShoppingCart.Count <= 0)
            {
                MessageBox.Show("**No Items To Display**");
            }
            else
            {
                this.Hide();
                RemoveItem remove = new RemoveItem();
                remove.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ReusableCode.ShoppingCart.Count <= 0)
            {
                MessageBox.Show("Please add items to cart to checkout!");
            }
            else
            {
                this.Hide();
                MOP mop1 = new MOP();
                mop1.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Password pw = new Password();
            pw.Show();
        }
    }

    
}
    

