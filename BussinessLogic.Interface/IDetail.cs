using Entities;
using System.Collections.Generic;

namespace BussinessLogic.Interface
{
    public interface IDetail
    {
        IEnumerable<Detail> GetAll();

        void Add(Detail value);

        void Remove(int ID);

        Detail GetByID(int ID);
    }
}
