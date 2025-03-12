using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36__Suma_de_Elementos_dentro_de_un_array_Jagged
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] coleccion = new int[3][];
            int suma = 0;

            coleccion[0] = new int[2] { 1, 2 };
            coleccion[1] = new int[2] { 2, 3 };
            coleccion[2] = new int[2] { 3, 4 };

            Console.WriteLine("Esta es la cantidad de elementos del jagged {0}", coleccion.Length);


            for (int i = 0; i < coleccion.Length; i++)
            {

                for (int j = 0; j < coleccion[i].GetLength(0); j++)
                {
                    suma += coleccion[i][j];
                }
            }

            Console.WriteLine("La suma total de los elementos del jagged es {0}", suma);



            Console.ReadKey();
        }
    }
}

