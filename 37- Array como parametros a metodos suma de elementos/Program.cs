using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37__Array_como_parametros_a_metodos_suma_de_elementos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor;
            int[] coleccion = new int[5] { 2, 5, 6, 12, 18 };

            valor = suma(coleccion);

            Console.WriteLine("La suma de todos los elementos dentro del array es {0}", valor);

            Console.ReadKey();
        }

        static int suma(int[] array_numerico)
        {

            int suma = 0;

            foreach (int numeros in array_numerico)
            {
                suma += numeros;
            }

            return suma;
        }
}

}
