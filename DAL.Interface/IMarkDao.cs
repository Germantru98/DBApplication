using System;
using System.Collections.Generic;
using Entities;

namespace DAL.Interface
{
    public interface IMarkDao
    {
        IEnumerable<Mark> GetAll();
        void Add(Mark value);

        void Remove(Mark value);

        IEnumerable<Mark> GetByID(int id);
    }
}
