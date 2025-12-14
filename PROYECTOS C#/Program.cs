using System;

// Definición de la clase Estudiante
class Estudiante
{
    // Atributos
    public int ID;
    public string Nombres;
    public string Apellidos;
    public string Direccion;
    public string[] Telefonos; // Array de teléfonos

    // Método para mostrar los datos
    public void MostrarDatos()
    {
        Console.WriteLine("\n===== DATOS DEL ESTUDIANTE =====");
        Console.WriteLine("ID: " + ID);
        Console.WriteLine("Nombres: " + Nombres);
        Console.WriteLine("Apellidos: " + Apellidos);
        Console.WriteLine("Dirección: " + Direccion);
        Console.WriteLine("Teléfonos:");

        for (int i = 0; i < Telefonos.Length; i++)
        {
            Console.WriteLine("Teléfono " + (i + 1) + ": " + Telefonos[i]);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear el objeto estudiante
        Estudiante estudiante = new Estudiante();

        // Ingreso de datos
        Console.Write("Ingrese el ID del estudiante: ");
        estudiante.ID = int.Parse(Console.ReadLine());

        Console.Write("Ingrese los nombres: ");
        estudiante.Nombres = Console.ReadLine();

        Console.Write("Ingrese los apellidos: ");
        estudiante.Apellidos = Console.ReadLine();

        Console.Write("Ingrese la dirección: ");
        estudiante.Direccion = Console.ReadLine();

        // Inicializar el array de teléfonos
        estudiante.Telefonos = new string[3];

        for (int i = 0; i < estudiante.Telefonos.Length; i++)
        {
            Console.Write("Ingrese el teléfono " + (i + 1) + ": ");
            estudiante.Telefonos[i] = Console.ReadLine();
        }

        // Mostrar los datos ingresados
        estudiante.MostrarDatos();

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}
