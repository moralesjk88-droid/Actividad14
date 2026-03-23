// See https://aka.ms/new-console-template for more information

List<Curso> cursos = new List<Curso>();

Console.WriteLine("¿Cuántos cursos desea registrar?");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Curso e = new Curso();
    Console.WriteLine($"\n Curso {i + 1} ");
    Console.Write("Nombre del curso:_ ");
    e.nombre = Console.ReadLine();
    Console.Write("Creditos del curso:_");
    e.creditos = double.Parse(Console.ReadLine());
    Console.Write("Nota promedio del curso:_");
    e.notaProm = double.Parse(Console.ReadLine());
    
    cursos.Add(e);
}

if (cursos.Count > 0)
{
    Curso mejor = cursos[0];
    Console.WriteLine("\n LISTADO DE CURSOS");
    foreach (Curso e in cursos)
    {
        e.MostraarDatos();
       
        if (e.notaProm > mejor.notaProm)
        {
            mejor = e;
        }

    }
    Console.WriteLine("Mejor Curso");
    mejor.MostraarDatos();
}
else
{
    Console.WriteLine("No se ha registrado curso");
}


public class Curso
{
    public string nombre;
    public double creditos;
    public double notaProm;



    public string Estado()
    {
        if (notaProm >= 80)
        {
            return "Excelente";
        }
        else if (notaProm >= 61)
        {
            return "Aceptable";
        }
        else
        {
            return "Bajo";
        }
    }
    public void MostraarDatos()
    {
        Console.WriteLine($"Nombre:_ {nombre}");
        Console.WriteLine($"Creditos:_ {creditos}");
        Console.WriteLine($"Nota Promedio:_ {notaProm}");
        Console.WriteLine($"Rendimiento del curso:_ {Estado()}");
    }

}