using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;
using BussinessLogic.Interface;

namespace BusinessLogic
{
    public class CarLogic : ICar
    {
        private CarDao carDao = new CarDao();
        public void Add(Car<int> value)
        {
            carDao.Add(value);
        }

        public IEnumerable<Car<string>> GetAll()
        {
            return carDao.GetAll();
        }

        public Car<int> GetByID(int ID)
        {
            return carDao.GetByID(ID);
        }

        public void Remove(int ID)
        {
            carDao.RemoveByID(ID);
        }
    }
}
