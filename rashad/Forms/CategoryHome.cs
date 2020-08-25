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
    public partial class CategoryHome : Form
    {
        public CategoryHome()
        {
            InitializeComponent();
        }

        private void txtInsertcategory_Click(object sender, EventArgs e)
        {
            InsertCategory ic=new InsertCategory();
            this.Hide();
            ic.ShowDialog();
        }

        private void txtcategorySearch_Click(object sender, EventArgs e)
        {
            categorySearch cs=new categorySearch();
            this.Hide();
            cs.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home c=new Home();
            this.Hide();
            c.ShowDialog();
        }
    }
}
