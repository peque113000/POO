using System;
using System.Collections.Generic;

namespace ListaPeliculas
{
    class Peli
    {
        public string nombre;
        
        public void imprime(){
            Console.WriteLine("({0})",nombre);
        }

        public Peli(string p){
            nombre=p;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Peli> Pelis= new List<Peli>();
            Pelis.Add(new Peli("De aqui a la eternidad"));
            Pelis.Add(new Peli("Guason"));
            Pelis.Add(new Peli("Cadena de favores"));
            Pelis.Add(new Peli("Toy Stori 4"));
            Pelis.Add(new Peli("Judy"));
            
            foreach(Peli p in Pelis)
            p.imprime();
        }
    }
}