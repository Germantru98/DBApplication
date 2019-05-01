using System;
using System.Collections.Generic;
using Entities;
using BussinessLogic.Interface;
using DAL;

namespace BusinessLogic
{
    class ServiceLogic : IService
    {
        private ServiceDao serviceDao = new ServiceDao();
        public void Add(Service value)
        {
            serviceDao.Add(value);
        }

        public IEnumerable<Service> GetAll()
        {
            return serviceDao.GetAll();
        }

        public Service GetByID(int ID)
        {
            return serviceDao.GetByID(ID);
        }

        public void Remove(int ID)
        {
            serviceDao.RemoveByID(ID);
        }
    }
}
