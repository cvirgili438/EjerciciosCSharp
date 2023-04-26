using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Problema3
    {
        public Problema3() {
            void Longest() {
                try
                {
                    Console.Write("Por favor, ingrese palabras,numeros o lo que quiera :");
                    string first = Console.ReadLine();
                    Console.Write("Ingrese la segunda palabra: ");
                    string second = Console.ReadLine();
                    if (first.Length > second.Length)
                    {
                        Console.WriteLine(first);
                    }
                    else if (second.Length > first.Length)
                    {
                        Console.WriteLine(second);
                    }
                    else
                    {
                        string[] third = { first, second };
                        Random random = new Random();
                        int randomNumber = random.Next(0, third.Length);
                        Console.WriteLine($"el numero random {randomNumber}");
                        Console.WriteLine(third[randomNumber]);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally 
                {
                    Program.RestartApplication();
                }
            }
            Longest();
        }
    }
}
