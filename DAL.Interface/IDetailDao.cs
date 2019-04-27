using System;
using System.Collections.Generic;
using Entities;

namespace DAL.Interface
{
    public interface IDetailDao
    {
        IEnumerable<Detail> GetAll();
        void Add(Detail value);

        void RemoveByID(int ID);

        Detail GetByID(int ID);
    }
}
