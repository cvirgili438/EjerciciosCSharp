using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Problema9
    {
        public Problema9() 
        {
            void mediumRange()
            {
                try {
                    Console.Write("Por favor, ingrese los separados por espacios: ");

                    string input = Console.ReadLine();
                    List<string> listString = Problema7.getListOfNumberStrings(input);
                    List<int> listInts = Problema7.ReturnedNumbers(listString);
                    int max=0;
                    
                    foreach (int i in listInts)
                    {
                        max += i;                       
                    }
                    Console.WriteLine($"COUNT {listInts.Count()}  max {max}");
                    Console.WriteLine(max/listInts.Count());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    mediumRange();
                }
                finally { Program.RestartApplication(); }
            }
            mediumRange();
           

        }
    }
}
