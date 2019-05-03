using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
     public class ListOfService
    {
        public int ContractID { get; set; }
        public int ServiceID { get; set; }

        public ListOfService()
        { }
        public ListOfService(int contractID,int serviceID)
        {
            ContractID = contractID;
            ServiceID = serviceID;
        }
        public override string ToString()
        {
            return $"{ContractID} {ServiceID}";
        }
    }
}
