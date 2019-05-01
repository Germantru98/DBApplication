using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLogic.Interface;
using Entities;
using DAL;
namespace BusinessLogic
{
    public class MarkLogic : IMark
    {
        private MarkDao markDao = new MarkDao();
        public void Add(Mark value)
        {
            markDao.Add(value);
        }

        public IEnumerable<Mark> GetAll()
        {
            return markDao.GetAll();
        }

        public Mark GetByID(int ID)
        {
            return markDao.GetByID(ID);
        }

        public void Remove(int ID)
        {
            markDao.RemoveByID(ID);
        }
    }
}
