using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _17_Bloque_de_ejercicios_ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            byte num;
            byte valor = 1;
            byte capturar = 0;

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            try
            {
                Console.WriteLine("Introduzca el número: ");
                num = Convert.ToByte(Console.ReadLine());

                while (valor <= num)
                {
                    Console.WriteLine("{0}", valor);
                    capturar += valor;
                    valor++;
                }

                Console.WriteLine("La suma de números es: {0} y el número limite: {1}", capturar, num);

            }catch (Exception error)
            {
                Console.WriteLine($"Error: {error.Message}");
            }


            // Detener el cronómetro
            stopwatch.Stop();

            // Mostrar el tiempo transcurrido
            Console.WriteLine("El código tardó: " + stopwatch.ElapsedMilliseconds + " milisegundos");

            Console.ReadKey();

        }
    }
}
