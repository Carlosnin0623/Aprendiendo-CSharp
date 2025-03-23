using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _40_Ejercicio_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            int indice, cantidad, capacidad;


            ArrayList datos = new ArrayList();

            datos.Add(7);
            datos.Add(3);
            datos.Add(1);
            Console.WriteLine("Estos son los datos");
            imprime(datos);

            datos.Add(4);
            datos.Add(5);

            indice = datos.Add(10);

            // Obtener el indice 
            Console.WriteLine("Despues de hacer crecer el Array");
            imprime(datos);

            Console.WriteLine("El ultimo elemento tiene el indice {0}", indice);


            // Imprimir un elemento en particular 

            Console.WriteLine("El valor en el indice 2 es: {0}", datos[1]);

            // Modificar dato

            datos[3] = 20;
            Console.WriteLine("Dato ya modificado");
            imprime(datos);

            // Obtener cantidad de elementos count
            cantidad = datos.Count;



            Console.WriteLine("Esta es la cantidad de elementos dentro del la lista {0}", cantidad);
            Console.WriteLine("\n---------------");

            // Obtener el tamaño que ocupa la el ArrayList con Capacity

            capacidad = datos.Capacity;

            Console.WriteLine("La cantidad de elementos que puede poseer el ArrayList es: {0}", capacidad);
            Console.WriteLine("\n---------------");

            // Insertar elementos 

            datos.Insert(2, 50);

            Console.WriteLine("Después de insertar el número nuevo");
            imprime(datos);

            cantidad = datos.Count;

            // Eliminar un elemento

            datos.RemoveAt(6);

            cantidad = datos.Count;

            Console.WriteLine("Esta es la cantidad de elementos despues de la eliminacion {0}", cantidad);
            Console.WriteLine("\n---------------");

            imprime(datos);

            // Encontrar el indice donde se encuentra el 5

            indice = datos.IndexOf(5);

            Console.WriteLine("El valor existe en el indice {0}", indice);


            Console.ReadKey();

        }


        static void imprime(ArrayList arreglo)
        {
            foreach(int i in arreglo)
            {
                Console.Write("{0}", i);
                Console.WriteLine("\n---------------");
            }
        }
    }
}
