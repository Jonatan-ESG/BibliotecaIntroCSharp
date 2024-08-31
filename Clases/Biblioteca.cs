using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Clases
{
    class MiBiblioteca
    {
        private List<Libro> Libros;

        public MiBiblioteca()
        {
            Libros = new List<Libro>();
        }

        public void AgregarLibro(Libro libro)
        {
            Libros.Add(libro);
            Console.WriteLine($"Libro {libro.Titulo} agregado a la biblioteca");
        }

        public void AgregarLibro(string titulo, string autor, int? anioPublicacion = null, string? isbn = null)
        {
            if(anioPublicacion.HasValue && isbn != null)
            {
                Libro nuevoLibro = new Libro(titulo, autor, anioPublicacion, isbn);
                Libros.Add(nuevoLibro);
            }
            else if(anioPublicacion.HasValue)
            {
                Libro nuevoLibro = new Libro(titulo, autor, anioPublicacion);
                Libros.Add(nuevoLibro);
            }
            else if(isbn != null)
            {
                Libro nuevoLibro = new Libro(titulo, autor, isbn: isbn);
                Libros.Add(nuevoLibro);
            }
            else
            {
                Libro nuevoLibro = new Libro(titulo, autor);
                Libros.Add(nuevoLibro);
            }
        }

        public void ListarLibros() { 
            Console.WriteLine("Libros disponibles en la biblioteca:");
            foreach (Libro libro in Libros) {
                Console.WriteLine(libro.ObtenerInformacion());
            }
        }
    }
}
