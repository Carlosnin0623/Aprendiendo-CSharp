using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_Arreglos_Jagged__O_arreglos_dentro_de_arreglos_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Arreglos (Jagged) arreglos en arreglos 
             
               Declaramos arreglo contenedores

                int[][] Costos = new int [3][]; con esto creamos 3 arreglos dentro de un contenedor y cada 1 tendra un tamaño diferente


                Declaramos los arreglos 

                  // Aqui definimos el espacio que tiene cada fila
                  Costos[0] = new int[15];
                  Costos[1] = new int[20];
                  Costos[2] = new int[10];

                   
             
                  int[][] valores = new int[3][];

                 // De esta forma insertamos valores dentro del arreglo
            
                  valores[0] = new int []{9,3,1,7,2,4};
                  valores[1] = new int []{2,9};
                  valores[2] = new int []{3,5,2,9};


                  // De esta forma declaramos en arreglo sin especificarle la cantidad de filas
                  
                  int[][] valores = new int[][]
                  
                    {
                      new int[]{9,3,1,7,2,4}
                      new int[]{2,9};
                      new int []{3,5,2,9};
                    };

                 Acceder a un arreglo jagged

                Para acceder a los elementos guardados adentro de un arreglo jagged 
                tambien necesitamos utilizar indices. un indice sera aplicado para
               indicar cual elemento del arreglo contenedor utilizaremos, es decir
               el número de columna. El otro indice nos indica el elemento del arreglo interno
               que queremos acceder.

                productos[6][7] = 5.7f;

                   
             
             */

            int cantidad = 0;
            int salones = 0;
            int n;
            int m;
            float suma = 0.0f;
            float promedio = 0.0f;
            float minima = 10.0f;
            float maxima = 0.0f;

            Console.WriteLine("Ingrese la cantidad de salones");
            salones = Convert.ToInt32(Console.ReadLine());

            float[][] calif = new float[salones][];

            for(n = 0; n < salones; n++)
            {
                Console.WriteLine("Ingrese cantidad de alumnos para el salon {0}", n);
                cantidad = Convert.ToInt32(Console.ReadLine());

                calif[n] = new float[salones];
            }

            for(n = 0; n < salones; n++)
            {
                Console.WriteLine("Salon {0}", n);

                for(m = 0; m < calif[n].GetLength(0); m++)
                {
                    Console.WriteLine("Ingrese la calificación");
                    calif[n][m] = Convert.ToSingle(Console.ReadLine());
                }
            }

            Console.WriteLine("INFORMACION");

            for(n = 0; n < salones; n++)
            {
                Console.WriteLine("Salon {0}", n);

                for(m = 0; m < calif[n].GetLength(n); m++)
                {
                    Console.WriteLine("El alumno {0} tiene {1}", m, calif[n][m]);
                }
            }

            Console.ReadKey();

            for(n = 0; n < salones; n++)
            {
                for(m = 0; m < calif[n].GetLength(n); m++)
                {
                    suma += calif[n][m];
                } 
            }

            promedio = suma / (salones * cantidad);

            for (n = 0; n < salones; n++)
            {
                for (m = 0; m < calif[n].GetLength(n); m++)
                {
                    if(calif[n][m] < minima)
                    {
                        minima = calif[n][m];
                    }
                }
            }

            for (n = 0; n < salones; n++)
            {
                for (m = 0; m < calif[n].GetLength(n); m++)
                {
                    if (calif[n][m] > maxima)
                    {
                        maxima = calif[n][m];
                    }
                }
            }


            Console.WriteLine("El promedio es: {0}", promedio);
            Console.WriteLine("La calificación maxima es: {0}", maxima);
            Console.WriteLine("La calificación minima es: {0}", minima);
        }
    }
}
