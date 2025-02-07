using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _15_Aprendiendo_Break_Continue_Goto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Break: Detiene por completo la ejecución del bucle

            byte num;

            for(num = 1; num <= 10; num++)
            {
                if(num == 9)
                {
                    Console.WriteLine("Haz llegado al número {0} se detuvo el bucle", num);
                    break; // break //
                }
                else
                {
                    try
                    {  
                 // Thread.Sleep: Sirve para que el proceso tarde 1 seg antes de hacer lo siguiente
                        Thread.Sleep(1000);
                        Console.WriteLine("Voy por el número: {0}", num);
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("Arguemeto fuera de rango");
                    }
                   
                }
            }


            // Continue: Lo que hace es omitir el elemento si se cumple la condicion

            for (num = 1; num <= 10; num++)
            {
                if (num == 9)
                {
                    continue; // continue omitira el número 9 y seguira con el número 10 //
                }
                else
                {
                    try
                    {
                        // Thread.Sleep: Sirve para que el proceso tarde 1 seg antes de hacer lo siguiente
                        Thread.Sleep(1000);
                        Console.WriteLine("Voy por el número: {0}", num);
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("Arguemeto fuera de rango");
                    }

                }
            }


            /* Goto: Permite poner una etiqueta que luego sirve de referencia para llamar a un proceso con el mismo nombre de la etiqueta 
                Si esta dentro de un bucle goto ira al proceso que tiene el mismo identificador que le pusiste
                en el goto hara lo que este dentro de esa etiqueta, y saldra del bucle 
               
             */

            for (num = 1; num <= 10; num++)
            {
                if (num == 9)
                {
                    Console.WriteLine("");
                    goto retirados; //Etiqueta retirados
                }
                else
                {
                    try
                    {
                        // Thread.Sleep: Sirve para que el proceso tarde 1 seg antes de hacer lo siguiente
                        Thread.Sleep(1000);
                        Console.WriteLine("Voy por el número: {0}", num);
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("Arguemeto fuera de rango");
                    }

                }
            }

            // Ejecución del proceso goto con el mismo nombre de la etiqueta
            retirados:
              Console.WriteLine("El afilidado 9 se reporto enfermo el dia de hoy");
             








            Console.ReadKey();

        }
    }
}
