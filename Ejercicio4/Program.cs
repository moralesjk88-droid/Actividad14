// See https://aka.ms/new-console-template for more information

List<Libro> libros = new List<Libro>();

Console.WriteLine("¿Cuántos libros desea registrar?");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
   Libro e = new Libro();
    Console.WriteLine($"\n Libro {i + 1} ");
    Console.Write("Nombre:_ ");
    e.nombre = Console.ReadLine();
    Console.Write("Autor");
    e.autor = Console.ReadLine();
    Console.Write("Categoria:_");
    e.categoria = (Console.ReadLine());
    Console.Write("Número de paginas:_");
    e.NumeroPagina = int.Parse(Console.ReadLine());
    libros.Add(e);
}
if (libros.Count > 0)
{

    Console.WriteLine("\n LISTADO DE LIBROS");
    Libro mayor = libros[0];
    foreach (Libro e in libros)
    {
        e.MostrarDatos();

        if (e.NumeroPagina > mayor.NumeroPagina)
        {
            mayor= e;
        }
    }
    Console.WriteLine("Libro con mas paginas");
    mayor.MostrarDatos();
}
else
{
    Console.WriteLine("No se ha registrado libro");
}


public class Libro
{
    public string nombre;
    public string autor;
    public string categoria;
    public int NumeroPagina;




    public string Clasificarlibro()
    {
        if (NumeroPagina >= 500)
        {
            return "Libro Extenso";
        }
        else if (NumeroPagina>=200)
        {
            return "Libro mediano";
        }
        else
        {
            return "Libro corto";

        }
    }
    public void MostrarDatos()
    {
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Autor: {autor}");
        Console.WriteLine($"Categoria: {categoria}");
        Console.WriteLine($"Número de paginas: {NumeroPagina}");
        Console.WriteLine($"Clasificación: {Clasificarlibro()}");
        Console.WriteLine("-----------------------------------");
    }

}
