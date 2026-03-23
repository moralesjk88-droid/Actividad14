// See https://aka.ms/new-console-template for more information

Dictionary<int, Producto> inventario = new Dictionary<int, Producto>();
int opcion;
do
{
    Console.Clear();
    Console.WriteLine("1. Registrar producto");
    Console.WriteLine("2. Buscar producto");
    Console.WriteLine("3. Listado de producto");
    Console.WriteLine("0. salir");
    Console.WriteLine("Elija una opcion");
    opcion = int.Parse(Console.ReadLine());


    switch(opcion)
    {
        case 1:
            Console.WriteLine("ingreso de productos");
            Console.Write("¿Cuantos productos desea ingresar?:_ ");
            int n=int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Producto e = new Producto();
                Console.WriteLine($"Producto {i + 1}");
                Console.Write("Codigo del producto");
                int codigo=int.Parse(Console.ReadLine());
                if (!inventario.ContainsKey(codigo))
                {
                    Console.Write("Nombre del producto");
                    e.nombre = Console.ReadLine();
                    Console.Write("Precio:_");
                    e.precio=double.Parse(Console.ReadLine());
                    Console.Write("Stock del producto:_ ");
                    e.stock=int.Parse(Console.ReadLine());
                    inventario.Add(codigo, e);

                }
                else
                {
                    Console.WriteLine("Mismo codigo");
                }
               
            } Console.ReadKey();
            break;
            case 2:
            Console.WriteLine("Buscar producto");
            Console.WriteLine("Codigo del producto");
            int BuscarProducto=int.Parse(Console.ReadLine());
            if (inventario.ContainsKey(BuscarProducto))
            {
                Console.WriteLine("\n Producto encontrado");
                inventario[BuscarProducto].MostrarDatos();
            }
            else
            {
                Console.WriteLine("No se encuentra producto");
            }
            Console.ReadKey();
            break;
            case 3:
            Console.WriteLine("Inventario de productos");
            foreach (KeyValuePair<int, Producto> item in inventario)
            {
                Console.WriteLine($"Codigo del producto:_{item.Key}");
                item.Value.MostrarDatos();
            }
            Console.ReadKey();
            break;
            case 0:
            Console.WriteLine("FELIZ DÍA");
            Console.ReadKey();
            break;
            default:
            Console.WriteLine("Opcion no valida");
            break;
    }











}
while (opcion!=0);





public class Producto
{
    public string nombre;
    public double precio;
    public int stock;

    public string VerificarStock()
    {
        if (stock ==0)
        {
            return "Stock agotado"; 
        }

        if (stock <= 50)
        {
            return "Stock bajo";
        }

        else
        {
           return "Stock normal";
        }

    }
    public void MostrarDatos()
    {
        Console.WriteLine($"Nombre del producto:_ {nombre}");
        Console.WriteLine($"Precio del producto:_ {precio:F2}");
        Console.WriteLine($"Stock:_ {stock}");
        Console.WriteLine($"Nivel de stock:_ {VerificarStock()}");
    }



}



