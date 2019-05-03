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
    public class ListOfDetailLogic : IListOfDetail
    {
        private LoDDao loDDao= new LoDDao();
        public void Add(ListOfDetail value)
        {
            loDDao.Add(value);
        }

        public IEnumerable<ListOfDetailPL> GetAll()
        {
            return loDDao.GetAllDetail();
        }

        public void Remove(int ID)
        {
            loDDao.RemoveByID(ID);
        }
        public decimal TotalPrice(int ID)
        {
            return loDDao.TotalPrice(ID);
        }
    }
}
