using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Problema4
    {
        public Problema4 ()
        {
            void Hipotenusa() 
            {
                try { 

                    Console.Write("Ingresar largo del primer cateto: ");
                    int cateto1 = int.Parse(Console.ReadLine());
                    Console.Write ("Ingresar el largo del segundo cateto: ");
                    int cateto2 = int.Parse(Console.ReadLine());
                    double result = Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2));
                    Console.WriteLine($"El resultado es {result}");

                }
                catch (FormatException) 
                {
                    Console.WriteLine("Ingresar porfavor un numero valido: ");
                }
                finally
                {
                    Program.RestartApplication();
                }
            }
            Hipotenusa();
        }
    }
}
