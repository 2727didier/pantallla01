using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pantallla01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                MostrarMenu();
                opcion = ObtenerOpcion();
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Seleccionaste: Gestionar Productos");
                        break;
                    case 2:
                        Console.WriteLine("Seleccionaste: Gestionar Almacenes");
                        break;
                    case 3:
                        Console.WriteLine("Seleccionaste: Agregar y Extraer Productos");
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, selecciona una opción válida.");
                        break;
                }
                Console.WriteLine("\nPresiona cualquier tecla para continuar...");
                Console.ReadKey();
            } while (opcion != 0);
        }
        static void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("==================================================");
            Console.WriteLine("||                                              ||");
            Console.WriteLine("||        Sistema de Inventario \"Mi Tiendita\"   ||");
            Console.WriteLine("||                                              ||");
            Console.WriteLine("==================================================");
            Console.WriteLine("|| 1. Gestionar Productos                       ||");
            Console.WriteLine("|| 2. Gestionar Almacenes                       ||");
            Console.WriteLine("|| 3. Agregar y Extraer Productos               ||");
            Console.WriteLine("==================================================");
            Console.WriteLine("Seleccione una opción y presione Enter:");
        }

        static int ObtenerOpcion()
        {
            int opcion;
            while (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Por favor, ingresa un número válido.");
            }
            return opcion;
        }
    }

}
    

