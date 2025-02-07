using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Ejercicio_Con_Ciclos
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
                do
                {
                    Console.WriteLine("Bienvenido a mi calculadora \n");
                    Console.WriteLine("¿Que deseas hacer? \n");
                    Console.WriteLine("(1) Sumar");
                    Console.WriteLine("(2) Restar");
                    Console.WriteLine("(3) Multiplicar");
                    Console.WriteLine("(4) dividir");
                    Console.WriteLine("(5) Salir");
                    opcion = Convert.ToByte(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Digita el primer número: ");
                            num1 = Convert.ToInt16(Console.ReadLine());

                            Console.WriteLine("Digita el segundo número: ");
                            num2 = Convert.ToInt16(Console.ReadLine());

                            resultado = num1 + num2;

                            Console.WriteLine("El resultado es: {0}", resultado);

                            break;

                        case 2:
                            Console.WriteLine("Digita el primer número: ");
                            num1 = Convert.ToInt16(Console.ReadLine());

                            Console.WriteLine("Digita el segundo número: ");
                            num2 = Convert.ToInt16(Console.ReadLine());

                            resultado = num1 - num2;

                            Console.WriteLine("El resultado es: {0}", resultado);

                            break;

                        case 3:
                            Console.WriteLine("Digita el primer número: ");
                            num1 = Convert.ToInt16(Console.ReadLine());

                            Console.WriteLine("Digita el segundo número: ");
                            num2 = Convert.ToInt16(Console.ReadLine());

                            resultado = num1 * num2;

                            Console.WriteLine("El resultado es: {0}", resultado);

                            break;

                        case 4:
                            Console.WriteLine("Digita el primer número: ");
                            num1 = Convert.ToInt16(Console.ReadLine());

                            Console.WriteLine("Digita el segundo número: ");
                            num2 = Convert.ToInt16(Console.ReadLine());

                            resultado = num1 * num2;

                            Console.WriteLine("El resultado es: {0}", resultado);

                            break;
                    }

                } while (opcion < 5);
            }
            catch (FormatException)
            {
                Console.WriteLine("El formato no es valido, solo es permitido números enteros");
            }catch (OverflowException)
            {
                Console.WriteLine("Lo siento el número es demaciado grande, intentelo con otro mas pequeño");
            }

            Console.ReadKey();
            
        }
    }
}
