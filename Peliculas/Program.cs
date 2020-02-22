using System;

namespace Peliculas
{
    class Peliculas
    {
        public string Titulo;
        public Int16 año;
        public string Pais;
        public string Director;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Peliculas pel= new Peliculas();


            pel.Titulo = "De aqui a la eternidad";
            pel.año = 1953;
            pel.Pais = "Estados Unidos";
            pel.Director = "Fred Zinnemann";
            Console.WriteLine("Peliculas: {0}, año{1}, Pais{2}, Director{3}", pel.Titulo, pel.año, pel.Pais, pel.Director);
        }
    }
}
