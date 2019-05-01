using System;
using System.Collections.Generic;
using System.Linq;
using Entities;

namespace BussinessLogic.Interface
{
    public interface ISpecialist
    {
        IEnumerable<Specialist> GetAll();

        void Add(Specialist value);

        void Remove(int ID);

        Specialist GetByID(int ID);
    }
}
