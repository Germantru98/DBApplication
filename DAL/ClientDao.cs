using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DAL.Interface;
using Entities;

namespace DAL
{
    public class ClientDao : IClientDao
    {
        private string _connectionString = @"Data Source=TOP-PC\SQLEXPRESS;Initial Catalog = RepairStation; Integrated Security = True";
        public void Add(Client value)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddClient";
                cmd.Parameters.AddWithValue(@"Name", value.Name);
                cmd.Parameters.AddWithValue(@"SecondName", value.SecondName);
                cmd.Parameters.AddWithValue(@"PhoneNumber", value.PhoneNumber);
                cmd.Parameters.AddWithValue(@"Passport", value.Passport);
                cmd.Parameters.AddWithValue(@"Address", value.Address);

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

        public IEnumerable<Client> GetAll()
        {
            List<Client> clients = new List<Client>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAllClients";
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    clients.Add(new Client
                    {
                        ID = (int)reader["ClientID"],
                        Name = (string)reader["Name"],
                        SecondName = (string)reader["SecondName"],
                        PhoneNumber = (string)reader["PhoneNumber"],
                        Passport = (string)reader["Passport"],
                        Address = (string)reader["Address"]
                    });
                }
            }
            return clients;
        }

        public Client GetByID(int ID)
        {
            Client client = new Client();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetClientByID";
                cmd.Parameters.AddWithValue(@"ID", ID);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    client.ID = (int)reader["ClientID"];
                    client.Name = (string)reader["Name"];
                    client.SecondName = (string)reader["SecondName"];
                    client.PhoneNumber = (string)reader["PhoneNumber"];
                    client.Passport = (string)reader["Passport"];
                    client.Address = (string)reader["Address"];
                }
            }
            return client;
        }

        public void RemoveByID(int ID)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "RemoveClient";
                cmd.Parameters.AddWithValue(@"ID", ID);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
