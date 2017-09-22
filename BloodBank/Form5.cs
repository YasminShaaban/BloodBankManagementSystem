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
    public partial class Form5 : Form
    {
        
        
        private Staff us=new Staff();

        public Form5()
        {
            InitializeComponent();
   
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
           

            try
            {


                if (Form2.cout == 1)
                {
                    label1.Text = "Information of Donor";
                   
                    us.search_By_ID_DonorInfo();

                    hemog.Text = us.cd.ExecuteScalar().ToString();
                    rcc.Text = us.cd2.ExecuteScalar().ToString();
                    pcv.Text = us.cd3.ExecuteScalar().ToString();
                    mcv.Text = us.cd4.ExecuteScalar().ToString();
                    mch.Text = us.cd5.ExecuteScalar().ToString();
                    mchc.Text = us.cd6.ExecuteScalar().ToString();
                    rdw.Text = us.cd7.ExecuteScalar().ToString();
                    pcount.Text = us.cd8.ExecuteScalar().ToString();
                    dataGridView1.DataSource =us.dt;

                }
                else if (Form2.cout == 2)
                {
                    label1.Text = "Information of Acceptor";
                   
                    us.search_By_ID_AcceptorInfo();
                    hemog.Text = us.cd.ExecuteScalar().ToString();
                    rcc.Text = us.cd2.ExecuteScalar().ToString();
                    pcv.Text = us.cd3.ExecuteScalar().ToString();
                    mcv.Text = us.cd4.ExecuteScalar().ToString();
                    mch.Text = us.cd5.ExecuteScalar().ToString();
                    mchc.Text = us.cd6.ExecuteScalar().ToString();
                    rdw.Text = us.cd7.ExecuteScalar().ToString();
                    pcount.Text = us.cd8.ExecuteScalar().ToString();
                    dataGridView1.DataSource = us.dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
            finally
            {
                Staff.cn.Close();
                Staff.cn1.Close();

            }

            


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


