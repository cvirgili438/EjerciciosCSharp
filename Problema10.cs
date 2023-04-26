using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Problema10
    {
        public Problema10() 
        {
            void MaxValue() 
            {
                try
                {
                    Console.WriteLine("Por favor ingrese los numeros separados por espacio: ");
                    string NumberString = Console.ReadLine();
                    List<string> listString = Problema7.getListOfNumberStrings(NumberString);
                    List<int> listInts = Problema7.ReturnedNumbers(listString);
                    BigInteger max = new BigInteger(0);
                    foreach (int i in listInts)
                    {
                        if (i >= max)
                        {
                            max = i;
                        }
                    }
                    Console.WriteLine(max);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    MaxValue();
                }
                finally {
                    Program.RestartApplication();
                }
            }
            MaxValue();
        }
    }
}
