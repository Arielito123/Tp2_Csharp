using System;

namespace Ejercicio10
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*nformar un listado con los números primos que hay entre el 5 y el 200 uno debajo del
            otro.*/


            int ban = 0, num, x;
            for (num = 5; num <= 200; num++) //analizo los numeros del 5 al 200
            {
                for (x = 2; x <= num - 1; x++) // busco si tiene divisores
                {
                    if (num % x == 0)
                    {
                        ban = 1; // encontre un dividsor!!!!
                    }
                }
                if (ban == 0)
                {
                    Console.Write(num + "\n"); // informo que es primo
                }
                else
                {
                    ban = 0; // reinicio la bandera
                }
            }






            Console.ReadKey();
        }
    }
}
