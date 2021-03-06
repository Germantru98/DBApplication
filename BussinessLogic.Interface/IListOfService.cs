﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic.Interface
{
    public interface IListOfService
    {
        IEnumerable<ListOfService> GetAll();

        void Add(ListOfService value);

        void Remove(int ID);        
    }
}
