using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using rashad.MOdel;
using System.IO;

namespace rashad.Forms
{
    public partial class InsertItem : Form
    {
        RashadEntities1 ctx = new RashadEntities1();
        public InsertItem()
        {
           
            InitializeComponent();
            getallcategory();
        }

         private void getallcategory()
        {
            ddlcatName.DataSource = null;
            List<category> cat = ctx.categories.ToList();
            if (cat.Count != 0)
            {
                ddlcatName.DisplayMember = "categorie_name";
                ddlcatName.ValueMember = "categorie_Id";
                ddlcatName.DataSource = cat.ToList();
               
            }

       
          
        }

        private void btniteminsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtitemName.Text))
                {
                    MessageBox.Show("يجب ادخال اسم الصنف قبل الحفظ");
                }
                else
                {
                    var firstOrDefault = ctx.Items.FirstOrDefault(x => x.Item_Name.ToLower().Trim() == txtitemName.Text.ToLower().Trim());

                    if (firstOrDefault != null)
                    {
                        MessageBox.Show("عفوا هذا الصنف موجود بالفعل");
                    }
                    else
                    {


                        Item c = new Item()
                        {
                            Item_Name = txtitemName.Text,
                            Quantity = txtquantity.Text == "" ? 0 : Convert.ToDouble(txtquantity.Text),
                            Purchusing_Price = txtpurchusing.Text == "" ? 0 : Convert.ToDouble(txtpurchusing.Text),
                            Sector_Price = txtsector.Text == "" ? 0 : Convert.ToDouble(txtsector.Text)
                            ,
                            Wholesales_Price = txtwholesale.Text == "" ? 0 : Convert.ToDouble(txtwholesale.Text),
                            categori_Id = (int?) ddlcatName.SelectedValue
                        };
                        ctx.Items.Add(c);
                        ctx.SaveChanges();
                        MessageBox.Show("نم حفظ اسم الصنف بنجاح");
                        txtitemName.Text = "";
                        txtpurchusing.Text = "";
                        txtquantity.Text = "";
                        txtsector.Text = "";
                        txtwholesale.Text = "";

                    }
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

        private void btnback_Click(object sender, EventArgs e)
        {
            ItemHome ih=new ItemHome();
            this.Hide();
            ih.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IteamSearch iss  = new IteamSearch();
           this.Hide();
            iss.ShowDialog();
        }

        private void InsertItem_Load(object sender, EventArgs e)
        {

        }
    }
}
