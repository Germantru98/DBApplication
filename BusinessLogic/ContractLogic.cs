using System;
using System.Collections.Generic;
using DAL;
using Entities;
using BussinessLogic.Interface;

namespace BusinessLogic
{
    public class ContractLogic : IContract
    {
        private ContractDao contractDao = new ContractDao();
        public void Add(Contract value)
        {
            contractDao.Add(value);
        }

        public IEnumerable<Contract> GetAll()
        {
            return contractDao.GetAll();
        }

        public Contract GetByID(int ID)
        {
            return contractDao.GetByID(ID);
        }

        public void Remove(int ID)
        {
            contractDao.RemoveByID(ID);
        }
        public IEnumerable<Contract> PeriodReport(DateTime begin, DateTime end)
        {
            return contractDao.PeriodReport(begin, end);
        }
    }
}
