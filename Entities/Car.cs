using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Car
    {
        public int ID { get; set; }
        public int ClientID { get; set; }
        public string Number { get; set; }
        public int Mark { get; set; }
        public string Model { get; set; }
        public DateTime DateOfManufacture { get; set; }
        public string Colour { get; set; }
        public override string ToString()
        {
            return $"{ID}. Клиент: {ClientID} Номер: {Number} Марка: {Mark} Модель: {Model} Дата Выпуска: {DateOfManufacture.ToShortDateString()} Цвет: {Colour}";
        }

    }
}
