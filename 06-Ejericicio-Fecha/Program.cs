using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Ejericicio_Fecha
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime AñoAcutal, FechaNacimiento;

            int resultado;

            Console.WriteLine("Digita tu fecha de nacimiento en formato (YYYY-MM-DD)");
            FechaNacimiento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("La fecha de nacimiento es {0}", FechaNacimiento);

            AñoAcutal = DateTime.Now;

            resultado = Calcular(AñoAcutal, FechaNacimiento);

            Console.WriteLine("Tu edad Actual es {0}", resultado);

            Console.ReadKey();
        }

    static int Calcular(DateTime AñoActual, DateTime FechaNacimiento){

     int edad = (AñoActual.Year - FechaNacimiento.Year);


      if(FechaNacimiento.Date > AñoActual.AddYears(-edad))
     {
         edad--;
     }

     return edad;
     }
    }
}
