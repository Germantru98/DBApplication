using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL.Interface
{
    interface IClientDao
    {
        IEnumerable<Client> GetAll();
        void Add(Client value);

        void RemoveByID(int ID);

        Client GetByID(int ID);
    }
}
