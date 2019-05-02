using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL.Interface
{
    public interface ICarDao
    {
        IEnumerable<Car<string>> GetAll();
        void Add(Car<int> value);

        void RemoveByID(int ID);

        Car<int> GetByID(int ID);
    }
}
