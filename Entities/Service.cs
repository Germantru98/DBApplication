using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Service
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{ID} {Description} {Price}";
        }
    }
}
