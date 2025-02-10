using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Ejercicios_con_metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float precio_escritorio = 600.00f;
            byte cantidad;
            float resultado;

            try
            {
                Console.WriteLine("Digite la cantidad de muebles comprados");
                cantidad = Convert.ToByte(Console.ReadLine());

                if (cantidad < 5)
                {
                    resultado = Descuento10(precio_escritorio);

                    Console.WriteLine("La cantidad a pagar es: {0}", resultado);

                }
                else if (cantidad > 5 && cantidad < 10)
                {
                    resultado = Descuento20(precio_escritorio);

                    Console.WriteLine("La cantidad a pagar es: {0}", resultado);

                }
                else if (cantidad >= 10)
                {
                    resultado = Descuento40(precio_escritorio);

                    Console.WriteLine("La cantidad a pagar es: {0}", resultado);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Lo siento solo se permiten números enteros");

            }catch (OverflowException)
            {
                Console.WriteLine("Lo siento haz ingresado un número menor a 0 o mayor a 255");

            }catch(Exception Error)
            {
                Console.WriteLine("Ha ocurrido un error: {0} y este es el tipo: {1}", Error.Message, Error.GetType());
            }

           

            Console.ReadKey();

        }


        static float Descuento10(float precio_escritorio)
        {
            float descuento = 0.10f;
            float resultado;

            resultado = precio_escritorio - (precio_escritorio * descuento);


            return resultado;
     

        }

        static float Descuento20(float precio_escritorio)
        {
            float descuento = 0.20f;
            float resultado;

            resultado = precio_escritorio - (precio_escritorio * descuento);


            return resultado;
        }

        static float Descuento40(float precio_escritorio)
        {
            float descuento = 0.40f;
            float resultado;

            resultado = precio_escritorio - (precio_escritorio * descuento);


            return resultado;
        }
    }
}
