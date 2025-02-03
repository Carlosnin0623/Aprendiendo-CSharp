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
            float calificacion;
            byte dias;
            try
            {
                Console.WriteLine("Digite la calicación: ");
                calificacion = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Digite los dias de asitencia del alumno: ");
                dias = Convert.ToByte(Console.ReadLine());

                if (calificacion >= 7.0 && dias >= 20)
                {
                    Console.WriteLine("¡Has aprobado el curso!");
                }
                else
                {
                    Console.WriteLine("Lo siento, reprobaste el curso");
                    Console.WriteLine("Ingresaste la calificación {0} y la asistencia {1}", calificacion, dias);
                }
            }catch (Exception error)
            {
                Console.WriteLine("Ha ocurrido un error: {0}", error.Message);
            }
           

            Console.ReadKey();
        }
        
    }
}
