using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL.Interface
{
    public interface IContractDao
    {
        IEnumerable<Contract> GetAll();
        void Add(Contract value);

        void RemoveByID(int ID);

        Contract GetByID(int ID);
    }
}
