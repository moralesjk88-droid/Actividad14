// See https://aka.ms/new-console-template for more information

List<Pedido> pedidos= new List<Pedido>();

Console.WriteLine("¿Cuántos pedidos desea registrar?");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Pedido e = new Pedido();
 
    Console.WriteLine($"\n Pedido {i + 1} ");
    Console.Write("Nombre del cliente:_ ");
    e.cliente= Console.ReadLine();
    Console.Write("Producto:_");
    e.producto=(Console.ReadLine());
    Console.Write("Precio unitario:_");
    e.precio = double.Parse(Console.ReadLine());
    Console.Write("Cantidad:_");
    e.cantidad = double.Parse(Console.ReadLine());
    pedidos.Add(e);
}

double totalGenera = 0;
  
    
    Console.WriteLine("\n LISTADO DE PEDIDOS");
    foreach (Pedido e in pedidos)
    {
        e.MostraarDatos();
    totalGenera += e.CalcularTotal();
      
    }
Console.WriteLine($"\nTOTAL GENERAL: {totalGenera:F2}");


public class Pedido
{
    public string cliente;
    public string producto;
    public double precio;
    public double cantidad;

    
    public double CalcularsubtotalTotal()
    {
        return (precio*cantidad);
    }
    public double CostoEnvio()
    {
        double subtotal=CalcularsubtotalTotal();    
        if (subtotal >100)

            return 0;

        if (subtotal>50)
        {
            return subtotal * 0.10;
        }
        
        else

            return subtotal *0.20;

    }
    public double CalcularTotal()
    {
        return CalcularsubtotalTotal()+CostoEnvio();
    }
    public void MostraarDatos()
    {
        Console.WriteLine($"Cliente: {cliente}");
        Console.WriteLine($"Producto: {producto}");
        Console.WriteLine($"Precio: {precio:F2}");
        Console.WriteLine($"Cantidad: {cantidad}");
        Console.WriteLine($"Subtotal: {CalcularsubtotalTotal():F2}");
        Console.WriteLine($"Costo envío: {CostoEnvio():F2}");
        Console.WriteLine($"Total: {CalcularTotal():F2}");
    }

}
