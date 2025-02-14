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

            byte cantidad;
            float promedio;
            float suma = 0;
            float min = 10.0f;
            float max = 0.0f;

            Console.WriteLine("Digita la cantidad de estudiantes ");
            cantidad = Convert.ToByte(Console.ReadLine());

            float[] calificacion = new float[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Digita la calificación");
                calificacion[i] = Convert.ToSingle(Console.ReadLine());
            }

            for(int i = 0; i < calificacion.Length; i++)
            {
                suma += calificacion[i];
            }

            promedio = suma / cantidad;

            Console.WriteLine("El promedio fue: {0}", promedio);

          
            for(int i = 0; i < calificacion.Length; i++)
            {
                if (calificacion[i] <  min)
                {
                    min = calificacion[i];

                }
                
            }


            for (int i = 0; i < calificacion.Length; i++)
            {
                if (calificacion[i] > max)
                {
                    max = calificacion[i];

                }

            }

            Console.WriteLine("La calificacion mas baja es: {0}", min);
            Console.WriteLine("La calificacion mas alta es: {0}", max);

            Console.ReadKey();

        }
    }
}
