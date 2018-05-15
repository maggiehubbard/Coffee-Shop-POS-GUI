using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace CoffeeShop
{
    public partial class DrinkList : Form
    {
        public DrinkList()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DrinkList_Load(object sender, EventArgs e)
        {
            BindDrinkList();
        }
        private void BindDrinkList()
        {
            List<Drink> drink = Program.ReadDrinkFile("Drink.txt");
            comboBox1.DataSource = drink;
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((numericUpDown1.Value) <= 0)
            {
                MessageBox.Show("No quantity selected");
            }
            else
            {

                ReusableCode.ShoppingCart.Add(((Drink)(comboBox1.SelectedItem)).Name);
                ReusableCode.PriceCart.Add((((Drink)(comboBox1.SelectedItem)).Price) * (int)(numericUpDown1.Value));
                ReusableCode.QuantityList.Add((int)(numericUpDown1.Value));
                MessageBox.Show("Item Added!");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
