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

            bool tienePremium = false;
            bool hazRealizadoCompras = false;

            try
            {
                Console.WriteLine("Bienvenido al supermercado ole!!!");

                Console.WriteLine("Tiene cuenta premiun?: ");

                tienePremium = Convert.ToBoolean(Console.ReadLine());

                if (tienePremium)
                {

                    Console.WriteLine("Haz realizado mas de 5 compras?: ");

                    hazRealizadoCompras = Convert.ToBoolean(Console.ReadLine());

                    if (hazRealizadoCompras)
                    {

                        Console.WriteLine("Usted es elegible para un descuento especial.");
                    }
                    else
                    {

                        Console.WriteLine("Usted no es elegible para un descuento especial.");
                    }
                }
                else
                {

                    Console.WriteLine("Haz realizado mas de 5 compras?: ");

                    hazRealizadoCompras = Convert.ToBoolean(Console.ReadLine());

                    if (hazRealizadoCompras)
                    {

                        Console.WriteLine("Usted es elegible para un descuento especial.");
                    }
                    else
                    {

                        Console.WriteLine("Usted no es elegible para un descuento especial.");
                    }
                }
            }catch (Exception error)
            {
                Console.WriteLine(error.Message.ToString());
            }

          
            Console.ReadKey();
          

        }
    }
}
