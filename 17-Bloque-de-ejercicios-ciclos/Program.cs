using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _17_Bloque_de_ejercicios_ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digita un número: ");
            byte numero = Convert.ToByte(Console.ReadLine());


            for(byte i = 1; i <= 20; i++)
            {
                if(i == numero)
                {
                    Console.WriteLine("Número omitido");
                    continue;
                    
                }
                else
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("{0}", i);
                }
            }

            Console.ReadKey();

        }
    }
}
