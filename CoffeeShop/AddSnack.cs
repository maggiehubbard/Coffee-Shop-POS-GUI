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
    public partial class AddSnack : Form
    {
        public AddSnack()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            double price = double.Parse(textBox2.Text);
            string description = textBox3.Text;
            string taste = textBox4.Text;
            Snack newDrink = new Snack(name, price, "Snack", description, taste);
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(@"Snack.txt", true);
                sw.WriteLine(name + "\t" + price + "\t" + "Snack\t" + description + "\t" + taste);
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
    }
}
