using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace sqlHMSproject
{
    internal class DatabaseConnection
    {

        private SqlConnection connection;

        public DatabaseConnection()
        {
            string connectionString =
                "Server=localhost;" +
                "Database=HospitalDB;" +
                "Trusted_Connection=True;TrustServerCertificate=True;";

            connection = new SqlConnection(connectionString);
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }
    }
}