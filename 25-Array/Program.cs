using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Arreglos (Arrays)

             Un array es un indicador que puede almacenar varios valores simultaneamente.
            Cada uno de estos valores se identifica mediante un número al cual llama indice.
            Asi, para acceder al primer elemento del array habria que usar el indice 0, para
            el segundo el indice 1, para el tercero el indice 2 y asi sucesivamente.


            Grupo de variables


            Sirven para almacenar datos por ejemplo de un colegio que desee guardar la edad
            de los alumnos.


              Tipos de arreglos

                Arreglos de una dimension
                Arreglos de dos dimenciones
                Arreglos de tipo Jagged (Un arreglo es arreglo de arreglos)
                Arreglos como parametros a metodos


               Arreglos (Arrays) de una dimencion

                 Declaracion 

                 tipo[] nombre = new tipo[tamaño]


                 Ejemplo de calificacions

                 float[] calificaciones = new float[10];

                 Instanciación: proceso de leer o especificar información, como los valores
                 y el tipo de almacenamiento de un campo de datos.
                
             */

            int cantidad, n;

            float suma = 0.0f;

            float promedio = 0.0f;

         //   float minima = 10.0f;

         //   float maxima = 0.0f;

            Console.WriteLine("Ingresa calificaciones de los alumnos");
            cantidad = Convert.ToInt32(Console.ReadLine());

            float[] cali = new float[cantidad];

            for(n = 0; n < cantidad; n++)
            {
                Console.WriteLine("Ingrese calificacion");
                cali[n] = Convert.ToSingle(Console.ReadLine());

            }

            for(n = 0; n < cantidad; n++)
            {
                suma += cali[n];
            }

            promedio = suma / cantidad;




        }
    }
}
