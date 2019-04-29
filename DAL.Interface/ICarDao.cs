using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL.Interface
{
    interface ICarDao
    {
        IEnumerable<Car> GetAll();
        void Add(Car value);

        void RemoveByID(int ID);

        Car GetByID(int ID);
    }
}
