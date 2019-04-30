using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Client
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string PhoneNumber { get; set; }
        public string Passport { get; set; }
        public string Address { get; set; }
        public override string ToString()
        {
            return $"{ID}. Имя: {Name} Фамилия: {SecondName} Номер Телефона: {PhoneNumber} Паспорт: {Passport} Адрес:{Address}";
        }
    }
}
