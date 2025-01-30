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
            string nombre;
            int edad;
            double estatura;

            Console.WriteLine("Ingrese su nombre: ");

            // ReadLine le pide datos al usuario para almacenarlo en una variable //
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su edad: ");

            edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese su altura: ");

            estatura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Su nombre es: {0} su su edad es: {1} y su estatura es: {2}", nombre, edad, estatura);

            Console.ReadKey();
        }
    }
}
