using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Expresiones_Logicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
               Expresiones logicas
                   
                   Operador && significado Y:
                   Se evalua como verdadera unicamente cuando ambas expresiones son verdaderas
                   
                      P  Q   resultado
                      V  V      V
                      F  V      F
                      V  F      F
                      F  F      F
             */

            short tanque_gasolina = 50;
            short recorrido = 400;

            if(tanque_gasolina <= 40 && recorrido >= 400)
            {
                Console.WriteLine("Por favor llena el tanque");
            }
            else if (tanque_gasolina >= 50 && recorrido >= 400)
            {
                Console.WriteLine("Disfruta el viaje");
            }

            bool lluvia = false;
            bool sol = false;

            /* 
             Expresiones logicas

                 Operador || significado O:
                 Se evalua como verdadera cuando almenos 1 sea verdadera

                    P  Q   resultado
                    V  V      V
                    F  V      V
                    V  F      V
                    F  F      F
           */

            if (lluvia == true || sol == true)
            {
                Console.WriteLine("Debes usar sombrilla");
            }
            else
            {
                Console.WriteLine("Puedes salir tranquilamente");
            }

            /* Operador de negación 
             
               Simbolo       Significado      Condición
                  !           Negación        Esto quiere decir que si el operando del lado derecho
                                              es true, el operador regresara false, y si el operando
                                              del lado derecho es false, el operador regresara true


                p            Negacion
               True            False
               False           True
             
             */

              bool dia = false;


            if(!dia == false)
            {
                Console.WriteLine("Es de dia");
            }
            else
            {
                Console.WriteLine("Es de noche");
            }




            Console.ReadKey();
        }
    }
}
