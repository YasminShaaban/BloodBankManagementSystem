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
    
    public partial class Form4 : Form
    {
        public static int cin=0;
        
        public static int ct = 0;
        public static string text;
        
        Staff st = new Staff();
        public Form4()
        {
            InitializeComponent();
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBHandler dbhandler = new DBHandler();
            DBHandler db = new DBHandler();
            string connection;
            
            try
            {
                
                
                if (comboBox2.Text.Equals("Donor"))
                
                {
                    

                    if (Convert.ToInt32(textBox2.Text) >= 18 && Convert.ToInt32(textBox2.Text) <= 40)
                    {

                         connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\taseneem 21\Documents\Database\DonorInfo.accdb;
Persist Security Info=False;";
                       //  dbhandler.Save_DonorData();
                         
                         string query = "insert into DonorInfo (Name,Age,BloodType,[Email],[Contact],[Address])values('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                         st.Register(query,connection);
                       /*  db.cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\taseneem 21\Documents\Database\DonorInfo.accdb;
Persist Security Info=False;";
                         db.OpenConnection(db.cn);
                         db.cm.Connection = db.cn;
                         db.cm.CommandText ="SELECT @@IDENTITY";
                         //dbhandler.cm.ExecuteNonQuery();
                        // dbhandler.cm.CommandText = "select ID from DonorInfo where Name=" + textBox1.Text + "";
                         
                        Regid = db.cm.ExecuteScalar().ToString();
                         db.closeConnection();*/

                         cin = 1;
                        MessageBox.Show("Your data is successfly saved ");
                        ct = 1;
                    }
                        else
                        {
                            throw new AgeException("The Donor's age must be between 18 and 40");

                        }
                    
                    }
                    else if (comboBox2.Text.Equals("Acceptor"))
                    {
                        cin = 2;
                        connection=@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\taseneem 21\Documents\Database\AcceptorInfo.accdb;
Persist Security Info=False;";
                        string query = "insert into AcceptorInfo (Name,Age,BloodType,[Email],[Contact],[Address])values('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text  + "')";
                        st.Register(query, connection);
                        db.cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\taseneem 21\Documents\Database\AcceptorInfo.accdb;
Persist Security Info=False;";
                        
                        ct = 1;

                      /*  db.cm.Connection = db.cn;
                         db.OpenConnection(db.cn);
                         
                         db.cm.CommandText = "SELECT @@IDENTITY";
                         //db.cm.CommandText = "Select ID from AcceptorInfo where Name=" + textBox1.Text + "";


                         //dbhandler.cm.ExecuteNonQuery();
                       Regid = db.cm.ExecuteScalar().ToString();
                        // dbhandler.closeConnection();*/

                       MessageBox.Show("Your data is successfly saved ");
                    }

                text = textBox1.Text;
                    


            } 
            
            
            catch (AgeException ex)
            {
                ct = 0;
                MessageBox.Show("The Donor can't donate");
                this.Close();

            }
            catch (Exception ex)
            {

                ct = 0;
                MessageBox.Show("Erro! The data can't be saved");
                MessageBox.Show(ex.Message);


            }
            
            
            finally
            {
               
                db.closeConnection();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Form4.ct == 1)
                {
                    Form7 f7 = new Form7();
                    f7.ShowDialog();

                }
                else throw new Exception();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The data has not been saved ,You can't record Donor's/Acceptor's Medical History ");

            }
            finally
            {
                this.Close();

            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
