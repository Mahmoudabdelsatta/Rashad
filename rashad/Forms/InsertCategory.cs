using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using rashad.MOdel;
using System.IO;

namespace rashad.Forms
{
    public partial class InsertCategory : Form
    {
        RashadEntities1 ctx = new RashadEntities1();
        public InsertCategory()
        {
            InitializeComponent();
        }
        public static void ErrorLogging(Exception ex)
        {
            string strPath = @"D:\self\self projects\rashad\Log.txt";
            if (!File.Exists(strPath))
            {
                File.Create(strPath).Dispose();
            }
            using (StreamWriter sw = File.AppendText(strPath))
            {
                sw.WriteLine("=============Error Logging ===========");
                sw.WriteLine("===========Start============= " + DateTime.Now);
                sw.WriteLine("Error Message: " + ex.Message);
                sw.WriteLine("Stack Trace: " + ex.StackTrace);
                sw.WriteLine("===========End============= " + DateTime.Now);

            }
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            try
            {
 if (String.IsNullOrEmpty(txtcatname.Text))
            {
                MessageBox.Show("يجب ادخال اسم الطبقة قبل الحفظ");
            }
            else
 {
     var firstOrDefault = ctx.categories.FirstOrDefault(x => x.categorie_name.ToLower().Trim() == txtcatname.Text.ToLower().Trim());
    
                    if ( firstOrDefault != null)
                    {
                        MessageBox.Show("عفوا هذه الطبقة موجود بالفعل");
                    }
                    else
                    {
                        category c = new category() {categorie_name = txtcatname.Text};
                        ctx.categories.Add(c);
                        ctx.SaveChanges();
                        MessageBox.Show("نم حفظ اسم الطبقة");
                        txtcatname.Text = "";
                   
                }
 }
            }
            catch (Exception ex)
            {
                    
              ErrorLogging(ex)  ;
            }
           
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            CategoryHome c=new CategoryHome();
            this.Hide();
            c.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           categorySearch cs=new categorySearch();
            this.Hide();
            cs.ShowDialog();
        }
    }
}
