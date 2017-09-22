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

    
    public partial class Form2 : Form
    {
        public static string text;
        public static string text1;
        public static string combotxt;
        public static int cout = 0;
       
        
      private  User tns = new User();
      private Staff us = new Staff();
        public Form2()
        {
            InitializeComponent();
            
        
          
          }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            combotxt = comboBox1.Text;
            Form6 f6 = new Form6();
            f6.ShowDialog();
            
          /*  try
            {
                cn.Open();
                OleDbCommand db2 = new OleDbCommand();
                db2.Connection = cn;
                db2.CommandText = "select * from DonorInfo where BloodType='" + comboBox1.Text + "'";
                OleDbDataAdapter da2 = new OleDbDataAdapter(db2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                f6.data.DataSource = dt2;
                // MessageBox.Show( " Your data is successfully saved ");
                f6.ShowDialog();

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error! The data can't be saved");
                MessageBox.Show(ex.Message);


            }
            finally
            {
                cn.Close();
                //  this.Close();
            }
            */

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.txtarea.Clear();
            text1 = comboBox2.Text;
           string str=us.matching_BloodGroupType(text1);
           // txtarea.Clear();
           this.txtarea.Text = str;
            
        }
        public  void setrichbox(string txt)
        {
            this.txtarea.SelectedText = txt;

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
         //   try{
                
              /*  OleDbCommand db = new OleDbCommand();
            OleDbCommand db1 = new OleDbCommand();
            db.Connection = cn;
                db1.Connection=cn1;
            db.CommandText = "select * from DonorInfo ";
            db1.CommandText = "select * from AcceptorInfo ";   
            OleDbDataAdapter da = new OleDbDataAdapter(db);
            OleDbDataAdapter da1 = new OleDbDataAdapter(db1);

            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            da.Fill(dt);
            da1.Fill(dt1);*/
            
            //Transaction.cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\taseneem 21\Documents\Database\DonorInfo.accdb;
//Persist Security Info=False;";

            dataGridView1.DataSource = null;
            dataGridView1.Update();
            dataGridView1.Refresh();
            dataGridView2.DataSource = null;
            dataGridView2.Update();
            dataGridView2.Refresh();
            DataTable t = new DataTable();
            DataTable t1 = new DataTable();
            tns.view();
            tns.da1.Fill(t);
            tns.da.Fill(t1);
            dataGridView1.DataSource =t1;
            dataGridView2.DataSource = t;


            // MessageBox.Show( "Your data is successfly saved ");

            }
            //catch (Exception ex)
            //{
                //MessageBox.Show("Erro! The data can't be saved");
              //  MessageBox.Show(ex.Message);


            //}
            //finally
            //{
               // cn.Close();
                //db.closeConnection();
              //  this.Close();
            //}

       // }

        private void txtarea_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox3.Text.Equals("Donor")){
                cout=1;
            }
            else if (comboBox3.Text.Equals("Acceptor"))
            {
                cout = 2;
            }
            
            text = textBox1.Text;
            Form5 f5 = new Form5();
            f5.ShowDialog();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtarea.Clear();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
