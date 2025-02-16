using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Bidimencionales
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Los arreglos Bidimencionales 


              Permite organizar valores en filas y columnas

              Conocidos como matrices


              Usamos dos indices o posiciones (el de filas y el de columna )

               Arreglo unidemncional:

               [1,2,3,4,5,6,7,8,9]

               Arreglo Bidimencional:

                |1 2 3| Fila
                |4 5 6|  
                |7 8 9|
                     Columna

               Declaracion de los arregtos de 2 dimenciones

                float[,] tabla = new floart[5,3] Declaracion con valores definidos

                float[,] tabla = new floart[m,n] Declaracion de variables

                
             */

            int cantidad = 0;

            int salones = 0;

            int n = 0;

            int m = 0;

            float suma = 0.0f;

            float promedio = 0.0f;

            float minima = 10.0f;

            float maxima = 0.0f;

            Console.WriteLine("Ingrese la cantidad de salones");
            salones = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de alumnos");
            cantidad = Convert.ToInt32(Console.ReadLine());

            // Salones = Columna 
            // Cantidad = filas

            float[,] cali = new float[salones, cantidad];


            for(n = 0; n < salones; n++)
            {
                Console.Write("Salon {0}", n);


                for(m = 0; m < cantidad; m++)
                {
                    Console.WriteLine("Digita la calificacion: ");
                    cali[n,m] = Convert.ToSingle(Console.ReadLine());
                }
            }


            for(n = 0; n < salones; n++) // Ciclo salones
            {
                for(m = 0; m < cantidad; m++) // ciclo alumnos
                {
                    suma += cali[n, m];
                }
            }

            promedio = suma / (cantidad * salones);


            for(n = 0; n < salones; n++)
            {
                for(m = 0; m < cantidad; m++)
                {
                    if (cali[n,m] < minima)
                    {
                        minima = cali[n, m];
                    }
                }
            }

            for (n = 0; n < salones; n++)
            {
                for (m = 0; m < cantidad; m++)
                {
                    if (cali[n, m] > maxima)
                    {
                        maxima = cali[n, m];
                    }
                }
            }

            Console.WriteLine("El promedio es: {0}", promedio);
            Console.WriteLine("La calificación mínima es: {0}", minima);
            Console.WriteLine("La calificación máxima es: {0}", maxima);

            Console.ReadKey();

        }
    }
}
