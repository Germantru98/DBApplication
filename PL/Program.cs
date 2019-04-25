using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace PL
{
    class Program
    {
        static void Main(string[] args)
        {
            MarkDao t = new MarkDao();
            foreach (var test in t.GetAll())
            {
                Console.WriteLine(test);
            }            
        }
    }
}
