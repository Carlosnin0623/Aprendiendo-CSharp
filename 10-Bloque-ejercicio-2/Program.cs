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

            decimal num1, num2, num3;

            try
            {
                Console.WriteLine("Introduce el primer número: ");
                num1 = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Introduce el segundo número: ");
                num2 = Convert.ToDecimal(Console.ReadLine());

                num3 = num1 / num2;

                Console.WriteLine("El resultado de la división entre el número {0} y el número {1} es {2}", num1, num2, num3);


            }catch (FormatException)
            {
               Console.WriteLine("Lo siento este programa solo permite valores enteros y decimales");

            }catch (OverflowException)
            {
               Console.WriteLine("Lo siento ingrese un valor más pequeño");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("No se puede dividir por cero");
            } 

            
            Console.ReadKey();
        }
        
    }
}
