using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Problema5
    {
        public Problema5()
        {
            for (int i = 1; i <= 100; i+=2) 
            {
                Console.WriteLine($"{i} {i+1}");
            }
            Program.RestartApplication();
        }
    }
}
