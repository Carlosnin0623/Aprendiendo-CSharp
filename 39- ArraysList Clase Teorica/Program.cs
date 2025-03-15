using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39__ArraysList_Clase_Teorica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Colecciones
             *  Las colecciones son estructuras de datos que nos permiten guardar en
             *  su interior cualquier tipo de información. Existen diferentes tipos 
             *  de colecciones y la forma en como se guarda, se accede y se elimina
             *  la información en cada una de ellas.
             *  
             *  Tipos de Colecciones:
             *  
             *  ArrayList
             *  
             *  Hashtable
             *  
             *  Queue
             *  
             *  Stack
             *  
             *  También trabajaremos nuevamente con el ciclo foreach
             *  
             *  
             *  ArrayList:
             *  
             *  Guarda la informacion como si fuera una lista y sobre esta lista es posible
             *  realizar diferentes actividades con los elementos almacenados.
             *  
             *  Puede cambiar su tamaño según lo necesitemos.
             *  
             *  Es una clase de C# por lo que va a tener metodos para poder trabajar los datos.
             *  
             *  Propiedades:
             *  
             *     Capacidad: indica el tamaño que ocupa la lista.
             *     conteo: indica cuando elementos están guardados en su interior.
             *     
             *     
             *  Debemos usar el Namespace System.Collections, el cual nos va a permitir
             *  trabajar con colecciones
             *  
             *   Declaracion de ArrayList:
             *   
             *      ArrayList datos = new ArrayList();
             *      
             *      Si conocemos la cantidad de elementos que vamos a almacenar se lo pasamos
             *      como parametros a la estructura o clase como vemos aqui
             *      
             *        ArrayList datos = new ArrayList(32);
             *        
             *    Métodos ArrayList
             *    
             *    Add(): Este metodo va a necesitar de un unico parametro y este es el dato
             *    que queremos guardar, enteros, variables, cadenas, etc, ejemplo:
             *    
             *    datos.Add(7) = Dato tipo entero
             *    
             *    datos.Add(7) = Guardamos una variable
             *      
             *    datos.Add("Hola") = Guardar una cadena
             *  
             *    Accder a los elementos: Podemos acceder a los elemetos del ArrayList mediante
             *    su indice ejemplo  ArrayList datos = new ArrayList(1);
             *    
             *    datos.add(3);
             *    
             *    accediendo al elemento
             *    Console.WriteLine("El resultado es {0}", datos[0]);
             *    
             *    
             *    Obtener la cantidad de elemento de un ArrayList
             *    
             *    Para obtener la cantidad de elementos podemos hacer uso de la propiedad count
             *    
             *    int elemntos = datos.count
             *    
             *    Insertar elemtos dentro de un ArrayList
             *    
             *    Insert(): El metodo insert permite añadir elementos en cualquier parte del ArrayList
             *    
             *    Si deseamos insertar el valor 5 en el indice 2, hacemos lo siguiente
             *    
             *    datos.insert(2,5) Asi inserto el valor 5 en el indice 2 y entonces el array
             *    se expadira y el valor que existia en esa posicion ahora estara en el indice 3
             *    
             *    
             *    
             *    
             */


        }
    }
}
