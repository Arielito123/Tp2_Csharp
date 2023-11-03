using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Informar por pantalla los número pares en forma regresiva desde el 5000 al 4500 
inclusive separados por una /*/

            for (int i = 5000; i >= 4500; i = i - 2)
            {
                Console.Write("/" + i);
            }

            Console.ReadKey();
        }
    }
}
