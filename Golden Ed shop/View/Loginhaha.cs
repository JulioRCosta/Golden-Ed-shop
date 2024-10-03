using Golden_Ed_shop.Resources;
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
    public partial class Loginhaha : Form
    {
        public Loginhaha()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Menuprince6 frm = new Menuprince6();
            this.Visible = false;
            frm.ShowDialog();
            this.Visible = true;
        }

        private void Loginhaha_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
