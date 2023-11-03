using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Modificar el ejercicio anterior de manera que se observe en pantalla la siguiente salida:
XXXXXXXXXXXXXXXXXXXXXXXXX
XXXXXXXXXXXXXXXXXXXX
XXXXXXXXXXXXXXX
XXXXXXXXXX
XXXXX*/

            for (int i = 75; i >1; i--)
            {

                if ((i == 50) || (i == 30) || (i == 15) || (i == 5))
               
                {
                    Console.Write("\n");

                }

                Console.Write("X");


            }




            Console.ReadKey();



        }
    }
}
