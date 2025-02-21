using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Arreglos_como_parametros
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*  Arreglos como parametros
             *   
             *   Cuando enviamos un arreglo como parametro a un metodo:
             *   
             *   1- El arreglo enviado y el arreglo del parámetro debe ser del mismo tipo de dato.
             *   
             *   2- Debe tener las mismas dimenciones, es decir ambos son como listas o como matriz.
             *   
             *   3- Ambos deben ser del mismo estilo: normal o Jagged
             *   
             */


            int[] numeros = new int[5];
            int n = 0;

            try
            {
                for (n = 0; n < numeros.Length; n++)
                {
                    Console.WriteLine("Digita un número");
                    numeros[n] = Convert.ToInt32(Console.ReadLine());
                }

                ImprimirNumero(numeros);
            }catch(FormatException)
            {
                Console.WriteLine("El dato ingresado no es correcto");

            }catch (OverflowException)
            {
                Console.WriteLine("El número ingresado no es valido");

            }catch(Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error: {0}", ex.Message);
            }


            Console.ReadKey(); 

        }


        static void ImprimirNumero(int[] arreglo)
        {
            int n;

            Console.WriteLine("Estos son los números ingresado");

            for(n = 0; n < arreglo.Length; n++)
            {
                Console.WriteLine("{0}", arreglo[n]);
            }
        }
    }
}
