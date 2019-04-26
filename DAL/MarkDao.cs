using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DAL.Interface;
using Entities;

namespace DAL
{
    public class MarkDao : IMarkDao
    {
        private List<Mark> marks;
        private string _connectionString = @"Data Source=TOP-PC\SQLEXPRESS;Initial Catalog = RepairStation; Integrated Security = True";

        public MarkDao()
        {
            marks = new List<Mark>();
        }

        public void Add(Mark value)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                
            }           
        }

        public IEnumerable<Mark> GetAll()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from Mark";
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    marks.Add(new Mark
                    {
                        ID = (int)reader["MarkID"],
                        Name = (string)reader["Name"]
                    });
                }
            }
            return marks;
        }

        public IEnumerable<Mark> GetByID(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from Mark where MarkID = "+id;
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    marks.Add(new Mark
                    {
                        ID = (int)reader["MarkID"],
                        Name = (string)reader["Name"]
                    });
                }
            }
            return marks;
        }

        public void Remove(Mark value)
        {
            throw new NotImplementedException();
        }
    }
}
