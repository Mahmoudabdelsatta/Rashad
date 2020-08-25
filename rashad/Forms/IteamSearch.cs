using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using rashad.MOdel;

namespace rashad.Forms
{
    public partial class IteamSearch : Form
    {
        RashadEntities1 ctx = new RashadEntities1();
        private string name = string.Empty;
        private void DisplayData()
        {
            try
            {
                var q =
                    from c in ctx.Items

     select new
     {
         اسم_الصنف = c.Item_Name,
         اسم_الطبقة = c.category.categorie_name,
         الكيمة =c.Quantity,
         سعر_الشراء = c.Purchusing_Price,
         سعر_الجملة = c.Wholesales_Price,
         سعر_القطاعى = c.Sector_Price,
         السعر_الاجمالى = c.Purchusing_Price * c.Quantity
     };
                dataGridView1.DataSource = q.Distinct().ToList();

            }
            catch (Exception ex)
            {

                ErrorLogging(ex);
            }

        }  
        public IteamSearch()
        {
          
          
            InitializeComponent();
          
            DisplayData();
            getallcategory();
        }
        private void getallcategory()
        {
            ddlcat.DataSource = null;
            List<category> cat = ctx.categories.ToList();
            if (cat.Count != 0)
            {
                ddlcat.DisplayMember = "categorie_name";
                ddlcat.ValueMember = "categorie_Id";
                ddlcat.DataSource = cat.ToList();
               
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
        private void btnitemsearch_Click(object sender, EventArgs e)
        {
            try
            {
                var q =
                   from c in ctx.Items
                   where c.Item_Name.Contains(txtitemsearch.Text)
                   select new
                   {
                       اسم_الصنف = c.Item_Name,
                       اسم_الطبقة=c.category.categorie_name,
                       الكيمة=c.Quantity,
                       سعر_الشراء=c.Purchusing_Price,
                       سعر_الجملة=c.Wholesales_Price,
                       سعر_القطاعى=c.Sector_Price,
                       السعر_الاجمالى=c.Purchusing_Price*c.Quantity

                   };
                if (q != null)
                {
                    dataGridView1.DataSource = q.Distinct().ToList();

                }
            }
            catch (Exception ex)
            {

                ErrorLogging(ex);
            }
           
           
            
        }

        private void btniteminsert_Click(object sender, EventArgs e)
        {
            InsertItem ii=new InsertItem();
            this.Hide();
            ii.ShowDialog();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                name = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtitemName.Text = name;
              ddlcat.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtquantity.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtpurchusing.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtsector.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtwholesale.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txttotalprice.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

            }
            catch (Exception ex)
            {

                ErrorLogging(ex);
            }
        }

        private void btnitemupdate_Click(object sender, EventArgs e)
        {
            try
            {
                Item update = ctx.Items.FirstOrDefault(x => x.Item_Name.ToLower().Trim() == name.ToLower().Trim());
                update.Item_Name = txtitemName.Text;
                update.Quantity =Convert.ToDouble(txtquantity.Text);
                update.categori_Id =Convert.ToInt32( ddlcat.SelectedValue);
                update.Purchusing_Price =Convert.ToDouble( txtpurchusing.Text);
                update.Sector_Price = Convert.ToDouble(txtsector.Text);
                update.Wholesales_Price =Convert.ToDouble( txtwholesale.Text);
                update.Total_Price = Convert.ToDouble(txttotalprice.Text);

                if (!String.IsNullOrEmpty(txtitemName.Text))
                {
                    ctx.Items.AddOrUpdate(update);
                    ctx.SaveChanges();
                    MessageBox.Show("تم تعديل الطبقة بنجاح");
                    DisplayData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("من فضلك ادخل قيم صحيحة");
                ErrorLogging(ex);
            }
        
        }

        private void btnitemdelete_Click(object sender, EventArgs e)
        {
            try
            {
                Item update = ctx.Items.FirstOrDefault(x => x.Item_Name.ToLower().Trim() == name.ToLower().Trim());
                if (update != null)
                {

                    ctx.Items.Remove(update);
                    ctx.SaveChanges();
                    MessageBox.Show("تم حذف الطبقة بنجاح");
                    DisplayData();
                }
            }
            catch (Exception ex)
            {

                ErrorLogging(ex);
            }
            
        }

        private void IteamSearch_Load(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ItemHome ih=new ItemHome();
            this.Hide();
            ih.ShowDialog();
        }
    }
}
