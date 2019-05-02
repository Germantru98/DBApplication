using System;
using System.Collections.Generic;
using System.Linq;
using Entities;

namespace BussinessLogic.Interface
{
    public interface IClient
    {
        IEnumerable<Client> GetAll();

        void Add(Client value);

        void Remove(int ID);

        Client GetByID(int ID);
    }
}
