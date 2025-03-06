using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35__Contar_Elementos_de_cada_subArrey
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[][] matriz = new int[3][];

            matriz[0] = new int[3] { 1, 2, 4 };
            matriz[1] = new int[2] { 1, 2 };
            matriz[2] = new int[4] { 1, 2, 4, 5 };


            for (int i = 0; i < matriz.Length; i++)
            {
                Console.WriteLine("El subarray {0} tiene {1} elementos", i, matriz[i].Length);
            }

            Console.ReadKey();

          

        }
    }
}
