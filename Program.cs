using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    enum Choosed { 
        Problema1= 1,
        Problema2=2, 
        Problema3=3, 
        Problema4=4,
    }
    internal class Program
    {
        static string Problem1 = "1) Permitir al usuario escribir dos números" +
            " y mostrar en pantalla cuál de los dos es el más grande. " +
            "Si soniguales, mostrar cualquiera";
        static string Problem2 = "2) Escribir un método que acepte un número " +
            "y devuelva True si el número es par, o false si es impar";
        static string Problem3 = "3) Escribir un método que acepte dos strings " +
            "y devuelva el string con más caracteres. Si ambos tienen lamisma" +
            " cantidad de caracteres, devolver cualquiera de los dos.";
        static string Problem4 = "4) Escribir un método que acepte dos catetos " +
            "y devuelve la hipotenusa (usar la clase Math para calcularla raíz cuadrada)";
      

        static void Main(string[] args)
        {
            
            Console.WriteLine("A Continuacion se " +
                "detallaran los problemas, Elija un numero y elija " +
                "cual quiere ejecutar: ");
            string[] Problems = {Problem1, Problem2, Problem3,Problem4};
            foreach (string problem in Problems) {
                Console.WriteLine(problem);
            }
            
             void ChooseProblem() {
                try
                {
                    int ProblemNum = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    switch (ProblemNum) {
                        case (int) Choosed.Problema1:
                            Console.WriteLine(ProblemNum);
                            Problema1 problem1 = new Problema1();
                            return  ;
                        default:
                            Console.WriteLine("El numero que eligió, no es un ejercicio valido, elija otro :");
                             ChooseProblem() ;
                            return;

                    }

                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Tipee un numero, no un caracter diferente");
                    ChooseProblem();
                }
            }
            ChooseProblem();
           

        }
        public static void RestartApplication()
        {
            Main(new string[] { });
        }
    }
}
