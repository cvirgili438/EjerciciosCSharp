using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Problema11
    {
              
        public static Matriz yourMatriz(int size)
        {
            try
            {        
                Matriz matriz = new Matriz(size,size);
                List<int>[] arrayList = new List<int>[size];
                Console.Write("Ingrese fila la primera linea, presione enter, y asi hasta terminar : ");
                for (int i = 0; i < arrayList.Length; i++)
                {
                    string _line = Console.ReadLine();
                    List<string> stringFirstLine = Problema7.getListOfNumberStrings(_line);
                    List<int> listFirstLine = Problema7.ReturnedNumbers(stringFirstLine);
                    arrayList[i] = listFirstLine;
                }
                matriz.FillMatriz(arrayList);
                return matriz;

            }
            catch (FormatException)
            {
                Console.WriteLine("Escriba bien el numero, sin espacio ni caracteres especiales: ");

                return yourMatriz(size);
            }


        }

        public static int startSecuence() {
            try {
                Console.Write("Elija el tamaño de la matriz por un solo numero, ejemplo '1': ");
                int size = int.Parse(Console.ReadLine());
                return size;
            }
            catch (FormatException) {
                Console.WriteLine("Elija bien el numero, sin espacio ni caracteres especiales");
                return startSecuence();
            }
            
           
        }
        public Problema11() 
        {
          
            try {
                int size = startSecuence();
                Matriz _matriz1 = yourMatriz(size);
                Matriz _matriz2 = yourMatriz(size);
                Matriz SumMatriz = _matriz1 + _matriz2;
                SumMatriz.ShowMatrix();

            }
            catch (Exception ex) { Console.WriteLine(); }
            finally { Program.RestartApplication(); }
            
        }
    }
    public class Matriz {
        private int[,] _data;

        public Matriz(int Filas,  int Columnas) {

            _data = new int[ Filas, Columnas];
        }
        public int FILAS { get { return _data.GetLength(0); } }
        public int COLUMNAS { get { return _data.GetLength(1); } }
        public int this[int fila, int columna] {
            get { 
                return _data[fila, columna];
            }
            set {
                _data[fila, columna] = value;
            }
        }
        public void SetLines(List<int> listLines,int line ) {
            for (int i = 0; i < listLines.Count(); i++)
            {
                _data[line, i] = listLines[i];
            }
        }
        //public void SetColumn(List<int> listColumn, int column) 
        //{
        //    for (int i = 0; i < listColumn.Count(); i++)
        //    {
        //        _data[i, column] = listColumn[i];
        //    }
        //}
         public void FillMatriz( params List<int>[] listas ) {
            for (int i = 0; i < listas.Count(); i++)
            {
               
                SetLines(listas[i],i);
            }
        }
        public static Matriz operator +(Matriz a, Matriz b) {
            if (a.FILAS != b.FILAS || a.COLUMNAS != b.COLUMNAS) {
                throw new ApplicationException("Las matrices deben ser de las mismas dimensiones");
            }
            Matriz c = new Matriz(a.FILAS, a.COLUMNAS);
            for (int i = 0; i < a.FILAS; i++)
            {
                for (int j = 0; j < a.COLUMNAS; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];

                }
            }
            return c;
        }
        public void ShowMatrix( ) {
            string Finishing = "";
            for (int i = 0; i < FILAS; i++)
            {
                for (int j = 0; j < COLUMNAS; j++)
                {
                    if (j == COLUMNAS - 1)
                    {
                        Finishing = Finishing + $"{_data[i,j]}\n";
                    }
                    else {
                        Finishing = Finishing + $"{_data[i,j]}\t";
                    }
                }
                if (i == FILAS-1) {
                    Finishing = Finishing + "Final";
                }
            }
            Console.WriteLine( Finishing );
        }
       
    }
}
