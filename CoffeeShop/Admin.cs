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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewPassword newPassword = new NewPassword();
            newPassword.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 mm = new Form1();
            mm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SOD2 sod = new SOD2();
            sod.Show();
        }
    }
}
