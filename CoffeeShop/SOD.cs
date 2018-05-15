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
    public partial class SOD : Form
    {
        public SOD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SnacksList snack1 = new SnacksList(); //opens a new snacklist window
            snack1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DrinkList drink1 = new DrinkList(); //opens a new drink list window
            drink1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
