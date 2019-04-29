using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL.Interface
{
    interface IListOfDetailDao
    {
        IEnumerable<ListOfDetail> GetAll();
        void Add(ListOfDetail value);

        void RemoveByID(int ID);

        ListOfDetail GetByID(int ID);
    }
}
