using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _16_Ejercicio_Con_Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte num;
            Console.WriteLine("Introduce el número: ");
            num = Convert.ToByte(Console.ReadLine());

            num-=1;
            
            for(byte valor = num; valor >= 1; valor--)
            {
                Thread.Sleep(1000);
                Console.WriteLine("{0}", valor);
            }

            Console.ReadKey();
            
        }
    }
}
