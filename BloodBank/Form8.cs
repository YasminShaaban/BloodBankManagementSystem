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
    public partial class Form8 : Form
    {
        DBHandler dbhandeler = new DBHandler();
        private OleDbConnection cnn = new OleDbConnection();
        private OleDbConnection cn = new OleDbConnection();
        private OleDbConnection cnn1 = new OleDbConnection();
       
        private Admin ad;
        public Form8()
        {
           ad = new Admin();
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
          
            
           try
            {
               cnn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\taseneem 21\Documents\Database\DonorInfo.accdb;
Persist Security Info=False;";
                // ad.delete(cnn);
                ad.view();
                dataGridView1.DataSource = ad.dt;
                cnn.Open();
         /*       OleDbCommand db = new OleDbCommand();
                 db.Connection = cnn;
                 db.CommandText = "select * from DonorInfo ";
                  OleDbDataAdapter da = new OleDbDataAdapter(db);
                 DataTable dt = new DataTable();
                da.Fill(dt);
               dataGridView1.DataSource = dt;
             
               */


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

        private void button1_Click(object sender, EventArgs e)
        {
          //  dbhandeler.Save_DonorData();
            try
            {
                string query = "update DonorInfo set Name='" + textBox2.Text + "' ,Age=" + textBox3.Text + " ,BloodType='" + textBox4.Text + "' ,Email='" + textBox5.Text + "' ,Contact=" + textBox6.Text + " ,Address='" + textBox7.Text + "'where ID=" + textBox1.Text + "";
                string connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\taseneem 21\Documents\Database\DonorInfo.accdb;
Persist Security Info=False;";
                //dbhandeler.cm.CommandText = query;
                //dbhandeler.cm.ExecuteNonQuery();
                ad.update(connection,query);
                
                dataGridView1.DataSource = ad.dt;
                MessageBox.Show("Data  was edited");
                //cn.Close();
               // dbhandeler.closeConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         /*   finally
            {
                cn.Close();

                dbhandeler.closeConnection();
            }
           */ 

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "delete from DonorInfo where ID=" + textBox1.Text + "";
                string connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\taseneem 21\Documents\Database\DonorInfo.accdb;
Persist Security Info=False;";
                ad.delete(connection, query);
                ad.dt.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
                dataGridView1.DataSource = ad.dt;
                
                
                
                
                MessageBox.Show("Data  was deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message);
            }
            
            /*dbhandeler.Save_DonorData();
            try
            {
                //  "delete from DonorInfo where ID="+textBox1.Text+";
                string query = "delete from DonorInfo where ID="+textBox1.Text+"";
                 dbhandeler.cm.CommandText = query;
                dbhandeler.cm.ExecuteNonQuery();
                MessageBox.Show("Data  was deleted");
                cn.Close();
                dbhandeler.closeConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            finally
            {
                cn.Close();
                dbhandeler.closeConnection();
            }
            dataGridView1.Refresh();

            */
        }

       
        }

    }
