// See https://aka.ms/new-console-template for more information

List<Venta> ventas = new List<Venta>();
Console.WriteLine("Ventas");
Console.Write("\nCuantas ventas desea ingresar?:_ ");
int n=int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    Venta v=new Venta();
    Console.WriteLine($"Venta {i + 1}");
    Console.Write("Nombre del producto:_ ");
    v.nombre = Console.ReadLine();
    Console.Write("Precio:_ ");
    v.precio=double.Parse(Console.ReadLine());
    Console.Write("Cantidad vendida:_ ");
    v.cantidad=double.Parse(Console.ReadLine());
    ventas.Add(v);

}
double totalGeneral = 0;

Console.WriteLine("Detalle de ventas");

foreach (Venta v in ventas)
{
    v.MostrarDatos();
    totalGeneral += v.CalcularTotal();
}
Console.WriteLine($"\nTotal general vendido {totalGeneral:f2} ");






public class Venta
{
    public string nombre;
    public double precio;
    public double cantidad;


    public double CalcularSubtotal()
    {
        return precio * cantidad;
    }
    public double CalcularDescuentos()
    {
        double Subtotal = CalcularSubtotal();
        if (Subtotal >= 300)

            return Subtotal * 0.20;

        if (Subtotal >= 100)
        {
            return Subtotal* 0.10;
        }
        else
            return 0;

    }

    public double CalcularTotal()
    {
        double total = 0;
        total= CalcularSubtotal() - CalcularDescuentos();
        return total;
    }
    public void MostrarDatos()
    {
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Precio: {precio:f2}");
        Console.WriteLine($"Cantidad: {cantidad}");
        Console.WriteLine($"Subtotal: {CalcularSubtotal():F2}");
        Console.WriteLine($"Descuento: {CalcularDescuentos():F2}");
        Console.WriteLine($"total: {CalcularTotal():f2}");
        Console.WriteLine("-----------------------------------");
    }

}
