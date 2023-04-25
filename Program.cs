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
        static string Problem1 = "1)Permitir al usuario escribir dos números y mostrar en " +
            "pantalla cuál de los dos es el más grande. Si soniguales, mostrar cualquiera.";
        static string Problem2 = "2)Escribir un método que acepte un número y " +
            "devuelva True si el número es par, o false si es impar.";
        static string Problem3 = "3)Escribir un método que acepte dos strings y " +
            "devuelva el string con más caracteres. Si ambos tienen lamisma cantidad " +
            "de caracteres, devolver cualquiera de los dos.";
        static string Problem4 = "4)Escribir un método que acepte dos catetos y " +
            "devuelve la hipotenusa (usar la clase Math para calcularla raíz cuadrada)";
        static string Problem5 = "5)Utilizando un iterador escribir en pantalla " +
            "los números del 1 al 100 de dos en dos.";
        static string Problem6 = "6)Escribir un método que acepte un double que " +
            "represente un número en grados Celcius y lotransforme a grados Fahrenheit.";
        static string Problem7 = "7)Escribir un método que acepte una lista de" +
            " números y devuelva el producto de dichos números.";
        static string Problem8 = "8)Escribir un método que acepte un int y te" +
            " devuelva el factorial de dicho número. Nota: El factorial de 3 es 321," +
            " el factorial de 5 es 54321, etc.";
        static string Problem9 = "9)Escribir un método que acepte una lista de" +
            " números y devuelva su promedio.";
        static string Problem10 = "10)Escribir un método que acepte una lista de " +
            "números y devuelva el número más grande.";


        static void Main(string[] args)
        {
            Console.Clear();
            
            Console.WriteLine("A Continuacion se " +
                "detallaran los problemas, Elija un numero y elija " +
                "cual quiere ejecutar: ");
            string[] Problems = {
                Problem1, 
                Problem2, 
                Problem3,
                Problem4,
                Problem5,
                Problem6,
                Problem7,
                Problem8,
                Problem9,
                Problem10};
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
                            Problema1 problem1 = new Problema1();
                            return  ;
                        case (int)Choosed.Problema2:                            
                            Problema2 problema2 = new Problema2(); 
                            return;
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
