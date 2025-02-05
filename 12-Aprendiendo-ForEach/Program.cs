using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Aprendiendo_ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*  ForEach Es el indicado cuando queremos recorrer cadenas o arrays, solamente
             * 
             *  char letra: Las variables tipo char solo ocupan 1 byte de espacio y son 
             *  muy ultiles para recorrer string y ahorrar recursos del procesador
             *  
             *  ForEach: significa por cada elemento o letra en caso de que sea una variable
             *  de tipo string realiza lo siguiente
             *  
             *  Console.Write: Pone en una misma linea todo el contenido este no lo separa 
             *  como hace Console.WriteLine() que por cada elemento hace un salto de linea.
             */

            string nombre = "Academia de Ciencia";

            // Ejemplo forEach trabajando con Cadenas o tipo string

            foreach (char letra in nombre)
            {
                 // Esta es la forma correcta de devolver un string con forEach
                Console.Write(letra);
            }

            Console.ReadKey();
        }
    }
}
