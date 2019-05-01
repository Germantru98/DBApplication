using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic.Interface
{
    public interface IPayment
    {
        IEnumerable<Payment> GetAll();

        void Add(Payment value);

        void Remove(int ID);

        Payment GetByID(int ID);
    }
}
