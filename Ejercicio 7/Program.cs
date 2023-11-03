using System;

namespace Ejercicio7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Dado un número entero positivo calcular e informar su factorial.

            int numero,fac=1;

            Console.WriteLine("Digite un numero");
            numero = int.Parse(Console.ReadLine());


            for (int i= 1;i<=numero; i++) 
            {

                fac = fac * i;
              
               
                 }

            Console.WriteLine("El Factorial de tu numero es:" + fac);

        }
    }
}
