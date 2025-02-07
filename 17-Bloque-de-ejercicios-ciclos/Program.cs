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
            short suma = 0;

            Console.WriteLine("Digita el número: ");
            num = Convert.ToByte(Console.ReadLine());

            for(byte i = 1; i < num; i++)
            {
               if(i % 2 == 0)
                {
                    Console.WriteLine("{0}", i);
                    suma += i; 
                }
            }

            Console.WriteLine("La suma total fue: {0}", suma);



            Console.ReadKey();

        }
    }
}
