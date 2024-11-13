using Golden_Ed_shop.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private void panel1_Click(object sender, EventArgs e)
        {

            MessageBox.Show(textBox1.Text + "\n" + textBox2.Text + "\n" + textBox3.Text + "\n" + textBox4.Text + "\n" + textBox5.Text + "\n" + textBox6.Text);
            Menuprince6 frm = new Menuprince6();
            this.Visible = false;
            frm.ShowDialog();
            this.Visible = true;


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loginhaha frm = new Loginhaha();
            this.Visible = false;
            frm.ShowDialog();
            this.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
