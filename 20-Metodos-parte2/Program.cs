using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Metodos_parte2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte opcion;

            Console.WriteLine("Escoge una de estas opciones ");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("¿Que deseas hacer? ");

            try
            {
                opcion = Convert.ToByte(Console.ReadLine());


                if (opcion == 1)
                {
                    Sumar();

                }
                else if (opcion == 2)
                {
                    float resultado;
                    resultado = Restar();
                    Console.WriteLine("El resultado de la resta es: {0}", resultado);
                }
                else if (opcion == 3)
                {
                    float numero1;
                    float numero2;

                    Console.WriteLine("Digite el primer númeero");
                    numero1 = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine("Digite el segundo númeero");
                    numero2 = Convert.ToSingle(Console.ReadLine());

                    Multiplicacion(numero1, numero2);
                }
                else if (opcion == 4)
                {
                    float numero1;
                    float numero2;
                    float resultado;

                    Console.WriteLine("Digite el primer númeero");
                    numero1 = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine("Digite el segundo númeero");
                    numero2 = Convert.ToSingle(Console.ReadLine());

                    resultado =  Division(numero1, numero2);

                    Console.WriteLine("El resultado de la división es {0}", resultado);
                }
                else
                {
                    Console.WriteLine("La opción elegida no es valida....");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Lo siento no se permiten valores alphanuméricos");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Lo siento el número ingresado es muy pequeño o muy grande, intente nuevamente");

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("No puedes dividir entre 0");
            }
            catch (Exception error)
            {
                Console.WriteLine("Ha ocurrido un error: " + error.Message + " " + " debe agregar la siguiente expecpción: " + error.GetType());
            }

            Console.ReadKey();
        }


        static void Sumar()
        {
            float numero1;
            float numero2;
            float resultado;

            Console.WriteLine("Digite el primer númeero");
            numero1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite el segundo númeero");
            numero2 = Convert.ToSingle(Console.ReadLine());

            resultado = numero1 + numero2;

            Console.WriteLine("El resultado es: {0}", resultado);
        }

        static float Restar()
        {
            float numero1;
            float numero2;
            float resultado;

            Console.WriteLine("Digite el primer númeero");
            numero1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite el segundo númeero");
            numero2 = Convert.ToSingle(Console.ReadLine());

            resultado = numero1 - numero2;

            return resultado;
        }

        /* Metodos o funciones con parametros */
        static void Multiplicacion(float numero1, float numero2)
        {
            float resultado;

            resultado = numero1 * numero2;

            Console.WriteLine("El resultado de la multiplicación es: {0}", resultado);

        }


        static float Division(float numero1, float numero2)
        {
            float resultado;

            if (numero2 == 0)
            {
                Console.WriteLine("Lo siento no se puede dividir por 0");
                resultado = 0.0f;
                return resultado;
            }
            else
            {
               resultado = numero1 / numero2;
                return resultado;
            }
        }
    }
}
