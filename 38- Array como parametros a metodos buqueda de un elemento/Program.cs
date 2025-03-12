using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38__Array_como_parametros_a_metodos_buqueda_de_un_elemento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[5];

            Buscar_nombre(nombres);

            Console.ReadKey();
        }

        static void Buscar_nombre(string[] array_nombre)
        {
            string nombre_a_buscar;
            int valor = 0;

            do
            {
                Console.WriteLine("Digita un nombre");
                array_nombre[valor] = Console.ReadLine().ToLower();

                valor++;

            } while (valor < array_nombre.Length);


            Console.WriteLine("Digite el nombre que desee buscar");
            nombre_a_buscar = Console.ReadLine();




            foreach (string s in array_nombre)
            {
                if (s == nombre_a_buscar)
                {
                    Console.WriteLine("El nombre a buscar existe dentro del sistema {0}", s);
                    break;
                }
                else
                {
                    Console.WriteLine("El nombre {0} no existe en nuestro sistema", nombre_a_buscar);
                    break;
                }
            }


        }
    }
}
