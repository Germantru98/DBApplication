using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DAL.Interface;
using Entities;


namespace DAL
{

    public class ContractDao : IContractDao
    {
        private string _connectionString = @"Data Source=TOP-PC\SQLEXPRESS;Initial Catalog = RepairStation; Integrated Security = True";
        public void Add(Contract value)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddContract";
                cmd.Parameters.AddWithValue(@"SpecialistID", value.SpecialistID);
                cmd.Parameters.AddWithValue(@"CarID", value.CarID);
                cmd.Parameters.AddWithValue(@"Date", value.Date);
                cmd.Parameters.AddWithValue(@"Time", value.Time);
                cmd.Parameters.AddWithValue(@"Defect", value.Defect);
                cmd.Parameters.AddWithValue(@"Payment", value.Payment);

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

        public IEnumerable<Contract> GetAll()
        {
            List<Contract> contracts = new List<Contract>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAllContracts";
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    contracts.Add(new Contract
                    {
                        ID = (int)reader["ContractID"],
                        SpecialistID = (int)reader["SpecialistID"],
                        CarID = (int)reader["CarID"],
                        Date = (DateTime)reader["Date"],
                        Time = (TimeSpan)reader["Time"],
                        Defect = (string)reader["Defect"],
                        Payment = (int)reader["Payment"]
                    });
                }
            }
            return contracts;
        }

        public Contract GetByID(int ID)
        {
            Contract contract = new Contract();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetContractByID";
                cmd.Parameters.AddWithValue(@"ID", ID);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    contract.ID = (int)reader["ContractID"];
                    contract.SpecialistID = (int)reader["SpecialistID"];
                    contract.CarID = (int)reader["CarID"];
                    contract.Date = (DateTime)reader["Date"];
                    contract.Time = (TimeSpan)reader["Time"];
                    contract.Defect = (string)reader["Defect"];
                    contract.Payment = (int)reader["Payment"];
                }
            }
            return contract;
        }

        public void RemoveByID(int ID)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "RemoveContract";
                cmd.Parameters.AddWithValue(@"ID", ID);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public IEnumerable<Contract> PeriodReport(DateTime begin,DateTime end)
        {
            List<Contract> list = new List<Contract>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Report_for_the_period";
                cmd.Parameters.AddWithValue("@begin", begin.ToShortDateString());
                cmd.Parameters.AddWithValue("@end", end.ToShortDateString());
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Contract
                    {
                        ID = (int)reader["ContractID"],
                        SpecialistID = (int)reader["SpecialistID"],
                        CarID = (int)reader["CarID"],
                        Date = (DateTime)reader["Date"],
                        Time = (TimeSpan)reader["Time"],
                        Defect = (string)reader["Defect"],
                        Payment = (int)reader["Payment"]
                    });
                }
            }
            return list;
        }
    }
}
