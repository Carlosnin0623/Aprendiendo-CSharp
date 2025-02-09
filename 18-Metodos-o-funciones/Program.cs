using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Metodos_o_funciones
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* 
               Metodos y funciones

               La función o metodo es un elemento del programa que contiene codigo
               y se puede ejecutar, es decir, lleva a cabo una operacion o conjunto
               de instrucciones. La funcion o metodo puede llamarse o invocarse cuando
               sea necesario y entonces el codigo que se encuentra en su interior se 
               va a ejecutar. Una vez que la función termina de ejecutarse el programa
               continua en la sentencia siguiente donde fue llamada.


               Tipos de metodos o funciones 

               Ejecutan solo codigo
               rebiben parametros
               regresan valores
               reciben valores y parametros

             
             */

            Console.WriteLine("Digite el primer número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite el segundo número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            int resultado = sumar(numero1, numero2);

            Console.WriteLine("El resultado de la suma es: {0}", resultado);

            Console.ReadKey();


        }


        static int sumar(int num1, int num2)
        {
            return num1 + num2;
        }



    }
}
