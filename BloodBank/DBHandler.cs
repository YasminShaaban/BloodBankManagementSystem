
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
namespace BloodBank
{
    class DBHandler
    {



        public OleDbConnection cn;
       // public OleDbConnection cn1;
       // private OleDbDataAdapter da;
        public OleDbCommand cm;
       // private OleDbDataReader rdr;
        public Form7 f7 = new Form7();
        public DBHandler()
        {
            cn = new OleDbConnection();
            cm = new OleDbCommand();
            cm.Connection = cn;

        }
        public void OpenConnection(OleDbConnection cn1)
        {
            cn1.Open();
        }
        public void closeConnection()
        {
            this.cn.Close();
        }
        public void Save_Data(string cn2)
        {

            //cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\taseneem 21\Documents\Database\DonorInfo.accdb;
//Persist Security Info=False;";
            cn.ConnectionString = cn2;

            this.OpenConnection(this.cn);
            cm.Connection = cn;
           // this.closeConnection();
            //Form4.cin = 1;
        }
       /* public void save_AcceptorData()
        {


       //     cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\taseneem 21\Documents\Database\AcceptorInfo.accdb;
//Persist Security Info=False;";
            //cn.Open();
            this.OpenConnection(this.cn);
            //Form4.cin = 2;
            cm.Connection = cn;


        }*/
        public void Save_Acceptor_MedicalHistory()
        {

            cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\taseneem 21\Documents\Database\AcceptorInfo.accdb;
Persist Security Info=False;";
           
            
        cm.Connection = cn;
            this.OpenConnection(this.cn);

        }
        public void Save_Donor_MedicalHistory()
        {

            cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\taseneem 21\Documents\Database\DonorInfo.accdb;
Persist Security Info=False;";
            
            cm.Connection = cn;

            this.OpenConnection(this.cn);


        }
    }

}






