using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Potencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero;
            byte potencia;
            float resultado;

            try
            {
                Console.WriteLine("Digita el número: ");
                numero = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Digita la potencia: ");
                potencia = Convert.ToByte(Console.ReadLine());

                resultado =  Potencia(numero, potencia);

                Console.WriteLine("El resultado es {0}", resultado);

            }
            catch (FormatException)
            {
                Console.WriteLine("El formato ingresado no es valido");

            }catch (OverflowException)
            {
                Console.WriteLine("El número ingresado es muy grande o muy pequeño");
            }

            Console.ReadKey();
        }

        static float Potencia(float numero, byte exponente)
        {
            float valor = 1f;

            for (short i = 0; i < exponente; i++)
            {
                valor *= numero;
            }

            return valor;

        }
    }
}
