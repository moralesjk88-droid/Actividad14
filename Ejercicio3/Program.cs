// See https://aka.ms/new-console-template for more information

List<Empleado> empleados = new List<Empleado>();

Console.WriteLine("¿Cuántos empleados desea registrar?");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Empleado e = new Empleado();
    Console.WriteLine($"\n Empelado {i + 1} ");
    Console.Write("Nombre:_ ");
    e.nombre = Console.ReadLine();
    Console.Write("Puesto:_");
    e. puesto=(Console.ReadLine());
    Console.Write("Salario Mensual:_");
    e.SalarioMensual = double.Parse(Console.ReadLine());
    empleados.Add(e);
}


    Console.WriteLine("\n LISTADO DE EMPLEADO");
    foreach (Empleado e in empleados)
    {
        e.MostrarDatos();
       

    }
   


public class Empleado
{
    public string nombre;
    public string puesto;
    public double SalarioMensual;


    public double CalcularSalarioMensual()
    {
        return SalarioMensual * 12;
    }
    public double CalcularBono()
    {
        if (SalarioMensual >=500)

            return SalarioMensual*0.20;

        else if (SalarioMensual>=3000)
        {
            return SalarioMensual * 0.10;   
        }
        else
        return SalarioMensual*0.05;

    }

    public string ClasificarSalario()
    {
        if (SalarioMensual>=5000)
        {
            return "Salario alto";
        }
        else if (SalarioMensual>=3000)
        {
            return "Salario medio";
        }
        else
        {
            return "Salario bajo";

        }
    }
    public void MostrarDatos()
    {
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Puesto: {puesto}");
        Console.WriteLine($"Salario mensual: {SalarioMensual}");
        Console.WriteLine($"Salario anual: {CalcularSalarioMensual():F2}");
        Console.WriteLine($"Bono: {CalcularBono():F2}");
        Console.WriteLine($"Clasificación: {ClasificarSalario()}");
        Console.WriteLine("-----------------------------------");
    }

}
