using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ListOfDetailPL
    {
        public int ContractID { get; set; }
        public int DetailID { get; set; }
        public string DetailName { get; set; }
        public decimal Price { get; set; }
        public ListOfDetailPL(int contractId,int detailID,string detailName,decimal price)
        {
            ContractID = contractId;
            DetailID = detailID;
            DetailName = detailName;
            Price = price;
        }
        public ListOfDetailPL()
        { }
        public override string ToString()
        {
            return $"{ContractID}. {DetailID}. Деталь: {DetailName} Цена: {Price}";
        }
    }
}
