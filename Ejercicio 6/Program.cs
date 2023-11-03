using System;
using static System.Console;

namespace Ejercicio6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*Desarrollar un algoritmo que permita ingresar la estatura de 15 personal, al finalizar
Informar la cantidad de personas que miden entre 1,60 y 1,80 metros inclusive y la
estatura promedio.*/

            float est,cont=0,sumador = 0,prom = 0;

            for (int i = 1; i <= 15; i++)
            {
                WriteLine("Ingrese la estatura" + i);
                est = float.Parse(Console.ReadLine());


                if ((est>=160)&&(est <= 180))
                {

                    sumador = sumador + est;//variable sumador que me suma las estaturas
                    cont++;//contador para que cuente cuantas alturas hay en ese rango



                }


               
            }

            Console.WriteLine("La cantidad de personas entre 1.60 y 1.80 Metros es  de " + cont + " Personas ");

            prom = sumador/cont;//sumador/contador para sacar el promedio de estatura en ese rango

            Console.WriteLine("El promedio de las estaturas entre 1.60 y 1.80 Metros es de:" + prom + " Metros ");

            Console.ReadKey();

        }
    }
}
