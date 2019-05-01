using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;


namespace DAL.Interface
{
    public interface IListOfServiceDao
    {
        IEnumerable<ListOfService> GetAllServices(int contractID);
        void Add(ListOfService value);
        void RemoveByID(int contractID);
    }
}
