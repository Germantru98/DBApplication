using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using BussinessLogic.Interface;
using DAL;

namespace BusinessLogic
{
    public class ListOfServiceLogic : IListOfService
    {
        private LoSDao loSDao = new LoSDao();
        public void Add(ListOfService value)
        {
            loSDao.Add(value);
        }

        public IEnumerable<ListOfServicePL> GetAll()
        {
            return loSDao.GetAllServices();
        }       
        public void Remove(int ID)
        {
            loSDao.RemoveByID(ID);
        }

        IEnumerable<ListOfService> IListOfService.GetAll()
        {
            throw new NotImplementedException();
        }
        public decimal TotalPrice(int ID)
        {
            return loSDao.TotalPrice(ID);
        }
    }
}
