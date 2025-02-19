using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Ejercicio_Arreglos_Bidimencionales
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int departamentos;
            int cantidad;
            int n;
            int m;

            Console.WriteLine("Digite la cantidad de departamentos que hay en tu empresa");
            departamentos = Convert.ToInt32(Console.ReadLine());

            string[][] empleados = new string[departamentos][];

            for(n = 0; n < departamentos; n++)
            {
                Console.WriteLine("Digita la cantidad de empleados para el departamento {0}", n + 1);
                cantidad = Convert.ToInt32(Console.ReadLine());

                empleados[n] = new string[cantidad];
            } 

           
            for(n = 0; n < departamentos; n++)
            {
                Console.WriteLine("Este es el departamento número {0}", n + 1);

                 for(m = 0; m < empleados[n].GetLength(0); m++)
                {
                    Console.WriteLine("Digita el nombre del empleado");
                    empleados[n][m] = Console.ReadLine();
                }
            }

            Console.WriteLine("Información");


            for(n = 0; n < departamentos; n++)
            {
                Console.WriteLine("Estos son los empleados del departamento {0}", n + 1);

                for (m = 0; m < empleados[n].GetLength(0); m++)
                {
                    Console.WriteLine("Estos son {0}", empleados[n][m]);
                }
            }

            Console.ReadKey();


        }
    }
}
