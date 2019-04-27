using System;
using System.Collections.Generic;
using Entities;

namespace DAL.Interface
{
    public interface IMarkDao
    {
        IEnumerable<Mark> GetAll();
        void Add(Mark value);

        void RemoveByID(int ID);

        Mark GetByID(int ID);
    }
}
