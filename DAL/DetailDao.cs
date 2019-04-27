using System.Collections.Generic;
using Entities;
using DAL.Interface;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DetailDao : IDetailDao
    {
        private string _connectionString = @"Data Source=TOP-PC\SQLEXPRESS;Initial Catalog = RepairStation; Integrated Security = True";
        public void Add(Detail value)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddDetail";
                cmd.Parameters.AddWithValue(@"DetailName", value.Detail_Name);
                cmd.Parameters.AddWithValue(@"Price", value.Price);
                var id = new SqlParameter
                {
                    DbType = DbType.Int32,
                    ParameterName = "@ID",
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(id);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public IEnumerable<Detail> GetAll()
        {
            List<Detail> details = new List<Detail>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAllDetail";
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    details.Add(new Detail
                    {
                        ID = (int)reader["DetailID"],
                        Detail_Name = (string)reader["DetailName"],
                        Price = (decimal)reader["Price"]
                    });
                }
            }
            return details;
        }

        public Detail GetByID(int ID)
        {
            Detail detail = new Detail();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetDetailByID";
                cmd.Parameters.AddWithValue(@"ID", ID);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    detail.ID = (int)reader["DetailID"];
                    detail.Detail_Name = (string)reader["DetailName"];
                    detail.Price = (decimal)reader["Price"];
                }
            }
            return detail;
        }

        public void RemoveByID(int ID)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "RemoveDetail";
                cmd.Parameters.AddWithValue(@"ID", ID);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
