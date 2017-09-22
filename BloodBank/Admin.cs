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
    class Admin:User
    {
        
        public Admin()
            : base()
        {
           

}
        public void update(string  cnn,string query)
        {
  /*          cnn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\taseneem 21\Documents\Database\AcceptorInfo.accdb;
Persist Security Info=False;";*/
            db.Save_Data(cnn);
            db.cm.CommandText = query;
            db.cm.ExecuteNonQuery();
            builder = new OleDbCommandBuilder(da);
            build = new OleDbCommandBuilder(da1);
            da.Update(dt);
            da1.Update(dt1);
            db.closeConnection();
           
        }
        public void delete(string cnn,string query)
        {
            db.Save_Data(cnn);
            db.cm.CommandText = query;
            db.cm.ExecuteNonQuery();
            db.closeConnection();
        }
    }
}
