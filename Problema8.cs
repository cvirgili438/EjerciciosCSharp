using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Problema8
    {
        public Problema8()
        {
            void isFactorial() {
                try {
                    Console.WriteLine("Porfavor introduzca el numero a obtener el factorial: ");
                    int number = int.Parse(Console.ReadLine());
                    string result="";
                    for (int i = number; i > 0; i--) 
                    {
                        result=result+ i.ToString();
                    }
                    Console.WriteLine(result);

                }
                catch (FormatException)
                {
                    Console.WriteLine("Por favor introduzca un solo numero, sin espacios y no caracteres especiales");
                    isFactorial();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    isFactorial();
                }
              
                finally
                {
                    Program.RestartApplication();
                }
            }
            isFactorial();
        }
    }
}
