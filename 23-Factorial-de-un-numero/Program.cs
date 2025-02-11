using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Factorial_de_un_numero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long numero;
            long valor;
            try
            {
                Console.WriteLine("Digite el número");
                numero = Convert.ToInt64(Console.ReadLine());

                if(numero <= 0)
                {
                    Console.WriteLine("Lo siento no puedes introducir números menores o igual a 0");
                }
                else
                {
                    valor = CalcularFactorial(numero);

                    Console.WriteLine("El factorial de {0} es: {1}", numero, valor);
                }
 
            }
            catch (FormatException)
            {
                Console.WriteLine("Lo siento el formato ingresado no es valido");

            }catch (OverflowException)
            {
                Console.WriteLine("Lo siento el número ingresado sobrepasa el limite");

            }catch(Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error: {0} y es de tipo {1}", ex.Message, ex.GetType());
            }
            

            Console.ReadKey();
        }

        static long CalcularFactorial(long numero)
        {
            long resultado = 1;

            for (long i = numero; i > 1; i--)
            {
                resultado *= i;
            }

            return resultado;
        }
    }
}
