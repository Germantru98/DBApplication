using System;
using System.Collections.Generic;
using DAL;
using Entities;
using BussinessLogic.Interface;

namespace BusinessLogic
{
    public class PaymentLogic : IPayment
    {
        private PaymentDao paymentDao = new PaymentDao();
        public void Add(Payment value)
        {
            paymentDao.Add(value);
        }

        public IEnumerable<Payment> GetAll()
        {
            return paymentDao.GetAll();
        }

        public Payment GetByID(int ID)
        {
            return paymentDao.GetByID(ID);
        }

        public void Remove(int ID)
        {
            paymentDao.RemoveByID(ID);
        }
    }
}
