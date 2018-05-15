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
    public partial class SOD2 : Form
    {
        public SOD2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin amenu = new Admin();
            amenu.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddSnack aS = new AddSnack();
            aS.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddDrink ad = new AddDrink();
            ad.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mm = new Form1();
            mm.Show();
        }
    }
}
