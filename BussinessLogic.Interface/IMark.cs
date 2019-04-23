
using Entities;
using System.Collections.Generic;

namespace BussinessLogic.Interface
{
    public interface IMark
    {
        IEnumerable<Mark> GetAll();

        int Add(Mark value);

        int Remove(Mark value);

        IEnumerable<Mark> GetByID(int id);
    }
}
