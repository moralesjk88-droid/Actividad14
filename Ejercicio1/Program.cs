// See https://aka.ms/new-console-template for more information










public class Estudiante()
{
    public string nombre;
    public int nota1;
    public int nota2;
    public int nota3;

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
    { Console.WriteLine($"Nombre:_ {nombre} | Promedio:_ {CalcularPromedio()} | Estado del estudiante:_ {Estado()} ");
    }

}