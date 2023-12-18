using System;
using System.Collections.Generic;

class Program
{
    static List<string> tareas = new List<string>();

    static void Main()
    {
        Console.WriteLine("Aplicación de Lista de Tareas");

        while (true)
        {
            MostrarMenu();
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    MostrarTareas();
                    break;
                case "2":
                    AgregarTarea();
                    break;
                case "3":
                    EliminarTarea();
                    break;
                case "4":
                    Console.WriteLine("¡Hasta luego!");
                    return;
                default:
                    Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                    break;
            }
        }
    }

    static void MostrarMenu()
    {
        Console.WriteLine("1. Mostrar Tareas");
        Console.WriteLine("2. Agregar Tarea");
        Console.WriteLine("3. Eliminar Tarea");
        Console.WriteLine("4. Salir");
        Console.Write("Selecciona una opción: ");
    }

    static void MostrarTareas()
    {
        Console.WriteLine("Lista de Tareas:");

        if (tareas.Count == 0)
        {
            Console.WriteLine("No hay tareas.");
        }
        else
        {
            for (int i = 0; i < tareas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tareas[i]}");
            }
        }
    }

    static void AgregarTarea()
    {
        Console.Write("Ingrese la nueva tarea: ");
        string nuevaTarea = Console.ReadLine();
        tareas.Add(nuevaTarea);
        Console.WriteLine("Tarea agregada con éxito.");
    }

    static void EliminarTarea()
    {
        MostrarTareas();

        if (tareas.Count == 0)
        {
            return;
        }

        Console.Write("Ingrese el número de la tarea a eliminar: ");
        if (int.TryParse(Console.ReadLine(), out int numeroTarea) && numeroTarea >= 1 && numeroTarea <= tareas.Count)
        {
            tareas.RemoveAt(numeroTarea - 1);
            Console.WriteLine("Tarea eliminada con éxito.");
        }
        else
        {
            Console.WriteLine("Número de tarea no válido.");
        }
    }
}
