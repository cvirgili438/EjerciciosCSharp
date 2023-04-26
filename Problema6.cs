using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Problema6
    {
        public Problema6() 
        {
            void CelciusToFarenheit()
            {
                try { 
                    Console.WriteLine(" Indroduzca los °C para pasarlos a °F(Solo numeros): "); 
                    double celcius = double.Parse(Console.ReadLine());
                    double Farenheit = (celcius*1.8)+32;
                    Console.WriteLine($"El resultado en °F: {Farenheit}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString()); 
                }
                finally { Program.RestartApplication(); }
            }
            CelciusToFarenheit();
        }
    }
}
