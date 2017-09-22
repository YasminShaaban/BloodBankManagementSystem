using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank
{
    public partial class Form9 : Form
    {
        DBHandler dbhandeler = new DBHandler();
        private OleDbConnection cnn = new OleDbConnection();
        private OleDbConnection cn = new OleDbConnection();
        private OleDbConnection cnn1 = new OleDbConnection();
       private  Admin ad;
        public Form9()
        {
            InitializeComponent();
             ad= new Admin();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                
                /*string query = "update AcceptorInfo set Name='" + textBox2.Text + "' ,Age='" + textBox3.Text + "' ,BloodType='" + textBox4.Text + "' ,Email='" + textBox5.Text + "' ,Contact='" + textBox6.Text + "' ,Address='" + textBox7.Text + "'where ID=" + textBox1.Text + "";
                
                dbhandeler.cm.CommandText = query;
                dbhandeler.cm.ExecuteNonQuery();
                MessageBox.Show("Data  was edited");
                cn.Close();

                dbhandeler.closeConnection();
                */
                string query = "update AcceptorInfo set Name='" + textBox2.Text + "' ,Age=" + textBox3.Text + " ,BloodType='" + textBox4.Text + "' ,Email='" + textBox5.Text + "' ,Contact=" + textBox6.Text + " ,Address='" + textBox7.Text + "'where ID=" + textBox1.Text + "";
                string connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\taseneem 21\Documents\Database\AcceptorInfo.accdb;
Persist Security Info=False;";
                //dbhandeler.cm.CommandText = query;
                //dbhandeler.cm.ExecuteNonQuery();
               
                ad.update(connection, query);

                dataGridView1.DataSource = ad.dt;
                MessageBox.Show("Data  was edited");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            /*finally
            {
                cn.Close();

                dbhandeler.closeConnection();
            }*/
        }

        private void Form9_Load(object sender, EventArgs e)
        {

         ;

           // ad.update(cnn1); 
           // cnn1.Open();
            try
            {
              /*  OleDbCommand db1 = new OleDbCommand();
                db1.Connection = cnn1;
                db1.CommandText = "select * from AcceptorInfo ";
                OleDbDataAdapter da1 = new OleDbDataAdapter(db1);

                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
                */
                cnn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\taseneem 21\Documents\Database\AcceptorInfo.accdb;
Persist Security Info=False;";
                // ad.delete(cnn);
                ad.view();
                dataGridView1.DataSource = ad.dt1;
               // dataGridView1.Update();
                //dataGridView1.Refresh();
                
                //cnn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
            /*finally
            {
                cnn.Close();
                cnn1.Close();
            }*/

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedcell in dataGridView1.SelectedCells)
            {
                cell = selectedcell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
                textBox4.Text = row.Cells[3].Value.ToString();
                textBox5.Text = row.Cells[4].Value.ToString();
                textBox6.Text = row.Cells[5].Value.ToString();
                textBox7.Text = row.Cells[6].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            try
            {



                try
                {
                    string query = "delete from AcceptorInfo where ID=" + textBox1.Text + "";
                    string connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\taseneem 21\Documents\Database\AcceptorInfo.accdb;
Persist Security Info=False;";
                    ad.delete(connection, query);
                   ad.dt1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
                    dataGridView1.DataSource = ad.dt1;
                    
                   
                    MessageBox.Show("Data  was deleted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                /* string query = "delete from AcceptorInfo where ID=" + textBox1.Text + "";
                dbhandeler.cm.CommandText = query;
                dbhandeler.cm.ExecuteNonQuery();
                MessageBox.Show("Data  was edited");
                cn.Close();

                dbhandeler.closeConnection();
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          /*  finally
            {
                cn.Close();

                dbhandeler.closeConnection();
            }*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public object SomeDataSource { get; set; }
    }
}
