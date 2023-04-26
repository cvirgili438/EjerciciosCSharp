using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Problema7
    {
        public Problema7()
        {
            List<int> returnedNumbers(List<string> givenStrings) 
            {
                try {
                    List<int> newIntList = new List<int>();
                    foreach (string str in givenStrings)
                    {
                        newIntList.Add(int.Parse(str));
                    }
                    return newIntList;
                }
                catch (FormatException) {
                    Console.Write("Por favor introduzca solo numeros");                   
                    return null;
                }
            }
            void InputNumbers() 
            {
                try {
                    Console.WriteLine("En la siguiente linea de codigo escriba numeros separados por espacios: ");
                    string input = Console.ReadLine();
                   
                    //string[] strings = input.Split(' ');
                    List<string> strings= new List<string>();
                    for (int i = 0; i < input.Length; i++) {
                        if (input[i] == ' ')
                        {
                           continue;
                        }
                        else {                            
                            strings.Add(input[i].ToString());
                        }
                    }
                    
                    List<int> returned =  returnedNumbers(strings);
                    Console.WriteLine($"Returned count {returned.Count()}");
                    if (returned.Count() == 0)
                    {
                        InputNumbers();
                    }
                    else {
                        int product= 1;
                        foreach (int number in returned) {
                            product=product * number;
                        }
                        Console.WriteLine($"Producto final = {product}");
                    }
                    
                }
                catch (Exception ex) {
                    Console.WriteLine(ex.ToString());
                }
                finally {
                    Program.RestartApplication();
                }
            }
            InputNumbers();
        }  
    }
}
