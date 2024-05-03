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
        SqlDataAdapter dataAdapter; //truy xuat du lieu vao bang
        SqlCommand sqlCommand; //truy van va cap nhat du lieu
        public Modify()
        {

        }
        public DataTable getAllRoomate()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM [Flat_Service_Application5].[dbo].[Roomate]";
            using (SqlConnection sqlConnection = Connection.GetConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }

        public bool insert(roomate roomMate)
        {
            SqlConnection sqlConnection = Connection.GetConnection();
            string query = "INSERT INTO [Flat_Service_Application5].[dbo].[Roomate] VALUES (@ID_number_roomate,@Full_name,@Sex,@Date_of_birth,@ID_vehical,@Home_address,@Phone_number_roomate,@ID_number_tenant)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID_number_roomate", SqlDbType.VarChar).Value = roomMate.Id;
                sqlCommand.Parameters.Add("@Full_name", SqlDbType.NVarChar).Value = roomMate.Name;
                sqlCommand.Parameters.Add("@Sex", SqlDbType.NVarChar).Value = roomMate.Sex;
                sqlCommand.Parameters.Add("@Date_of_birth", SqlDbType.NVarChar).Value = roomMate.DateOfBirth.ToShortDateString(); //chi lay ngay, thang, nam
                sqlCommand.Parameters.Add("@ID_vehical", SqlDbType.VarChar).Value = roomMate.IdVehical;
                sqlCommand.Parameters.Add("@Home_address", SqlDbType.NVarChar).Value = roomMate.Address;
                sqlCommand.Parameters.Add("@Phone_number_roomate", SqlDbType.VarChar).Value = roomMate.PhoneNumber;
                sqlCommand.Parameters.Add("@ID_number_tenant", SqlDbType.VarChar).Value = roomMate.IdTenant;
                sqlCommand.ExecuteNonQuery(); //thuc thi cau lenh truy van
            }
            catch 
            {
                return false;   
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
    }
}
