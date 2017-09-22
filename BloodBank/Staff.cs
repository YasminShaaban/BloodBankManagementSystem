using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
namespace BloodBank
{
    class Staff:User
    {

        
        public Staff():base()
        {
         
            
        }
        public void search_By_ID_DonorInfo(){
          cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\taseneem 21\Documents\Database\DonorInfo.accdb;
Persist Security Info=False;";
                cn1.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\taseneem 21\Documents\Database\DonorInfo.accdb;
Persist Security Info=False;";
                cd.Connection = cn;
                cd1.Connection = cn1;
                db.OpenConnection(cn);
                db.OpenConnection(cn1);

                cd2.Connection = cn;
                cd3.Connection = cn;
                cd4.Connection = cn;
                cd5.Connection = cn;
                cd6.Connection = cn;
                cd7.Connection = cn;
                cd8.Connection = cn;
               
                cd.CommandText = "select Hemoglobine from MedicalHistory where RegID =" + Form2.text + "";
                cd2.CommandText = "select RedCellsCount from MedicalHistory where RegID =" + Form2.text + "";
                cd3.CommandText = "select PCV from MedicalHistory where RegID =" + Form2.text + "";
                cd4.CommandText = "select MCV from MedicalHistory where RegID =" + Form2.text + "";
                cd5.CommandText = "select MCH from MedicalHistory where RegID =" + Form2.text + "";
                cd6.CommandText = "select MCHC from MedicalHistory where RegID =" + Form2.text + "";
                cd7.CommandText = "select RDW from MedicalHistory where RegID =" + Form2.text + "";
                cd8.CommandText = "select PlateletsCount from MedicalHistory where RegID =" + Form2.text + "";





               // cd.CommandText = "select MedicalDescription from MedicalHistory where ID =" + Form2.text + "";
                cd1.CommandText = "Select * from DonorInfo where ID= " + Form2.text + "";
               cd1.CommandType = CommandType.Text;
                da = new OleDbDataAdapter(cd1);
                da.Fill(dt);
                    
        }
        public void search_By_ID_AcceptorInfo()
        {
             cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\taseneem 21\Documents\Database\AcceptorInfo.accdb;
Persist Security Info=False;";
            cn1.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\taseneem 21\Documents\Database\AcceptorInfo.accdb;
Persist Security Info=False;";
            cd.Connection = cn;
          cd1.Connection = cn1;

          cd2.Connection = cn;
          cd3.Connection = cn;
          cd4.Connection = cn;
          cd5.Connection = cn;
          cd6.Connection = cn;
          cd7.Connection = cn;
          cd8.Connection = cn;
          cd9.Connection = cn;
          db.OpenConnection(cn);
          db.OpenConnection(cn1);
          //cd9.CommandText = "select RegID  from  where ID =" + Form2.text + "";
         // string medid = cd9.ExecuteScalar().ToString();
          cd.CommandText = "select Hemoglobine from MedicalHistory where RegID =" + Form2.text + "";
          cd2.CommandText = "select RedCellsCount from MedicalHistory where RegID =" + Form2.text + "";
          cd3.CommandText = "select PCV from MedicalHistory where RegID =" + Form2.text + "";
          cd4.CommandText = "select MCV from MedicalHistory where RegID =" + Form2.text + "";
          cd5.CommandText = "select MCH from MedicalHistory where RegID =" + Form2.text + "";
          cd6.CommandText = "select MCHC from MedicalHistory where RegID =" + Form2.text + "";
          cd7.CommandText = "select RDW from MedicalHistory where RegID =" + Form2.text + "";
          cd8.CommandText = "select PlateletsCount from MedicalHistory where RegID =" + Form2.text + "";






            
         //   cd.CommandText = "select MedicalDescription from AcceptrMedicalHistory where ID =" + Form2.text + "";
            cd1.CommandText = "Select * from AcceptorInfo where ID= " + Form2.text + "";
            cd1.CommandType = CommandType.Text;
            da1 = new OleDbDataAdapter(cd1);
            da1.Fill(dt);
}
        public void search_By_BloodGroupType()
        {
            try
            {
                cn1.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\taseneem 21\Documents\Database\DonorInfo.accdb;
Persist Security Info=False;";
                cd1.Connection = cn1;
                db.OpenConnection(cn1);
                cd1.CommandText = "select * from DonorInfo where BloodType='" + Form2.combotxt + "'";
                da = new OleDbDataAdapter(cd1);
                da.Fill(dt1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                cn1.Close();


            }


        }
        public string matching_BloodGroupType(string str){
             string text="";
            Form2 f2 = new Form2();
            if (str.Equals("A+"))
            {
                //txtarea.Clear();
                //txtarea.Text = "";

                text = "A+ \n" + "A-\n" + " O+ \n" + "O-";
                //f2.setrichbox(text);

            }
            else if (str.Equals("A-"))
            {

               // txtarea.Clear();
                //txtarea.SelectedText = "";
                text = "A- \n" + "O-\n";
                //f2.setrichbox(text);
               
            }
            else if (str.Equals("B+"))
            {
                text = "B+ \n" + "B-\n" + "O+ \n" + "O- ";
               // f2.setrichbox(text);
                
            }
            else if (str.Equals("B-"))
            {
                text = "O- \n" + "B-\n";
                //f2.setrichbox(text);
                //txtarea.Text = "";
               
            }
            else if (str.Equals("AB+"))
            {
                text ="A+ \n" + "A-\n" + "B+ \n" + "B-\n" + "O+ \n" + "O- ";
                //f2.setrichbox(text);
                //txtarea.Text = "";
                
            }
            else if (str.Equals("AB-"))
            {
                text = "A- \n" + "B-\n" + "O- \n" + "AB- ";
                
                
            }

            else if (str.Equals("O-"))
            {
                text = "O- \n";
                
                
            }
            else if (str.Equals("O+"))
            {
                text = "O- \n" + "O+ ";
               
               
            }
            return text;


    }
        public void Register(string query,string connection )
        {
            db.Save_Data(connection);
            db.cm.CommandText = query;
            db.cm.ExecuteNonQuery();
            db.cn.Close();

        }

    }
}
