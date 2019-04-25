using System;
using System.Collections.Generic;
using Entities;

namespace DAL.Interface
{
    interface IDetailDao
    {
        IEnumerable<Detail> GetAll();
        int Add(Detail value);

        int Remove(Detail value);

        IEnumerable<Detail> GetByID(int id);
    }
}
