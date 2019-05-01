using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Mark
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"{ID}. {Name}";
        }
        public Mark()
        {
        }
        public Mark(int id,string name)
        {
            ID = id;
            Name = name;
        }

    }
}
