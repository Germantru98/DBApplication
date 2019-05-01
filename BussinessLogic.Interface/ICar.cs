using System;
using System.Collections.Generic;
using System.Linq;
using Entities;

namespace BussinessLogic.Interface
{
    public interface ICar
    {
        IEnumerable<Car> GetAll();

        void Add(Car value);

        void Remove(int ID);

        Car GetByID(int ID);
    }
}
