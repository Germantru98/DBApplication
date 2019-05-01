using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic.Interface
{
    public interface IService
    {
        IEnumerable<Service> GetAll();

        void Add(Service value);

        void Remove(int ID);

        Service GetByID(int ID);
    }
}
