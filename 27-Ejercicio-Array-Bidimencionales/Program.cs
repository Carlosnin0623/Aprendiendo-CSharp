using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_Ejercicio_Array_Bidimencionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos un array bidimencional de 3 filas y 3 columnas

            int[,] matriz =
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9},
            };

            int suma = 0;

            /* 
             * 
                  Aquí se usan dos bucles anidados para recorrer la matriz:

                     matriz.GetLength(0): Devuelve el número de filas (3).
                     matriz.GetLength(1): Devuelve el número de columnas (3).
             */

            for (int i = 0; i < matriz.GetLength(0); i++) // Itera sobre las filas
            {
                for (int j = 0; j < matriz.GetLength(1); j++) // Itera sobre las columnas
                {
                    suma += matriz[i, j]; // Suma cada elemento
                }
            }

            /* 
             *
            El bucle externo (i) recorre las filas y el bucle interno (j) recorre las columnas.

                   Iteración	i (Fila)	j (Columna)	matriz[i, j]	suma
                       1	        0	          0	         1	          1
                       2	        0	          1	         2	          3
                       3            0             2          3            6
                       4            1             0          4           10
                       5            1             1          5           15
                       6            1             2          6           21
                       7            2             0          7           28
                       8            2             1          8           36
                       9            2             2          9           45 
             */

            Console.WriteLine("La suma total es: {0}", suma);

          

            Console.ReadKey();
        }
    }
}
