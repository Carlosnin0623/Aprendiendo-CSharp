using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Encontrar_el_valor_maximo_de_una_matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crea un programa con una matriz con valores predeterminados que encuentre el valor máximo en ella.*/

            int[,] matriz =
            {
                {10,20,30},
                {40,50,60},
                {70,80,90}
            };

            int valor = 0;

            for(int i = 0; i < matriz.GetLength(0); i++)
            {
                for(int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i,j] > valor)
                    {
                        valor = matriz[i,j];
                    }
                }
            }

            Console.WriteLine("El número mayor es {0}", valor);
            Console.ReadKey();
        }
    }
}
