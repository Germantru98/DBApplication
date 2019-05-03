using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ListOfServicePL
    {   
        public int ContractID { get; set; }
        public int ServiceID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public ListOfServicePL()
        { }
        public ListOfServicePL(int contrctId,int serviceID, string description, decimal price)            
        {
            ContractID = contrctId;
            ServiceID = serviceID;
            Description = description;
            Price = price;
        }
        public override string ToString()
        {
            return $"{ContractID}. {ServiceID}. Услуга: {Description} Цена: {Price}";
        }
    }
}
