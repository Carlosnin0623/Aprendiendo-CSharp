using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Valor_maximo_de_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int cantidad;
                Console.WriteLine("Digite la cantidad de números a ingresar");
                cantidad = Convert.ToInt32(Console.ReadLine());

                float[] valores = new float[cantidad];


                for (int i = 0; i < valores.Length; i++)
                {
                    Console.WriteLine("Digita el número");
                    valores[i] = Convert.ToSingle(Console.ReadLine());
                }

                float resultado = 0f;

                foreach (float numero in valores)
                {

                    if (numero > resultado)
                    {
                        resultado = numero;
                    }
                }

                Console.WriteLine("Este número es el mayor {0}", resultado);
            }catch (FormatException)
            {
                Console.WriteLine("El formato ingresado no es válido, favor intente de nuevo");
            }catch(OverflowException)
            {
                Console.WriteLine("El valor ingresado no esta permitido");
            }catch (Exception ex)
            {
                Console.WriteLine("Lo siento ha ocurrido un error: {0}", ex.GetType());
            }
           

            Console.ReadKey();

        }
    }
}
