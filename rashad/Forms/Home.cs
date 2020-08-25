using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rashad.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void txtcategorie_Click(object sender, EventArgs e)
        {
            CategoryHome ch=new CategoryHome();
            this.Hide();
            ch.ShowDialog();
        }

        private void txtitems_Click(object sender, EventArgs e)
        {
            ItemHome ih=new ItemHome();
            this.Hide();
            ih.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login l=new login();
            this.Hide();
            l.ShowDialog();
        }
    }
}
