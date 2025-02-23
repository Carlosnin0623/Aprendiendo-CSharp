using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_Ejercicio1_Arreglos_Unidimencionales
{
    class Program
    {
        static void Main(string[] args)
        {

            int cantidad;
            float suma = 0f;

            try
            {
                Console.WriteLine("Digita la cantidad de números que desea contar");
                cantidad = Convert.ToInt32(Console.ReadLine());


                float[] numeros = new float[cantidad];

                for (int i = 0; i < numeros.Length; i++)
                {
                    Console.WriteLine("Digita el número");
                    numeros[i] = Convert.ToSingle(Console.ReadLine());
                }

                foreach (float valores in numeros)
                {
                    suma += valores;
                }

                Console.WriteLine("La suma total es: {0}", suma);
            }
            catch (FormatException)
            {
                Console.WriteLine("El formato ingresado no es valido");
            }
            catch (OverflowException)
            {
                Console.WriteLine("El valor ingresado esta fuera de los parametros");

            }catch(Exception error)
            {
                Console.WriteLine("Ha ocurrido un error: {0}", error.GetType());
            }

           
            Console.ReadKey();

        }
    }
}
