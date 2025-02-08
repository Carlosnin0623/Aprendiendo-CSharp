using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Bloque_de_ejercicios_ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte num;
            int acumulador = 0;
            string respuesta;

            try
            {

                do
                {
                    Console.WriteLine("Digite el número: ");
                    num = Convert.ToByte(Console.ReadLine());

                    acumulador += Convert.ToInt32(num);

                    Console.WriteLine("Esto es lo que llevas acumulad: {0}", acumulador);

                    Console.WriteLine("Deseas salir?");
                    respuesta = Console.ReadLine();

                } while (respuesta.ToLower() != "si");

            }catch (OverflowException)
            {
                Console.WriteLine("Ha ocurrido un error, el número ingresado es muy alto o muy bajo");
            }
              

            Console.ReadKey();

        }
    }
}
