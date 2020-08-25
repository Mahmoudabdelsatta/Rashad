using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using rashad.MOdel;
using System.IO;

namespace rashad.Forms
{
    public partial class categorySearch : Form
    {
        RashadEntities1 ctx = new RashadEntities1();
        private string name = string.Empty;
        public categorySearch()
        {
            InitializeComponent();
            DisplayData();
        }
        private void DisplayData()
        {
            try
            {
                var q =
     from c in ctx.categories

     select new
     {
         اسم_الطبقة = c.categorie_name
     };
                dataGridView1.DataSource = q.Distinct().ToList();
           
            }
            catch (Exception ex)
            {
                    
                ErrorLogging(ex);
            }
            
        }  
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
 var q =
    from c in ctx.categories
    where c.categorie_name.Contains(txtcatsearch.Text)
    select new
    {
        اسم_الطبقة=c.categorie_name
    };
            if (q!=null)
            {
                 dataGridView1.DataSource = q.Distinct().ToList();
           
            }
            }
            catch (Exception ex)
            {
                    
                ErrorLogging(ex);
            }
           
           
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CategoryHome c=new CategoryHome();
            this.Hide();
            c.ShowDialog();
        }

        private void btncatinsert_Click(object sender, EventArgs e)
        {
            InsertCategory ic=new InsertCategory();
            this.Hide();
            ic.ShowDialog();
        }

        private void btncatupdate_Click(object sender, EventArgs e)
        {
            try
            {
 category update = ctx.categories.FirstOrDefault(x => x.categorie_name.ToLower().Trim() == name.ToLower().Trim());
            update.categorie_name = txtupdatename.Text;
            if (!String.IsNullOrEmpty(txtupdatename.Text))
            {
                ctx.categories.AddOrUpdate(update);
            ctx.SaveChanges();
                MessageBox.Show("تم تعديل الطبقة بنجاح");
            DisplayData();
            }
            }
            catch (Exception ex)
            {
                    
                ErrorLogging(ex);
            }
        
           
           
            
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {  name = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtupdatename.Text = name;

            }
            catch (Exception ex)
            {
                    
                ErrorLogging(ex);
            }
          

        }

        private void btncatdelete_Click(object sender, EventArgs e)
        {
            try
            {
category update = ctx.categories.FirstOrDefault(x => x.categorie_name.ToLower().Trim() == name.ToLower().Trim());
            if (update!=null)
            {
               
                ctx.categories.Remove(update);
            ctx.SaveChanges();
            MessageBox.Show("تم حذف الطبقة بنجاح");
                txtupdatename.Text = "";
            DisplayData(); 
            }
            }
            catch (Exception ex)
            {
                
               ErrorLogging(ex);
            }
            
            
              
            
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

        private void categorySearch_Load(object sender, EventArgs e)
        {

        }
    }
}
