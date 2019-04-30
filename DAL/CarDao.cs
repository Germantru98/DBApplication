using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DAL.Interface;
using Entities;

namespace DAL
{
    public class CarDao : ICarDao
    {
        private string _connectionString = @"Data Source=TOP-PC\SQLEXPRESS;Initial Catalog = RepairStation; Integrated Security = True";
        public void Add(Car value)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddCar";
                cmd.Parameters.AddWithValue(@"ClientID", value.ClientID);
                cmd.Parameters.AddWithValue(@"Number", value.Number);
                cmd.Parameters.AddWithValue(@"Mark", value.Mark);
                cmd.Parameters.AddWithValue(@"Model", value.Model);
                cmd.Parameters.AddWithValue(@"DofM", value.DateOfManufacture);
                cmd.Parameters.AddWithValue(@"Colour", value.Colour);

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

        public IEnumerable<Car> GetAll()
        {
            List<Car> cars = new List<Car>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAllCars";
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cars.Add(new Car
                    {
                        ID = (int)reader["CarID"],
                        ClientID = (int)reader["ClientID"],
                        Number = (string)reader["Number"],
                        Mark = (int)reader["Mark"],
                        Model = (string)reader["Model"],
                        DateOfManufacture = (DateTime)reader["DofM"],
                        Colour = (string)reader["Colour"]
                    });
                }
            }
            return cars;
        }

        public Car GetByID(int ID)
        {
            Car car = new Car();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetCarByID";
                cmd.Parameters.AddWithValue(@"ID", ID);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    car.ID = (int)reader["CarID"];
                    car.ClientID = (int)reader["ClientID"];
                    car.Number = (string)reader["Number"];
                    car.Mark = (int)reader["Mark"];
                    car.Model = (string)reader["Model"];
                    car.DateOfManufacture = (DateTime)reader["DofM"];
                    car.Colour = (string)reader["Colour"];
                }
            }
            return car;
        }

        public void RemoveByID(int ID)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "RemoveCar";
                cmd.Parameters.AddWithValue(@"ID", ID);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
