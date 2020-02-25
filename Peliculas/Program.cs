using System;

namespace Class 
{
class Pelicula
{
    private string  titulo;
    private Int16 año;
    private string pais;
    private string director;


    public void settitulo(string titulo)
    {
        this.titulo= titulo;
    }

    public string gettitulo()
    {
        return this.titulo;
    }

    public void setaño(Int16 año)
    {
        this.año=año;
    }
    
    public Int16 getaño()
    {
        return this.año;
    }
  public void setpais(string pais)
    {
        this.pais=pais;
    }
    
    public string getpais()
    {
        return this.pais;
    }
public void setdirector(string director)
    {
        this.director=director;
    }
    
    public string getdirector()
    {
        return this.director;
    }
    
public Pelicula(string titulo, Int16 año, string pais, string director)
{
    this.titulo=titulo;
    this.año=año;
    this.pais=pais;
    this.director=director;
}

public Pelicula()
        {

        }

 

}

class Program
    {
        static void Main(string[] args)
        {
          Pelicula pel1 = new Pelicula();

         pel1.settitulo("De aqui a la eternidad");
          pel1.setaño(1953);
          pel1.setpais("Estados Unidos");
          pel1.setdirector("Fred Zinnemann");

          Console.WriteLine("Pelicula: {0}, Año: {1}, Pais: {2}, Director: {3}", pel1.gettitulo(), pel1.getaño(), pel1.getpais(), pel1.getdirector());

          Pelicula pel2 = new Pelicula();

         pel2.settitulo("Guasón");
          pel2.setaño(2019);
          pel2.setpais("Estados Unidos");
          pel2.setdirector("Todd Phillips");

          Console.WriteLine("Pelicula: {0}, Año: {1}, Pais: {2}, Director: {3}", pel2.gettitulo(), pel2.getaño(), pel2.getpais(), pel2.getdirector());
        }}}