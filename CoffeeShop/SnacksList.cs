using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace CoffeeShop
{
    public partial class SnacksList : Form
    {
        public SnacksList()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)//originally there was nothing in the curly braces
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void BindSnackList()
        {
            List<Snack> snack = Program.ReadSnackFile("Snack.txt");
            comboBox1.DataSource = snack;
            comboBox1.SelectedIndex = 0;
        }

        private void SnacksList_Load(object sender, EventArgs e)
        {
            BindSnackList();
        }

        private void addToShopCart(List<Snack> snack, int index)
        {

        }



        private void button1_Click(object sender, EventArgs e) //when u click add snack item
        {
            if ((numericUpDown1.Value) <= 0)
            {
                MessageBox.Show("No quantity selected");
            }
            else
            {
                ReusableCode.ShoppingCart.Add(((Snack)(comboBox1.SelectedItem)).Name);
                ReusableCode.PriceCart.Add((((Snack)(comboBox1.SelectedItem)).Price) * (int)(numericUpDown1.Value));
                ReusableCode.QuantityList.Add((int)(numericUpDown1.Value));
                MessageBox.Show("Item Added!");
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        public void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}


