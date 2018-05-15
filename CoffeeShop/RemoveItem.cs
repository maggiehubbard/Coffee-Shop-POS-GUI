﻿using System;
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
    public partial class RemoveItem : Form
    {
        public RemoveItem()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 main = new Form1(); //opens a new main window
            main.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {            
            
        }
        private void BindRemoveItems()
        {
            
                comboBox1.DataSource = ReusableCode.ShoppingCart;
                comboBox1.SelectedIndex = 0;
        }


        private void RemoveItem_Load(object sender, EventArgs e)
        {
            
                BindRemoveItems();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ReusableCode.ShoppingCart.RemoveAt(comboBox1.SelectedIndex);
            MessageBox.Show("Item Deleted Successfully!");
            Form1 main = new Form1();
            main.Show();
        }
    }
}
