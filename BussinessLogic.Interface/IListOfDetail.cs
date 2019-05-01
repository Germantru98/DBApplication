using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic.Interface
{
    interface IListOfDetail
    {
        IEnumerable<ListOfDetail> GetAll();

        void Add(ListOfDetail value);

        void Remove(int ID);

        ListOfDetail GetByID(int ID);
    }
}
