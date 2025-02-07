using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Aprendiendo_Bucle_DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* El bucle Do While: Nos permite ejecutar una vez el codigo antes de pasar a la condición
             * 
             * 
             * 
             *   do {
             *     
             *     Se ejecuta este codigo mientras se cumpla la condición, una vez no se cumpla 
             *     sale del ciclo
             *   
             *     aumento ++ o decremente si se necesita
             *   }while(condición)
             * 
             */


            // Programa de carpinteria

            float pies, pulgadas, centimetros;
            string respuesta;

   
                try
                {
                  do
                  {
                    Console.WriteLine("Digite los pies: ");
                    pies = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine("Digite los pulgadas: ");
                    pulgadas = Convert.ToSingle(Console.ReadLine());

                    centimetros = (pies * 30.48f) + (pulgadas * 2.54f);

                    Console.WriteLine("Los centímetros son: {0}cm", centimetros);

                    Console.WriteLine("¿Deseas hacer otra conversión? ");
                    respuesta = Console.ReadLine();

                  }while(respuesta.ToLower() == "si");
                   
                }catch (FormatException)
                {
                    Console.WriteLine("Lo siento solo se permiten valores enteros o decimales...");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Lo siento el número es muy grande, intente con otro más pequeño");
                }
                
                 Console.ReadKey();

        
        }
    }
}
