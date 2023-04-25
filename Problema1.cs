using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Problema1
    {
       
        public Problema1() 
        {
           void Selected() {
                try
                {
                    Console.Write("Ingrese el primer número: ");
                    int first = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el segundo número: ");
                    int second = int.Parse(Console.ReadLine());
                    bool exact = first > second;
                    switch (exact)
                    {
                        case true:
                            Console.WriteLine(first);
                            return;
                        case false:
                            Console.WriteLine(second);
                            return;
                        default:
                            Console.WriteLine("Como son iguales, " +
                                "te tiro cualquiera los 2 :" + first + " y " + second);
                            return;
                    }

                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Por favor escriba un numero: ");
                    Selected();
                }
                finally {
                    Console.Write("Desea reiniciar el programa ? Y/N ");
                    string response = Console.ReadLine();
                    if (response.ToUpper() == "N")
                    {
                        Environment.Exit(0);
                    }
                    else {
                        Program.RestartApplication();
                    }
                }
            }
            Selected();

        }
     
        

    }
}
