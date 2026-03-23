// See https://aka.ms/new-console-template for more information

Dictionary<int, Estudiante> estudiante = new Dictionary<int, Estudiante>();
int opcion;
do
{
    Console.Clear();
    Console.WriteLine("1. Registrar estudiante");
    Console.WriteLine("2. Buscar estudinate");
    Console.WriteLine("3. Listado de estudiantes");
    Console.WriteLine("0. salir");
    Console.WriteLine("Elija una opcion");
    opcion=int.Parse(Console.ReadLine());

    switch (opcion)
        {
        case 1:
            Console.Write("Cuantos estudiantes desea ingresar?:_");
            int n=int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            { 
                Estudiante e=new Estudiante();  
                    Console.WriteLine($"Estudiante: {i+1}");
                Console.Write("Ingrese carnet:_");
                int carnet=int.Parse(Console.ReadLine());
                if (!estudiante.ContainsKey(carnet))
                {
                    Console.Write("Ingrese nombre del estudiante:_ ");
                    e.nombre = Console.ReadLine();
                    Console.Write("Ingrese la carrera:_ ");
                    e.carrera = Console.ReadLine();
                    Console.Write("Nota final del estudiante:_");
                    e.nota = double.Parse(Console.ReadLine());

                    estudiante.Add(carnet, e);
                }
                else
                {
                    Console.WriteLine("Carnet ya exixtente");
                }   
            }
            Console.WriteLine("Registrado con exito");
            Console.ReadKey();
            break;
            case 2:
            Console.WriteLine("Buscar estudiante");
            Console.Write("Ingrese Carnet:_ ");
            int BuscarCarnet=int.Parse(Console.ReadLine());

            if (estudiante.ContainsKey(BuscarCarnet))
            {
                Console.WriteLine("EStudiante encontrado");
                estudiante[BuscarCarnet].MostrarDatos();
            }
            else
            {
                Console.WriteLine("No existe estudiante registrado");
            }

            Console.ReadKey();

            break;
            case 3:
            Console.WriteLine("Listado de estudiantes registrados");
            foreach (KeyValuePair<int, Estudiante>item in estudiante)
            {
                Console.WriteLine($"Carnet:_ {item.Key}");
                item.Value.MostrarDatos();
                
            }
            Console.ReadKey();
            break;
            case 0:
            Console.WriteLine("Feliz día!");
            Console.ReadKey();
            break;
        default:
            Console.WriteLine("Opcion no valida");
            break;

    }



}
while (opcion!=0);





public class Estudiante
{
   
    public string nombre;
    public string carrera;
    public double nota;

    public string VerificarAprovacion()
    {
        if (nota >=61)
        {
            return "Aprobado";
        }

        else 
        {
            return "Reprobado"; 
        }

        

    }
    public void MostrarDatos()
    {
        Console.WriteLine($"Nombre del estudiante:_ {nombre}");
        Console.WriteLine($"Carrera:_ {carrera}");
        Console.WriteLine($"Estado:_ {VerificarAprovacion()}");
    }



}



 