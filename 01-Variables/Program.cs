using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; // namespace predefinido son espacios de nombres ya reservados del lenguaje de programación

namespace _01_Variables // namespace propio
{
    internal class Program // Clase ya que C# es un lenguaje 100% orientado a objetos es necesario usar clases
    {
        static void Main(string[] args)  /* Estos son los métodos o acciones de la clase */
        {

            /* 
               Variables:

               Las variables son espacios que se guardan en la memoria del pc. Y su tamaño dependerá de lo que queremos guardar.

               Para indicarle al pc que deseamos usar una variable. debemos declararla, y para declarar una variable podemos usar:

               Letras Mayúsculas, minúsculas, números y guiones bajos.


               Tipos de Variables 


               String: Cadema de caracteres, letras, números, etc.

               int: Cuando queremos guardar valores numéricos enteros con signo, en el rango de -2,147,483,648 hasta
               2,147,483,647.

               Long: Guarda valores numéricos enteros realmente grandes con un rango desde -9,223,372,036,854,775,808 hasta
               9,223,372,036,854,775,808.

               Short: Guarda valores numéricos enteros, pero su rango es menor y varia desde -32,768 hasta 32,767.

               Byte: Puede guardar un byte de información. Esto equivale a un valor entero positivo entre 0 y 255.

               Decimal: Este tipo puede guardar un valor númerico con decimales. Su rango es desde ±1.0 hasta ±7.9 llevan m al final

               Float: Otro tipo de dato muy utilizado para guardar valores numerico con decimales. Para este tipo el
               rango es desde ±1.5 hasta ±3.4 llevan f al final

               Bool: Es una variable booleana, es decir que solamente puede guardar los valores verdadero o falso (true o false).

               Double: El tipo double en C# representa un número de coma flotante de doble precisión (64 bits), 
               lo que permite almacenar números con decimales de manera eficiente. rango desde -1.7976931348623157E+308 hasta 1.7976931348623157E+308
               se representan con la letra d al final.

               
                
             */

            // Tipo string  //

            string nombre = "Carlos Alberto";

            int numero = 27;

            float estatura = 1.80f; // En las variables de tipo float se debe poner una f al final para indicarle que es de tipo float

            bool casado = false;

            decimal numero2 = 1.5m; // En las variables de tipo decimal se debe poner una m al final para indicarle que es de tipo decimal

            double numero3 = 2.5d; // En las variables de tipo double se debe poner una d al final para indicarle que es de tipo double

            Console.WriteLine("Mi nombre es {0} mi edad es {1} mi estatura es {2} estoy casado {3}", nombre, numero, estatura, casado);
            Console.WriteLine("Número decimal: {0}", numero2);
            Console.WriteLine("Número double: {0}", numero3);
            Console.ReadKey();


        }
    }
}
