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
    public partial class ItemHome : Form
    {
        public ItemHome()
        {
            InitializeComponent();
        }

        private void txtInsertitem_Click(object sender, EventArgs e)
        {
            InsertItem ii=new InsertItem();
            this.Hide();
            ii.ShowDialog();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Home h=new Home();
            this.Hide();
            h.ShowDialog();
        }

        private void txtcategorySearch_Click(object sender, EventArgs e)
        {
            IteamSearch iss=new IteamSearch();
            this.Hide();
            iss.ShowDialog();
        }
    }
}
