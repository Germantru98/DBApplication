using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Contract
    {
        public int ID { get; set; }
        public int CarID{ get; set; }
        public int SpecialistID { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string Defect { get; set; }
        public int Payment { get; set; }

        public Contract()
        { }
        public Contract(int specialistID, int carID, DateTime date,TimeSpan time, string defect,int payment)
        {
            SpecialistID = specialistID;
            CarID = carID;
            Date = date;
            Time = time;
            Defect = defect;
            Payment = payment;
        }
        public override string ToString()
        {
            return $"{ID}. Автомобиль: {CarID} Специалист: {SpecialistID} Дата:{Date.ToShortDateString()} Затраченое время: {Time} Дефект: {Defect} Способ оплаты: {Payment}";

        }
    }
}
