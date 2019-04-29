using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL.Interface
{
    interface ISpecialistDao
    {
        IEnumerable<Specialist> GetAll();
        void Add(Specialist value);

        void RemoveByID(int ID);

        Specialist GetByID(int ID);
    }
}
