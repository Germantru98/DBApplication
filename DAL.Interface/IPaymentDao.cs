using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL.Interface
{
    public interface IPaymentDao
    {
        IEnumerable<Payment> GetAll();
        void Add(Payment value);

        void RemoveByID(int ID);

        Payment GetByID(int ID);
    }
}
