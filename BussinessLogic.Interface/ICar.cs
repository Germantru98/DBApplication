using System;
using System.Collections.Generic;
using System.Linq;
using Entities;

namespace BussinessLogic.Interface
{
    public interface ICar
    {
        IEnumerable<Car<string>> GetAll();

        void Add(Car<int> value);

        void Remove(int ID);

        Car<int> GetByID(int ID);
    }
}
