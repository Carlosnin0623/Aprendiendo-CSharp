using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Datos_de_entrada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte numero1, numero2;
            string opcion;

            Console.WriteLine("APLICACION DE SUMAS");

            Console.WriteLine("Digite el prímer número: ");
            numero1 = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Digite el segundo número: ");
            numero2 = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("¿ Que deseas hacer: ?");
            Console.WriteLine("(sumar) para sumar ambos números");
            Console.WriteLine("(restar) para restar ambos números");
            Console.WriteLine("(multiplicar) para multiplicar ambos números");
            Console.WriteLine("(dividir) para dividir ambos números");
            opcion = Console.ReadLine();

            if (opcion == "sumar")
            {
                Console.WriteLine("La suma es: {0}", numero1 + numero2);

            }else if (opcion == "restar")
            {
                Console.WriteLine("La resta es: {0}", numero1 - numero2);

            }else if (opcion == "multiplicar")
            {
                Console.WriteLine("La resta es: {0}", numero1 * numero2);

            }else if (opcion == "division")
            {
                Console.WriteLine("La resta es: {0}", numero1 / numero2);
            }

            Console.ReadKey();

        }
    }
}
