using BussinessLogic.Interface;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BusinessLogic
{
    class DetailLogic : IDetail
    {
        private DetailDao detailDao = new DetailDao();
        public void Add(Detail value)
        {
            detailDao.Add(value);
        }

        public IEnumerable<Detail> GetAll()
        {
            return detailDao.GetAll();
        }

        public Detail GetByID(int ID)
        {
            return detailDao.GetByID(ID);
        }

        public void Remove(int ID)
        {
            detailDao.RemoveByID(ID);
        }
    }
}
