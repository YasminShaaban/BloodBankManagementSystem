using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace BloodBank
{
    public partial class Form7 : Form
    {

        OleDbConnection cn = new OleDbConnection();


        public Form7()
        {
            InitializeComponent();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBHandler dbhandler = new DBHandler();
            DBHandler db = new DBHandler();
            string Regid;
            Form4 f4 = new Form4();
            try{
                
               
                
                if(Form4.cin==2){
                    db.cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\taseneem 21\Documents\Database\AcceptorInfo.accdb;
Persist Security Info=False;";
                    db.OpenConnection(db.cn);
                    db.cm.Connection = db.cn;
                    db.cm.CommandText = "select ID from AcceptorInfo where Name='" + Form4.text + "'";
                   // db.cm.CommandText = "SELECT @@IDENTITY";
                    Regid = db.cm.ExecuteScalar().ToString();

                 dbhandler.Save_Acceptor_MedicalHistory();
                   dbhandler.cm.CommandText = "insert into MedicalHistory(Hemoglobine,RedCellsCount,PCV,MCV,MCH,MCHC,RDW,PlateletsCount,RegID) values('" + hemog.Text + "','" + rcc.Text + "','" + pcv.Text + "','" + mcv.Text + "','" + mch.Text + "','" + mchc.Text + "','" + rdw.Text + "','" + pcount.Text + "','"+Regid+"')";
                    dbhandler.cm.ExecuteNonQuery();
                
                    MessageBox.Show("Your data is successfully saved in Acceptor's Medical History");
               
                
                }
                else if (Form4.cin==1)
                {

                    db.cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\taseneem 21\Documents\Database\DonorInfo.accdb;
Persist Security Info=False;";
                    db.OpenConnection(db.cn);
                    db.cm.Connection = db.cn;
                    db.cm.CommandText = "select ID from DonorInfo where Name='" + Form4.text + "'";
                    // db.cm.CommandText = "SELECT @@IDENTITY";
                    Regid = db.cm.ExecuteScalar().ToString();
                    
                    dbhandler.Save_Donor_MedicalHistory();
                    dbhandler.cm.CommandText = "insert into MedicalHistory(Hemoglobine,RedCellsCount,PCV,MCV,MCH,MCHC,RDW,PlateletsCount,RegID) values('" + hemog.Text + "','" + rcc.Text + "','" + pcv.Text + "','" + mcv.Text + "','" + mch.Text + "','" + mchc.Text + "','" + rdw.Text + "','" + pcount.Text +"','"+Regid+ "')";
                  dbhandler.cm.ExecuteNonQuery();
                    MessageBox.Show("Your data is successfully saved Donor's Medical History");
                    
                }
            
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
              
                
            }
            finally
            {
                cn.Close();
                this.Close();
                f4.Close();
                
            }
        }
        

        

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void pcv_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
