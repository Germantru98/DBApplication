using System;
using System.Collections.Generic;
using Entities;

namespace DAL.Interface
{
    interface IDetailDao
    {
        IEnumerable<Detail> GetAll();
        void Add(Detail value);

        void Remove(Detail value);

        IEnumerable<Detail> GetByID(int id);
    }
}
