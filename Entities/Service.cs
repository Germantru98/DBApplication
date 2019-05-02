using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Service
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Service()
        { }
        public Service(string description, decimal price)
        {
            Description = description;
            Price = price;
        }
        public override string ToString()
        {
            return $"{ID}. Услуга: {Description}. Цена: {Price}";
        }
    }
}
