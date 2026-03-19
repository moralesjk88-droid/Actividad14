// See https://aka.ms/new-console-template for more information

List<Producto> productos = new List<Producto>();

Console.WriteLine("¿Cuántos productos desea registrar?");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
Producto e = new Producto();
Console.WriteLine($"\n Producto {i + 1} ");
Console.Write("Nombre:_ ");
e.nombre = Console.ReadLine();
Console.Write("Precio:_");
e.precio = double.Parse(Console.ReadLine());
Console.Write("Cantidad:_");
e.cantidad = double.Parse(Console.ReadLine());
productos.Add(e);
}

if (productos.Count > 0)
{
double sumaPromedios = 0;
Producto mejor = productos[0];
Console.WriteLine("\n LISTADO DE PRODUCTOS");
foreach (Producto e in productos)
{
e.MostraarDatos();
sumaPromedios += e.CalcularValorTotal();
if (e.CalcularValorTotal() > mejor.CalcularValorTotal())
{
mejor = e;
}

}
Console.WriteLine($"\nValor total de inventario: {sumaPromedios / productos.Count:F2}");
Console.WriteLine("Producto con mayor precio");
mejor.MostraarDatos();
}
else
{
Console.WriteLine("No se ha registrado estudiante");
}


public class Producto
{
    public string nombre;
    public double precio;
    public double cantidad;
    

    public double CalcularValorTotal()
    {
        return (precio + cantidad)/2;
    }
    public string Estado()
    {
        if (cantidad <5)
        
            return "Stok Bajo";

        else  

            return "Stok Alto";
        
    }
    public void MostraarDatos()
    {
        Console.WriteLine($"Nombre:_ {nombre} | Promedio de precio:_ {CalcularValorTotal():F2} | Estado del producto:_ {Estado()} ");
    }

}
