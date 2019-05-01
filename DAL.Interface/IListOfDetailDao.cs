using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL.Interface
{
    public interface IListOfDetailDao
    {
        IEnumerable<ListOfDetail> GetAllDetail(int contractID);
        void Add(ListOfDetail value);
        void RemoveByID(int contractID);
        
    }
}
