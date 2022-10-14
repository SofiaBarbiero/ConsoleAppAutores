// See https://aka.ms/new-console-template for more information
using Entidades;
using Negocio;

Console.WriteLine("BIBLIOTECA FABRICARG");

Servicio gestor = new Servicio();
List<Autor> lstAutor = gestor.ObtenerAutores();

Console.WriteLine("Los autores disponibles son:");

foreach(Autor autor in lstAutor)
{
    Console.WriteLine("Nombre completo: " + autor.Nombre + ", " + autor.Apellido
        + " | Pais de nacimiento: " + autor.PaisNac);
}


