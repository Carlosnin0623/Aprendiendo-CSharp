using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Try_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Try Catch:
             * 
             * Cuando se presenta un error al momento de ingresar los datos, la
             * aplicacion se va a detener. Esta estructura nos va a permitir
             * mostrar el error avisandole al usuario que ingreso un formato no valido
             * 
             * 
             *   try{
             *         Codigo
             *         
                  }catch(Exception "tipos de variables de exepcion"){
                      
                         
                  }
             
             */

            int n1, n2, resultado;

            try
            {
                Console.WriteLine("Escribe el primer número: ");

                n1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Escribe el segundo número: ");

                n2 = Convert.ToInt32(Console.ReadLine());

                resultado = n1 * n2;

                Console.WriteLine("El resultado de la multiplicación es: {0} ", resultado);

            }catch (Exception error)
            {
                /* error.Message: Devuelve el mensaje de error que explica el motivo de la expepcion  o una cadena vacia  */

                Console.WriteLine("Ha ocurrido un error: {0}", error.Message);

            }
           

            Console.ReadKey();




        }
    }
}
