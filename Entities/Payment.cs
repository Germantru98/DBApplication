using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Payment
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public override string ToString()
        {
            return $"{ID} {Name} {Type}";
        }
    }
}
