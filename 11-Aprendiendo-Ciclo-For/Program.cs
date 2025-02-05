using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Aprendiendo_Ciclo_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* El ciclo for: Nos ayuda a automatizar tareas repetitivas ya que es un bucle
             * que se ejecuta simpre que la condicion sea verdadera 
             * 
             *  Lo primero que se hace en el buble for es inicializar la variable 
             *  por ejemplo int n = 0, con esto inicializamos la variable.
             *  
             *  Lo segundo es evalular la condición n < = 10, que es lo mismo que 0 <= 10.
             *  
             *  Lo tercera si la condición es verdadera se ejecuta el codigo dentro de las llaves.
             *  
             *  Lo cuarto se incrementa el valor de la variable iniciadora siempre y cuando
             *  la condición sea verdadera, se ejecuta el n++
             * 
             *   for(int n = 0; n <= 10; n++)
             *   {
             *        // Codigo
                  }
           
             */


            // Contar los número del 0 al 10 usando el buble for

            for (int n = 1; n <= 10; n++)
            {
                Console.WriteLine("Voy por el número {0}", n);
            }


            byte calificacion;
            float nota, resultado = 0, contador = 0, promedio;

            Console.WriteLine("Bienvenido al sistemas de calificación: ");

            try
            {
                Console.WriteLine("Digite la cantidad de calificaciones a promediar:");
                calificacion = Convert.ToByte(Console.ReadLine());

                for (byte n = 0; n < calificacion; n++)
                {
                    Console.WriteLine("Introduce la calificación: ");
                    nota = Convert.ToSingle(Console.ReadLine());

                    resultado += nota;

                    contador += 1;
                }

                promedio = resultado / contador;

                Console.WriteLine("La calificación promedio de este alumno es:{0}",Math.Round(promedio));
            }catch (FormatException)
            {
                Console.WriteLine("El formato ingresado no es valido, solo número enteros...");
            }catch (OverflowException)
            {
                Console.WriteLine("Ha sobrepasado el limite, pruebe con un número mas pequeño...");
            }
            






            Console.ReadKey();
        }
    }
}
