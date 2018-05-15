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

namespace CoffeeShop
{
    public partial class AddDrink : Form
    {
        public AddDrink()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            double price = double.Parse(textBox2.Text);
            string description = textBox3.Text;
            string temperature = textBox4.Text;
            Drink newDrink = new Drink(name,price,"Drink",description,temperature,0);
            StreamWriter sw = null;
            try
            { 
                sw = new StreamWriter(@"Drink.txt", true);
                sw.WriteLine(name + "\t" + price + "\t" + "Drink\t" + description + "\t" + temperature + "\t" + 0);
                MessageBox.Show("Inventory Added");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("File access denied");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
