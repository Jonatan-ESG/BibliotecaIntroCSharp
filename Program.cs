﻿
using Biblioteca.Clases;

namespace Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la biblioteca");

            Libro unMundoFeliz = new Libro("Un mundo feliz", "Aldous Huxley"); 

            Console.WriteLine(unMundoFeliz.ObtenerInformacion());

            MiBiblioteca miBiblioteca =  new MiBiblioteca();

            miBiblioteca.AgregarLibro(unMundoFeliz);

            miBiblioteca.AgregarLibro("Orgullo y prejuicio", "Jane Austen");

            miBiblioteca.ListarLibros();
            
        }
    }
}
