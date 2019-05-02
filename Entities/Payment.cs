using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Payment
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public Payment()
        { }
        public Payment(string name,string type)
        {
            Name = name;
            Type = type;
        }
        public override string ToString()
        {
            return $"{ID}. Способ оплаты: {Name} Тип: {Type}";
        }
    }
}
