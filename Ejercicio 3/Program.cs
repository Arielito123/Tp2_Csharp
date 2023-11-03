using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Informar por pantalla la siguiente figura utilizando ciclos de repetición. El salto de línea 
se genera con el carácter “\n”:
XXXXX
XXXXXXXXXX
XXXXXXXXXXXXXXX
XXXXXXXXXXXXXXXXXXXX
XXXXXXXXXXXXXXXXXXXXXXXXX*/

            for (int i = 1; i < 75; i++)
            {


                if ((i == 5) || (i == 15) || (i == 30) || (i == 50))
                {
                    Console.Write("\n");

                }

                Console.Write("X");

            }


            Console.ReadKey();




        }
    }
}
