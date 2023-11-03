using System;

namespace Ejercicio8
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*Dado un número entero (x) y su exponente (y) ingresados por el usuario, elevar el
número al exponente indicado por acumulación de su producto.*/


            double x, y, potencia= 1;

            Console.WriteLine("Ingrese una base");
            x = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un exponente para su base");
            y = double.Parse(Console.ReadLine());



            for (int i = 1; i <= y; i++)
            {

                potencia =potencia*x;

              
               
                 }

            Console.WriteLine("El resultado es :" + potencia);
            Console.ReadKey();
        }
    }
}
