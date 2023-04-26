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
            
            void InputNumbers() 
            {
                try {
                    Console.WriteLine("En la siguiente linea de codigo escriba numeros separados por espacios: ");
                    string input = Console.ReadLine();
                   
                   
                   List<string>strings = getListOfNumberStrings(input);                    
                    List<int> returned =  ReturnedNumbers(strings);                   
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
       public static List<int> ReturnedNumbers(List<string> givenStrings)
        {
            try
            {
                List<int> newIntList = new List<int>();
                foreach (string str in givenStrings)
                {
                    newIntList.Add(int.Parse(str));
                }
                return newIntList;
            }
            catch (FormatException)
            {
                Console.Write("Por favor introduzca solo numeros");
                return null;
            }
        }
        public static List<string> getListOfNumberStrings(string input ) {
            
            List<string> strings = new List<string>();
            try {
                string dinamicString = "";
                for (int i = 0; i < input.Length; i++)
                {

                    if (input[i] == ' ' || i == input.Length)
                    {
                        if (i == 0)
                        {
                            continue;
                        }
                        else if (i == input.Length-1 && dinamicString.Length >0 ) 
                        { 
                            strings.Add(dinamicString); 
                        }
                        else if (dinamicString.Length > 0)
                        {
                            strings.Add(dinamicString);
                            dinamicString = "";
                            continue;
                        }


                    }
                    else {
                        dinamicString = dinamicString + input[i];
                        if (i == input.Length-1) { 
                            strings.Add(dinamicString);
                        }
                    }
                }
               
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            foreach (string str in strings) { Console.WriteLine($"viendo los str {str}"); }
            
        return strings;
        }
    }
}
