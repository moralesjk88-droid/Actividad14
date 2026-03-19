// See https://aka.ms/new-console-template for more information

List<Estudiante>estudiantes = new List<Estudiante>();

Console.WriteLine("¿Cuántos estudiantes desea registrar?");
int n=int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Estudiante e = new Estudiante();
    Console.WriteLine($"\n EStudiante {i + 1} ");
    Console.Write("Nombre:_ "); 
        e.nombre = Console.ReadLine();
    Console.Write("Nota 1:_");
     e.nota1= double.Parse(Console.ReadLine());
    Console.Write("Nota 2:_");
    e.nota2 = double.Parse(Console.ReadLine());
    Console.Write("Nota 3:_");
    e.nota3 = double.Parse(Console.ReadLine());
    estudiantes.Add(e);
}

if (estudiantes.Count > 0)
{
    double sumaPromedios = 0;
    Estudiante mejor = estudiantes[0];
    Console.WriteLine("\n LISTADO DE ESTUDIANTES");
    foreach (Estudiante e in estudiantes)
    {
        e.MostraarDatos();
        sumaPromedios += e.CalcularPromedio();
        if (e.CalcularPromedio() > mejor.CalcularPromedio())
        {
            mejor = e;
        }

    }
    Console.WriteLine($"\nPromedio general del grupo: {sumaPromedios / estudiantes.Count:F2}");
    Console.WriteLine("Mejor estudiante");
    mejor.MostraarDatos();
}
else
{
    Console.WriteLine("No se ha registrado estudiante");
}


public class Estudiante
{
    public string nombre;
    public double nota1;
    public double nota2;
    public double nota3;

    public double CalcularPromedio()
    {
        return (nota1+nota2+nota3)/3;
    }
    public string Estado()
    {
        if (CalcularPromedio() >= 61)
        {
            return "Aprobado";
        }
        else
        {
            return "Repobado";
        }
    }
     public void MostraarDatos()
    { Console.WriteLine($"Nombre:_ {nombre} | Promedio:_ {CalcularPromedio():F2} | Estado del estudiante:_ {Estado()} ");
    }

}