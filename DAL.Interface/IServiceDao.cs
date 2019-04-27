using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL.Interface
{
    public interface IServiceDao
    {
        IEnumerable<Service> GetAll();
        void Add(Service value);

        void RemoveByID(int ID);

        Service GetByID(int ID);
    }
}
