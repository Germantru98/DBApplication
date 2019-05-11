using System;
using DAL;

namespace ConsoleApp1
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
