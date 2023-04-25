using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Problema2
    {
        public Problema2() 
        {
            void isPair() {
                try
                {
                    Console.Write("Introduzca un numero: ");
                    int par = int.Parse(Console.ReadLine());
                    Console.WriteLine(par % 2 == 0);

                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Por favor, ingrese un numero válido: ");
                    isPair();
                    
                }
                finally
                {
                    Console.Write("Desea reiniciar el programa ? Y/N ");
                    string response = Console.ReadLine();
                    if (response.ToUpper() == "N")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Program.RestartApplication();
                    }
                }
            }
            isPair();
            
        }
    }
}
