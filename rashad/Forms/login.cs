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
    public partial class login : Form
    {
        RashadEntities1 ctx=new RashadEntities1();
        public login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
 bool exist = ctx.Users.Any(x => x.username == txtusername.Text.Trim().ToLower() && x.password == txtpassword.Text.Trim().ToLower());
            if (exist)
            {

                Home h=new Home();
                this.Hide();
                h.Show();
                
            }
            else
            {
                MessageBox.Show("عفوا اسم المستخدم او الرقم السرى غير صحيح");
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

    }
}
