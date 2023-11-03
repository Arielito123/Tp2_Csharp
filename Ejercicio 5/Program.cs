using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se ingresan las edades de 10 (diez) personas, informar la edad promedio


            int edad, suma = 0, ContEdad = 0, promedio = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Ingrese una edad edad");
                edad = int.Parse(Console.ReadLine());

                ContEdad++;
                suma = suma + edad;


            }

            promedio = suma / ContEdad;

            Console.WriteLine("La edad promedio es de :" + promedio);
            Console.ReadKey();
        }
    }
}
