using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neva
{
    internal class Database
    {

        SqlConnection sqlconnection = new SqlConnection(@"Data Source=AVCHOR;Initial Catalog=neva_db;Integrated Security=True");

        public void openConnection()
        {
            if (sqlconnection.State == System.Data.ConnectionState.Closed)
            {
                sqlconnection.Open();
            }
        }

        public void closeConnection()
        {
            if(sqlconnection.State == System.Data.ConnectionState.Open)
            {
                sqlconnection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return sqlconnection;
        }
    }
}
