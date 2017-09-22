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
    
    
    public partial class Form1 : Form
    {
        
        User trans = new User();
        private static int count=0;
        public Form1()
        {
            InitializeComponent();

        }
        public static string text;

        
            
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            text = textBox1.Text;
            textBox1.Clear();
            if (trans.Log_in() == 1)
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();


            }
            else if (trans.Log_in() == 2)
            {

                this.Hide();
                Form3 f3 = new Form3();
                f3.ShowDialog();
            }

            else
            {
                MessageBox.Show("Error ! You have Entered Wrong Password");
                count++;

                if (count >= 3)
                {
                    MessageBox.Show(" You have Entered Wrong Password for 3 times");
                    count = 0;
                    this.Close();

                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
