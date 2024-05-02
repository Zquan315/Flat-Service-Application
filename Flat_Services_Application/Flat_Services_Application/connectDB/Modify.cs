using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Flat_Services_Application.connectDB
{
    internal class Modify
    {
        SqlDataAdapter dataAdapter;
        public Modify()
        {

        }
        public DataTable getAllRoomate()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM [Flat_Service_Application3].[dbo].[Roomate]";
            using (SqlConnection sqlConnection = Connection.GetConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }
    }
}
