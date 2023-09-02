// See https://aka.ms/new-console-template for more information
using ConsoleApp2;

Usuario usuario = new Usuario("htorrico", 10000);
Empleado empleado = new Empleado("ssssss", 10000, 150);
Cliente cliente = new Cliente("gggggg", 10000, 100);

List<Usuario> usuarios = new List<Usuario> { usuario, empleado};

Grifos a = new Grifos(usuarios);

bool exit = false;

while (!exit)
{
    Console.WriteLine("<----- HELLO COSTUMER ------>");
    Console.WriteLine("1. Mostrar informacion de usuarios");
    Console.WriteLine("2. Agregar cliente");
    Console.WriteLine("3. Agregar empleado");
    Console.WriteLine("4. Salir");
    Console.Write("Elige una opción: ");

    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            a.MostrarUsuarios(a.Grifo);
            break;
        case "2":
            Console.WriteLine("Agregar cliente: ");
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Saldo: ");
            if (double.TryParse(Console.ReadLine(), out double saldo))
            {
                Console.Write("Sueldo: ");
                if (double.TryParse(Console.ReadLine(), out double sueldo))
                {
                    Cliente nuevoCliente = new Cliente(nombre, saldo, sueldo);
                    usuarios.Add(nuevoCliente);

                    Console.WriteLine("Cliente agregado con éxito.");
                }
                else
                {
                    Console.WriteLine("El sueldo debe ser un número válido.");
                }
            }
            else
            {
                Console.WriteLine("El saldo debe ser un número válido.");
            }
            break;
        case "3":
            Console.WriteLine("Agregar empleado: ");
            Console.Write("Nombre: ");
            string nombreEmpleado = Console.ReadLine();

            Console.Write("Saldo: ");
            if (double.TryParse(Console.ReadLine(), out double saldoEmpleado))
            {
                Console.Write("Sueldo: ");
                if (double.TryParse(Console.ReadLine(), out double sueldoEmpleado))
                {
                    Empleado nuevoEmpleado = new Empleado(nombreEmpleado, saldoEmpleado, sueldoEmpleado);
                    usuarios.Add(nuevoEmpleado);
                    Console.WriteLine("Empleado agregado con éxito.");
                }
                else
                {
                    Console.WriteLine("El sueldo debe ser un número válido.");
                }
            }
            else
            {
                Console.WriteLine("El saldo debe ser un número válido.");
            }
            break;
        case "4":
            exit = true;
            Console.WriteLine("¡Bye!");
            break;
        default:
            Console.WriteLine("Opción inválida. Por favor, elige una opción válida.");
            break;

    }
}

    Console.Read();