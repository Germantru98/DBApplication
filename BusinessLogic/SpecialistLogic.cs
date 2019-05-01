using System;
using Entities;
using BussinessLogic.Interface;
using System.Collections.Generic;
using DAL;

namespace BusinessLogic
{
    public class SpecialistLogic : ISpecialist
    {
        private SpecialistDao specialistDao = new SpecialistDao();
        public void Add(Specialist value)
        {
            specialistDao.Add(value);
        }

        public IEnumerable<Specialist> GetAll()
        {
            return specialistDao.GetAll();
        }

        public Specialist GetByID(int ID)
        {
            return specialistDao.GetByID(ID);
        }

        public void Remove(int ID)
        {
            specialistDao.RemoveByID(ID);
        }
    }
}
