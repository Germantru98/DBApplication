using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;
using BussinessLogic.Interface;

namespace BusinessLogic
{
    public class ClientLogic : IClient
    {
        private ClientDao clientDao = new ClientDao();
        public void Add(Client value)
        {
            clientDao.Add(value);
        }

        public IEnumerable<Client> GetAll()
        {
            return clientDao.GetAll();
        }

        public Client GetByID(int ID)
        {
            return clientDao.GetByID(ID);
        }

        public void Remove(int ID)
        {
            clientDao.RemoveByID(ID);
        }
    }
}
