using System;
using System.Collections.Generic;
using Entities;

namespace DAL.Interface
{
    public interface IMarkDao
    {
        IEnumerable<Mark> GetAll();
        int Add(Mark value);

        int Remove(Mark value);

        IEnumerable<Mark> GetByID(int id);
    }
}
