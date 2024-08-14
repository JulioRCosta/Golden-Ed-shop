using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Golden_Ed_shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show(textBox1.Text + "\n");
            MessageBox.Show(textBox2.Text + "\n");
            MessageBox.Show(textBox3.Text + "\n");
            MessageBox.Show(textBox4.Text + "\n");
            MessageBox.Show(textBox5.Text + "\n");
            MessageBox.Show(textBox6.Text + "\n");
        }
    }
}
