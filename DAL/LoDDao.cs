using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DAL.Interface;
using Entities;

namespace DAL
{
    public class LoDDao : IListOfDetailDao
    {
        private string _connectionString = @"Data Source=TOP-PC\SQLEXPRESS;Initial Catalog = RepairStation; Integrated Security = True";
        public void Add(ListOfDetail value)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddLoD";
                cmd.Parameters.AddWithValue(@"DetailID", value.DetailID);
                cmd.Parameters.AddWithValue(@"ContractID", value.ContractID);                            
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<ListOfDetail> GetAllDetail(int contractID)
        {
            List<ListOfDetail> list = new List<ListOfDetail>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAllDetails";
                cmd.Parameters.AddWithValue(@"ID", contractID);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new ListOfDetail
                    {
                        ContractID = (int)reader["ContractID"],
                        DetailID = (int)reader["DetailID"]
                    });
                }
            }
            return list;
        }
        public IEnumerable<ListOfDetailPL> GetAllDetail()
        {
            List<ListOfDetailPL> list = new List<ListOfDetailPL>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAllListOfDetail";                
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new ListOfDetailPL
                    {
                        ContractID = (int)reader["ContractID"],
                        DetailID = (int)reader["DetailID"],
                        DetailName = (string)reader["DetailName"],
                        Price = (decimal)reader["Price"]
                    });
                }
            }
            return list;
        }

        public void RemoveByID(int contractID)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "RemoveLoD";
                cmd.Parameters.AddWithValue(@"ID", contractID);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
