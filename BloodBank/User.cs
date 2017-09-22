using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace BloodBank
{
    class User
    {
       protected string  privateno;
       public  OleDbCommand cd ;
       public OleDbCommand cd1 ;


       public OleDbCommand cd2;
       public OleDbCommand cd3;
       public OleDbCommand cd4;
       public OleDbCommand cd5;
       public OleDbCommand cd6;
       public OleDbCommand cd7;
       public OleDbCommand cd8;
       public OleDbCommand cd9;
       public OleDbCommand cd10;




       public  System.Data.DataTable dt;
       public static OleDbConnection cn=new OleDbConnection();
       public  OleDbDataAdapter da;
       public static OleDbConnection cn1 ;
       public  OleDbDataAdapter da1;
       public  System.Data.DataTable dt1 ;
       protected DBHandler db;
       protected OleDbCommandBuilder build;
       protected OleDbCommandBuilder builder;
//private static int count=0;
        public User()
        {

            cd2 = new OleDbCommand();
            cd3 = new OleDbCommand();
            cd4 = new OleDbCommand();
            cd5 = new OleDbCommand();
            cd6 = new OleDbCommand();
            cd7 = new OleDbCommand();
            cd8 = new OleDbCommand();
            cd9 = new OleDbCommand();
            cd10 = new OleDbCommand(); ;
            cd = new OleDbCommand();
            cd1 = new OleDbCommand();
            dt = new System.Data.DataTable();
            cn = new OleDbConnection();
            dt1 = new System.Data.DataTable();
            db = new DBHandler();
            cn1 = new OleDbConnection();

        }
        

        public void view()
        {
            try
            {
                cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\taseneem 21\Documents\Database\DonorInfo.accdb;
Persist Security Info=False;";
                cn1.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\taseneem 21\Documents\Database\AcceptorInfo.accdb;
Persist Security Info=False;";
                cd.Connection = cn;
                cd1.Connection = cn1;
                db.OpenConnection(cn);
                db.OpenConnection(cn1);
                cd.CommandText = "select * from DonorInfo ";
                cd1.CommandText = "select * from AcceptorInfo ";
                da = new OleDbDataAdapter(cd);
                da1 = new OleDbDataAdapter(cd1);
                da.Fill(dt);
               // builder = new OleDbCommandBuilder(da);

                //da.Update(dt);
                da1.Fill(dt1);
                //build = new OleDbCommandBuilder(da1);
                //da1.Update(dt1);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            finally
            {
                cn.Close();
                cn1.Close();
                

            }

        }
        public int Log_in()
        {
            Form1 f1 = new Form1();
            privateno = Form1.text;
            int valid=0;
            if (privateno.Equals("1230"))
            {
                valid = 1;
               /* f1.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
                */
            }
            else if (privateno.Equals("13p6017"))
            {
                /*f1.Hide();
                Form3 f3 = new Form3();
                f3.ShowDialog();
                 
                */
                valid = 2;
            }


          /*  else
            {
                MessageBox.Show("Error ! You have Entered Wrong Password");
                count++;
                
                if (count >= 3)
                {
                    MessageBox.Show(" You have Entered Wrong Password for 3 times");
                    count = 0;
                    f1.Close();
                    
                }
                
            }*/
            return valid ;

        }

    }
}
