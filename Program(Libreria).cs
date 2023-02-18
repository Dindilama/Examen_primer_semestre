using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayLibros;

            int opcion = 0;

            Libros libro1 = new Libros();

            while (opcion != 6)
            {
                Console.WriteLine("**************************************************");
                Console.WriteLine("---------- Seleccione la opcion deseada ----------");
                Console.WriteLine("1. Agregar Libro _________________________________");
                Console.WriteLine("2. Consultar Libro _______________________________");
                Console.WriteLine("3. Prestar Libro__________________________________");
                Console.WriteLine("4. Devolver Libro_________________________________");
                Console.WriteLine("5. Imprimir Datos Del Libro ______________________");
                Console.WriteLine("6. Finalizar operacion ___________________________");
                Console.WriteLine("**************************************************");
                Console.WriteLine("**************************************************");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        libro1.AgregarLibro();
                        break;
                    case 2:
                        libro1.Consultar();
                        break;
                    case 3:
                        libro1.Prestar();
                        break;
                    case 4:
                        libro1.Devolver();
                        break;
                    case 5:
                        libro1.ImprimirLibro();
                        break;
                    case 6:
                        Console.WriteLine("Desea finalizar?");
                        break;
                }
            }
       
            Console.WriteLine("\nPresione la tecla Enter para finalizar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }
}
