using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL.Interface
{
    interface IListOfServiceDao
    {
        IEnumerable<ListOfService> GetAll();
        void Add(ListOfService value);

        void RemoveByID(int ID);

        ListOfService GetByID(int ID);
    }
}
