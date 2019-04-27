using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Detail
    {
        public int ID { get; set; }
        public string Detail_Name { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{ID}. {Detail_Name} Стоимость: {Price}";
        }
    }
}
