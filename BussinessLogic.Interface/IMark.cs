
using Entities;
using System.Collections.Generic;

namespace BussinessLogic.Interface
{
    public interface IMark
    {
        IEnumerable<Mark> GetAll();

        void Add(Mark value);

        void Remove(int ID);

        Mark GetByID(int ID);
    }
}
