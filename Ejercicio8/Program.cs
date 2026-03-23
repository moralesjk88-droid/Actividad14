// See https://aka.ms/new-console-template for more information

List<Cuenta> cuentas = new List<Cuenta>();
Console.Write("¿Cuántas cuentas desea registrar?: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Cuenta c = new Cuenta();

    Console.WriteLine($"\nCuenta {i + 1}");
    Console.Write("Nombre del titular: ");
    c.titular = Console.ReadLine();

    Console.Write("Saldo inicial: ");
    c.saldo = double.Parse(Console.ReadLine());

    cuentas.Add(c);
}
foreach (Cuenta item in cuentas)
{
    Console.WriteLine($"¿Cuánto desa depositar?{item.titular}");

    Console.WriteLine("Cuanto desea depositar?");
    double depositar=double.Parse(Console.ReadLine());
    item.Depositar(depositar);

    Console.WriteLine("Cuanto dessea retirar?");
    double retirar=double.Parse(Console.ReadLine());
    item.Retirar(retirar);
    }
Console.WriteLine("\nSaldo final");

foreach (Cuenta v in cuentas)
{
    v.MostrarDatos();
}


public class Cuenta
{
    public string titular;
    public double saldo;

    public void Depositar(double monto)
    {
        if (monto > 0)
        {
            saldo += monto;
            Console.WriteLine("Depósito realizado");
        }
        else
        {
            Console.WriteLine("Monto invalido");
        }
    }
    public void Retirar(double monto)
    {
        if (monto <= 0)
        {
            Console.WriteLine("Monto invalido");
        }
        else if (monto > saldo)
        {
            Console.WriteLine("Saldo insuficiente");
        }
        else
        {
            saldo -= monto;
            Console.WriteLine("Retido Realozado");
        }
    }


    public void MostrarDatos()
    {
        Console.WriteLine($"Titular:_{titular}");
        Console.WriteLine($"Saldo:_ {saldo}");
    }
}

