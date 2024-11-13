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

       

        private void panel1_Click(object sender, EventArgs e)
        {

            MessageBox.Show(Nome.Text + "\n" + Idade.Text + "\n" + CEP.Text + "\n" + Email.Text + "\n" + NC.Text + "\n" + CVC.Text);
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

       
    }
}
