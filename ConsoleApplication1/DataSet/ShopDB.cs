using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApplication1;
using System.Data.SqlClient;

namespace ConsoleApplication1.DataSet
{
    public class ShopDB
    {
        public ICollection<ShopDB> SelectAllDatSet()
        {
            return null;
        }
        SqlConnection connection = new SqlConnection();
        //connection.SqlConnection = "Server=(localdb)\\mssqllocaldb; DataBase=ConsoleApplication1; Trusted_Connection=true;";
        string insertSqlScript = "insert into DataSet(Login, Passqord) values";
        //SqlCommand command = connection.CreateCommand();
        //command.ExecuteNonQuery();
        SqlCommand command = new SqlCommand(selectSqlScript);
        private static string selectSqlScript;
        
    }
}
