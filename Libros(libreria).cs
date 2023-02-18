using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    internal class Libros
    {
        private double isbn;
        private string nombreLibro;
        private string autor;
        private int ejemplares;
        private int prestados;

        
        public Libros()
        {

        }

        public Libros(double isbn, string nombreLibro, string autor, int ejemplares, int prestados)
        {
            this.isbn = isbn;
            this.nombreLibro = nombreLibro;
            this.autor = autor;
            this.ejemplares = ejemplares;
            this.prestados = prestados;
        }

        public double Isbn { get => isbn; set => isbn = value; }
        public string NombreLibro { get => nombreLibro; set => nombreLibro = value; }
        public string Autor { get => autor; set => autor = value; }
        public int Ejemplares { get => ejemplares; set => ejemplares = value; }
        public int Prestados { get => prestados; set => prestados = value; }

        public void AgregarLibro()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("        **AGREGAR LIBRO**        ");
            Console.Write("\tISBN: ");
            Isbn = double.Parse(Console.ReadLine());

            Console.Write("\tNombre del libro: ");
            NombreLibro = Console.ReadLine();

            Console.Write("\tAutor: ");
            Autor = Console.ReadLine();

            Console.Write("\tEjemplares: ");
            Ejemplares = int.Parse(Console.ReadLine());

            Console.Write("\tPrestados: 0\n");
            Console.WriteLine("---------------------------------");
        }

        public void ImprimirLibro()
        {
            Console.WriteLine("_____________________________________");
            Console.WriteLine("         **DATOS DEL LIBRO**         ");
            Console.WriteLine($"\tISBN: {Isbn}");
            Console.WriteLine($"\tNombre del libro: {NombreLibro}");
            Console.WriteLine($"\tAutor: {Autor}");
            Console.WriteLine($"\tEjemplares: {Ejemplares}");
            Console.WriteLine($"\tPrestados: {Prestados}");
            Console.WriteLine("______________________________________\n");
        }

        public void Prestar()
        {
            if (Ejemplares == 0)
            {
                Console.WriteLine("ERROR NO QUEDAN EJEMPLARES");
            }
            else
            {
                Prestados = Prestados + 1;
                Ejemplares = Ejemplares - 1;
            }
            ImprimirLibro();
        }

        public void Devolver()
        {
            if (Prestados == 0)
            {
                Console.WriteLine("ERROR NO HAY LIBROS PRESTADOS AUN");
            }
            else
            {
                Prestados = Prestados - 1;
                Ejemplares = Ejemplares + 1;
            }
            ImprimirLibro();
        }

        public void Consultar()
        {
            Console.WriteLine("_____________________________________");
            Console.WriteLine("         **DATOS DEL LIBRO**         ");
            Console.WriteLine($"\tISBN: {Isbn}");
            Console.WriteLine($"\tNombre del libro: {NombreLibro}");
            Console.WriteLine($"\tAutor: {Autor}");
            Console.WriteLine($"\tEjemplares: {Ejemplares}");
            Console.WriteLine($"\tPrestados: {Prestados}");
            Console.WriteLine("______________________________________\n");
        }
    }
}
