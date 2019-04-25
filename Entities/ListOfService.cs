using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class ListOfService
    {
        public int ContractID { get; set; }
        public int ServiceID { get; set; }

        public override string ToString()
        {
            return $"{ContractID} {ServiceID}";
        }
    }
}
