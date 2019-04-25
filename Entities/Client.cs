using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Client
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string PhoneNumber { get; set; }
        public string Passport { get; set; }
        public string Address { get; set; }
        public override string ToString()
        {
            return $"{ID} {Name} {SecondName} {PhoneNumber} {Passport} {Address}";
        }
    }
}
