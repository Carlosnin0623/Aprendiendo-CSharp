using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Calculadora_con_metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string simbolo;
                float num1;
                float num2;
                float resultado;
                Console.WriteLine("Esta es mi calculadora");
                Console.WriteLine("¿Que deseas hacer?");
                Console.WriteLine("(+) Sumar");
                Console.WriteLine("(-) Restar");
                Console.WriteLine("(*) Multiplicar");
                Console.WriteLine("(/) Dividir");

                // ConsoleKeyInfo: Es una clase que nos permite capturar la tecla presionada por el usuario

                ConsoleKeyInfo tecla = Console.ReadKey();
                Console.WriteLine("");
                char operacion = tecla.KeyChar;

                simbolo = operacion.ToString();

                if (simbolo == "+")
                {
                    try
                    {
                        Console.WriteLine("Digita el primer número");
                        num1 = Convert.ToSingle(Console.ReadLine());

                        Console.WriteLine("Digita el segundo número");
                        num2 = Convert.ToSingle(Console.ReadLine());

                        Sumar(num1, num2);
                    }
                    catch(FormatException)
                    {
                        Console.WriteLine("Lo siento,  solo permitimos valores enteros o decimales");
                    }
                    catch(OverflowException)
                    {
                        Console.WriteLine("Lo siento, el número ingresado sobrepasa el límite");
                    }
                    catch(Exception error)
                    {
                        Console.WriteLine("Ha ocurrido un error: {0} de este tipo {1}", error.Message, error.GetType());
                    }


                }
                else if (simbolo == "-")
                  {
                    try
                    {
                        Console.WriteLine("Digita el primer número");
                        num1 = Convert.ToSingle(Console.ReadLine());

                        Console.WriteLine("Digita el segundo número");
                        num2 = Convert.ToSingle(Console.ReadLine());

                        resultado = Restar(num1, num2);

                        Console.WriteLine("La resta es: {0}", resultado);
                    }
                    catch(FormatException)
                    {
                        Console.WriteLine("Lo siento,  solo permitimos valores enteros o decimales");
                    }
                    catch(OverflowException)
                    {
                        Console.WriteLine("Lo siento, el número ingresado sobrepasa el límite");
                    }
                    catch(Exception error)
                    {
                        Console.WriteLine("Ha ocurrido un error: {0} de este tipo {1}", error.Message, error.GetType());
                    }



                }
                else if (simbolo == "*")
                {
                    try
                    {
                    Console.WriteLine("Digita el primer número");
                    num1 = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine("Digita el segundo número");
                    num2 = Convert.ToSingle(Console.ReadLine());

                    Multiplicar(num1, num2);
                    }
                    catch(FormatException)
                    {
                        Console.WriteLine("Lo siento,  solo permitimos valores enteros o decimales");
                    }
                    catch(OverflowException)
                    {
                        Console.WriteLine("Lo siento, el número ingresado sobrepasa el límite");
                    }
                    catch(Exception error)
                    {
                        Console.WriteLine("Ha ocurrido un error: {0} de este tipo {1}", error.Message, error.GetType());
                    }

                }
                else if (simbolo == "/")
                {
                    try
                    {
                        Console.WriteLine("Digita el primer número");
                        num1 = Convert.ToSingle(Console.ReadLine());

                        Console.WriteLine("Digita el segundo número");
                        num2 = Convert.ToSingle(Console.ReadLine());

                        resultado = Dividir(num1, num2);

                        Console.WriteLine("La división es: {0}", resultado);
                    }
                    catch(FormatException)
                    {
                        Console.WriteLine("Lo siento,  solo permitimos valores enteros o decimales");
                    }
                    catch(OverflowException)
                    {
                        Console.WriteLine("Lo siento, el número ingresado sobrepasa el límite");
                    }catch(DivideByZeroException)
                    {
                        Console.WriteLine("Lo siento no puedes dividir entre 0");
                    }
                    catch(Exception error)
                    {
                        Console.WriteLine("Ha ocurrido un error: {0} de este tipo {1}", error.Message, error.GetType());
                    }

                }
            }catch(FormatException)
            {
                Console.WriteLine("Lo siento,  solo permitimos valores enteros o decimales");
            }
            catch(OverflowException)
            {
                Console.WriteLine("Lo siento, el número ingresado sobrepasa el límite");
            }
            catch(Exception error)
            {
                Console.WriteLine("Ha ocurrido un error: {0} de este tipo {1}", error.Message, error.GetType());
            }
            
            Console.ReadKey();
 
        }


        static void Sumar(float numero1, float numero2)
        {
            float resultado;
            resultado = numero1 + numero2;

            Console.WriteLine("La suma es: {0}", resultado);
        }

        static float Restar(float numero1, float numero2)
        {
            float resultado;
            resultado = numero1 - numero2;

           return resultado;
        }

        static void Multiplicar(float numero1, float numero2)
        {
            float resultado;
            resultado = numero1 * numero2;

            Console.WriteLine("La multiplicación es: {0}", resultado);
        }

        static float Dividir(float numero1, float numero2)
        {
            float resultado;
            resultado = numero1 / numero2;

            return resultado;
        }
    }
}
