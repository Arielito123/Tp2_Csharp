using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Informar por pantalla los número impares entre el 1000 y el 1500 separados por un 
            guion.*/

            for (int i = 1001; i <= 1500; i = i + 2)
            {
                Console.Write("-" + i + "Impar");
            }

            Console.ReadKey();
        }
    }
}
