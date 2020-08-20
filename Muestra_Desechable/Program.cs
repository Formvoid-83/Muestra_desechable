using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muestra_Desechable
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] peliculas = new string[5];
            Console.WriteLine("Escriba sus pinshes películas favoritas");

            for(int i=0; i <peliculas.Length; i++)
            {
                peliculas[i] = Console.ReadLine();

            }
            Console.WriteLine("\nAhora en orden alfabético:");

            Array.Sort(peliculas);

            for (int i = 0; i < peliculas.Length; i++)
            {
                Console.WriteLine(peliculas[i]);

            }

            Console.ReadKey();
        }
    }
}
