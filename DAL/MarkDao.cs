﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DAL.Interface;
using Entities;

namespace DAL
{
    public class MarkDao : IMarkDao
    {
        private string _connectionString = @"Data Source=TOP-PC\SQLEXPRESS;Initial Catalog = RepairStation; Integrated Security = True";
        public void Add(Mark value)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddMark";
                cmd.Parameters.AddWithValue(@"Name", value.Name);

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

        public IEnumerable<Mark> GetAll()
        {
            List<Mark> marks = new List<Mark>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAllMarks";
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

        public Mark GetByID(int ID)
        {
            Mark mark = new Mark();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetMarkByID";
                cmd.Parameters.AddWithValue(@"ID", ID);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    mark.ID = (int)reader["MarkID"];
                    mark.Name = (string)reader["Name"];
                }
            }
            return mark;

        }

        public void RemoveByID(int ID)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "RemoveMark";
                cmd.Parameters.AddWithValue(@"ID", ID);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
