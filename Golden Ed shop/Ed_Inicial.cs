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
    public partial class Ed_Inicial : Form
    {
        public Ed_Inicial()
        {
            InitializeComponent();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Form1 frm = new Form1();
            this.Visible = false;
            frm.ShowDialog();
            this.Visible = true;
        }
    }
}
