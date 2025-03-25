using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_Stack_Clase_teorica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             *  Colecciones: Stack o Pila
             *  
             *  Permiteme guardar elementos y cambia su tamaño de forma
             *  dinamica, sin embargo trabaja en forma diferente al arreglo 
             *  y al ArrayList
             *  
             *  Estructura de tipo LIFO Lastin-first-out (El primero que entra
             *  es el ultimo en salir)
             *  
             *  Metodos comunes en las colecciones Stack
             *  
             *   Push: Para Colocar nuevos elementos en la parte superior de la pila
             *   Pop: Para tomar elementos de una parte superior del stack usamos 
             *   el metodo pop
             *   
             *   Como crear la instancia 
             *   
             *   Stack miPila = new Stack()
             *   
             *   Introducir informacion al stack
             *   
             *   Para introducir valores dentro del stack usamos el metodo push
             *   
             *   miPila.Push(7);
             *   miPila.Push(11);
             *   miPila.Push(8);
             *   
             *   Obtener informacion del Stack metodo Pop
             *   
             *   Este metodo toma el elemento que se encuentra en la parte superior del 
             *   Stack. Este metodo no necesita ningun parametro y regresa el elemento
             *   correspondiente
             *   
             *   int valor = 0;
             *   
             *   valor = (int)miPila.Pop();
             *   
             *   
             *   Obtener la cantidad de elementos de un Stack
             *   
             *   Usando el metodo Count del Stack. El uso es equivalente al ArrayList.
             *   
             *   cantidad = miPila.Count;
             *   
             *   Eliminar todos los elementos del stack
             *   
             *   Clear: Este metodo permite eliminar todos los elementos del stack
             *   
             *   miPila.Clear();
             *   
             *   Metodo Contains
             *   
             *   Para saber si el stack contiene algun elemento: Usar el metodo Contains().
             *   
             *   Este metodo necesita de un parametro que es el objeto a encontrar dentro del stack
             *   
             *   El metodo regresa un valor de tipo bool. Si el objeto se encuentra el valor 
             *   es true, pero si no se encuentra es false.
             *   
             *   bool enStack = false;
             *   
             *   enStack = miPila.Constains(7);
             *   
             *   
             *   
             *  
             *  
             * 
             */
        }
    }
}
