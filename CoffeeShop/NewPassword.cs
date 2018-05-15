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
    public partial class NewPassword : Form
    {
        public NewPassword()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 mm = new Form1();
            mm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = ReusableCode.pword;
            MessageBox.Show("Password has been changed!");
            Form1 mm = new Form1();
            mm.Show();
        }

        private void NewPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
