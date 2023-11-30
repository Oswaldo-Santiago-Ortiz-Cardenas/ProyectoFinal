using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Program
    {
        static string[] productos = new string[100];
        static double[] precios = new double[100];
        static int[] cantidades = new int[100];
        static int totalProductos = 0;
        static string[] almacenes = new string[100];
        static int totalAlmacenes = 0;

        static void Main()
        {
            while (true)
            {
                MostrarMenuPrincipal();
                int opcionPrincipal = ObtenerOpcion(1, 3);

                switch (opcionPrincipal)
                {
                    case 1:
                        GestionarProductos();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                        break;
                }
            }
        }

        static void MostrarMenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("==================================================");
            Console.WriteLine("||                                              ||");
            Console.WriteLine("||      Sistema de Inventario \"Mi Tiendita\"     ||");
            Console.WriteLine("||                                              ||");
            Console.WriteLine("==================================================");
            Console.WriteLine("|| 1. Gestionar Productos                       ||");
            Console.WriteLine("|| 2. Gestionar Almacenes                       ||");
            Console.WriteLine("|| 3. Agregar y Extraer Productos               ||");
            Console.WriteLine("==================================================");
            Console.WriteLine("Seleccione una opción y presione Enter:");
        }

        static void GestionarProductos()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=========================================");
                Console.WriteLine("||  Gestionar Productos - Mi Tiendita  ||");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("|| 1. Agregar Producto                 ||");
                Console.WriteLine("|| 2. Eliminar Producto                ||");
                Console.WriteLine("|| 3. Modificar Producto               ||");
                Console.WriteLine("|| 4. Mostrar Inventario               ||");
                Console.WriteLine("|| 5. Volver al Menú Principal         ||");
                Console.WriteLine("=========================================");
                Console.WriteLine("Seleccione una opción:");

                int opcionProductos = ObtenerOpcion(1, 5);

                switch (opcionProductos)
                {
                    case 1:
                        AgregarProducto();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                        break;
                }
            }
        }

        static void AgregarProducto()
        {
            Console.Clear();
            Console.WriteLine("==========================================");
            Console.WriteLine("----- Pantalla para Agregar Producto -----");
            Console.WriteLine("==========================================");
            Console.WriteLine("Ingrese el nombre del producto:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el precio del producto:");
            double precio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad del producto:");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            // Agregar el producto a los arrays
            productos[totalProductos] = nombre;
            precios[totalProductos] = precio;
            cantidades[totalProductos] = cantidad;
            totalProductos++;

            Console.WriteLine("Confirmación: Producto agregado exitosamente.");
            Console.ReadLine();
        }
        static int ObtenerOpcion(int min, int max)
        {
            int opcion;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out opcion) && opcion >= min && opcion <= max)
                {
                    return opcion;
                }
                else
                {
                    Console.WriteLine($"Por favor, ingrese un número entre {min} y {max}.");
                }
            }
        }
    }
}
