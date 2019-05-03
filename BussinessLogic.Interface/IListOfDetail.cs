using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic.Interface
{
    public interface IListOfDetail
    {
        void Add(ListOfDetail value);

        void Remove(int ID);
        IEnumerable<ListOfDetailPL> GetAll();
    }
}
