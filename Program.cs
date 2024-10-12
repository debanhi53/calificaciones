using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calificaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hola! introduce calificacion: ");

            //declaramos variable y la leemos
            int calificacion = Convert.ToInt32(Console.ReadLine());

            if (calificacion >= 70)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("la calificacion es de " + calificacion + ", aprobatoria");

            }
            else if (calificacion > 50 && calificacion < 70)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("la calificacion es de " + calificacion + ", presentar regularizacion");
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("la calificacion es de " + calificacion + ", reprobado");
            }
             Console.ReadKey();
        }
    }
}