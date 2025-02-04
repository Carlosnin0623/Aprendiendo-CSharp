using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Bloque_ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            short num1, num2;
            int resultado;
            byte opcion;

            try
            {
                Console.WriteLine("Este programa simula una calculadora: ");
                Console.WriteLine("Digita el primer número: ");
                num1 = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Digita el segundo número: ");
                num2 = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Muchas Gracias!!! \n");
                Console.WriteLine("¿Que deseas hacer? ");
                Console.WriteLine("(1) sumar");
                Console.WriteLine("(2) restar");
                Console.WriteLine("(3) Multiplicar");
                Console.WriteLine("(4) dividir \n");
                opcion = Convert.ToByte(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                         
                        resultado = num1 + num2;
                        Console.WriteLine("El resultado es {0}", resultado);
                        break;

                    case 2:
                        resultado = num1 - num2;
                        Console.WriteLine("El resultado es {0}", resultado);
                        break;

                    case 3:
                        resultado = num1 * num2;
                        Console.WriteLine("El resultado es {0}", resultado);
                        break;

                    case 4:
                        resultado = num1 * num2;
                        Console.WriteLine("El resultado es {0}", resultado);
                        break;

                    default:
                        Console.WriteLine("La opcion seleccionada no es válida");
                        break;
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Lo siento, solo se permiten números enteros....");
            }catch (OverflowException)
            {
                Console.WriteLine("Lo siento ha sobrepasado el número límite, intente con otro número mas pequeño...");
            }
           






            Console.ReadKey();
        }
        
    }
}
