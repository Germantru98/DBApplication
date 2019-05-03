using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ListOfDetail
    {
        public int ContractID { get; set; }
        public int DetailID { get; set; }

        public ListOfDetail()
        { }
        public ListOfDetail(int contractID, int detailID)
        {
            ContractID = contractID;
            DetailID = detailID;
        }
        public override string ToString()
        {
            return $"Номер контракта: {ContractID}. Номер детали:{DetailID}.";
        }
    }
}
