using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class ListOfDetail
    {
        public int ContractID { get; set; }
        public int DetailID { get; set; }

        public override string ToString()
        {
            return $"{ContractID} {DetailID}";
        }
    }
}
