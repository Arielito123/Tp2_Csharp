using System;

namespace Ejercicio9
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*Diseñar un algoritmo que permita determinar si un número ingresado por el usuario es
            primo.*/

            int num, cuenta = 0;

            Console.WriteLine("Ingrese un numero");
            num = int.Parse(Console.ReadLine());

                for (int i= 1;i <=num; i++)
            {

                if (num %i == 0)
                    {

                        cuenta++;

                    }
            }


            if (cuenta == 2) 
            {
                Console.WriteLine("es Primo");
            }

            else 
            {

                Console.WriteLine("No es primo");
            }

            Console.ReadLine();

        }
    
    
    
    }
}
