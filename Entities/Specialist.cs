using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Specialist
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Qualification { get; set; }
        public override string ToString()
        {
            return $"{ID}. Имя:{Name} Фамилия:{SecondName} Квалификация:{Qualification}";
        }
    }
}
