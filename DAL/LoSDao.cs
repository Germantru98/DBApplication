using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DAL.Interface;
using Entities;

namespace DAL
{
    public class LoSDao : IListOfServiceDao
    {
        private string _connectionString = @"Data Source=TOP-PC\SQLEXPRESS;Initial Catalog = RepairStation; Integrated Security = True";
        public void Add(ListOfService value)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddLoS";
                cmd.Parameters.AddWithValue(@"ServiceID", value.ServiceID);
                cmd.Parameters.AddWithValue(@"ContractID", value.ContractID);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<ListOfServicePL> GetAllServices()
        {
            List<ListOfServicePL> list = new List<ListOfServicePL>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAllListOfService";                
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new ListOfServicePL
                    {                        
                        ContractID = (int)reader["ContractID"],
                        ServiceID = (int)reader["ServiceID"],
                        Description = (string)reader["Description"],
                        Price = (decimal)reader["Price"]
                    });
                }
            }
            return list;
        }

        public IEnumerable<ListOfService> GetAllServices(int contractID)
        {
            List<ListOfService> list = new List<ListOfService>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAllServices";
                cmd.Parameters.AddWithValue(@"ID", contractID);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new ListOfService
                    {
                        ContractID = (int)reader["ContractID"],
                        ServiceID = (int)reader["ServiceID"]                        
                    });
                }
            }
            return list;
        }

        public void RemoveByID(int contractID)
        {
            using(var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "RemoveLos";
                cmd.Parameters.AddWithValue(@"ID", contractID);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
