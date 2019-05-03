using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DAL.Interface;
using Entities;

namespace DAL
{
    public class SpecialistDao : ISpecialistDao
    {
        private string _connectionString = @"Data Source=TOP-PC\SQLEXPRESS;Initial Catalog = RepairStation; Integrated Security = True";
        public void Add(Specialist value)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddSpecialist";
                cmd.Parameters.AddWithValue(@"Name", value.Name);
                cmd.Parameters.AddWithValue(@"SecondName", value.SecondName);
                cmd.Parameters.AddWithValue(@"Qualification", value.Qualification);
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

        public IEnumerable<Specialist> GetAll()
        {
            List<Specialist> specialists = new List<Specialist>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAllSpecialist";
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    specialists.Add(new Specialist
                    {
                        ID = (int)reader["SpecialistID"],
                        Name = (string)reader["Name"],
                        SecondName = (string)reader["SecondName"],
                        Qualification = (string)reader["Qualification"]

                    });
                }
            }
            return specialists;
        }
        public IEnumerable<Specialist> GetAllFreeSpecialists()
        {
            List<Specialist> freespecialists = new List<Specialist>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAllFreeSpecialist";
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    freespecialists.Add(new Specialist
                    {
                        ID = (int)reader["SpecialistID"],
                        Name = (string)reader["Name"],
                        SecondName = (string)reader["SecondName"],
                        Qualification = (string)reader["Qualification"]

                    });
                }
            }
            return freespecialists;
        }

        public Specialist GetByID(int ID)
        {
            Specialist specialist = new Specialist();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetSpecialistByID";
                cmd.Parameters.AddWithValue(@"ID", ID);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    specialist.ID = (int)reader["SpecialistID"];
                    specialist.Name = (string)reader["Name"];
                    specialist.SecondName = (string)reader["SecondName"];
                    specialist.Qualification = (string)reader["Qualification"];

                }
            }
            return specialist;
        }

        public void RemoveByID(int ID)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "RemoveSpecialist";
                cmd.Parameters.AddWithValue(@"ID", ID);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
