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
                        GestionarAlmacenes();
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
                        EliminarProducto();
                        break;
                    case 3:
                        ModificarProducto();
                        break;
                    case 4:
                        MostrarInventario();
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
        static void EliminarProducto()
        {
            Console.Clear();
            Console.WriteLine("===========================================");
            Console.WriteLine("----- Pantalla para Eliminar Producto -----");
            Console.WriteLine("===========================================");
            Console.WriteLine("Ingrese el nombre del producto a eliminar:");
            string nombreEliminar = Console.ReadLine();

            // Buscar el producto en los arrays
            int index = Array.IndexOf(productos, nombreEliminar);

            if (index != -1)
            {
                // Eliminar el producto
                for (int i = index; i < totalProductos - 1; i++)
                {
                    productos[i] = productos[i + 1];
                    precios[i] = precios[i + 1];
                    cantidades[i] = cantidades[i + 1];
                }

                totalProductos--;

                Console.WriteLine("Confirmación: Producto eliminado exitosamente.");
            }
            else
            {
                Console.WriteLine("El producto no existe. No se pudo eliminar.");
            }

            Console.ReadLine();
        }

        static void ModificarProducto()
        {
            Console.Clear();
            Console.WriteLine("============================================");
            Console.WriteLine("----- Pantalla para Modificar Producto -----");
            Console.WriteLine("============================================");
            Console.WriteLine("Ingrese el nombre del producto a modificar:");
            string nombreModificar = Console.ReadLine();

            // Buscar el producto en los arrays
            int index = Array.IndexOf(productos, nombreModificar);

            if (index != -1)
            {
                // Modificar el producto
                Console.WriteLine("Ingrese el nuevo precio:");
                precios[index] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese la nueva cantidad:");
                cantidades[index] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Confirmación: Producto modificado exitosamente.");
            }
            else
            {
                Console.WriteLine("El producto no existe. No se pudo modificar.");
            }

            Console.ReadLine();
        }

        static void MostrarInventario()
        {
            Console.Clear();
            Console.WriteLine("============================================");
            Console.WriteLine("----- Pantalla para Mostrar Inventario -----");
            Console.WriteLine("============================================");
            Console.WriteLine("Inventario Actual:");

            for (int i = 0; i < totalProductos; i++)
            {
                Console.WriteLine($"Producto {i + 1}: [{productos[i]}] - Precio: [${precios[i]}] - Cantidad: [{cantidades[i]}]");
            }

            Console.ReadLine();
        }
        static void GestionarAlmacenes()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=========================================");
                Console.WriteLine("||  Gestionar Almacenes - Mi Tiendita  ||");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("|| 1. Agregar Almacén                  ||");
                Console.WriteLine("|| 2. Eliminar Almacén                 ||");
                Console.WriteLine("|| 3. Mostrar Almacenes                ||");
                Console.WriteLine("|| 4. Volver al Menú Principal         ||");
                Console.WriteLine("=========================================");
                Console.WriteLine("Seleccione una opción:");

                int opcionAlmacenes = ObtenerOpcion(1, 4);

                switch (opcionAlmacenes)
                {
                    case 1:
                        AgregarAlmacen();
                        break;
                    case 2:
                        EliminarAlmacen();
                        break;
                    case 3:
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                        break;
                }
            }
        }

        static void AgregarAlmacen()
        {
            Console.Clear();
            Console.WriteLine("=========================================");
            Console.WriteLine("----- Pantalla para Agregar Almacén -----");
            Console.WriteLine("=========================================");
            Console.WriteLine("Ingrese el nombre del nuevo almacén:");
            string nombreAlmacen = Console.ReadLine();

            // Agregar el almacén a los arrays
            almacenes[totalAlmacenes] = nombreAlmacen;
            totalAlmacenes++;

            Console.WriteLine("Confirmación: Almacén agregado exitosamente.");
            Console.ReadLine();
        }

        static void EliminarAlmacen()
        {
            Console.Clear();
            Console.WriteLine("==========================================");
            Console.WriteLine("----- Pantalla para Eliminar Almacén -----");
            Console.WriteLine("==========================================");
            Console.WriteLine("Ingrese el nombre del almacén a eliminar:");
            string nombreEliminar = Console.ReadLine();

            // Buscar el almacén en los arrays
            int index = Array.IndexOf(almacenes, nombreEliminar);

            if (index != -1)
            {
                // Eliminar el almacén
                for (int i = index; i < totalAlmacenes - 1; i++)
                {
                    almacenes[i] = almacenes[i + 1];
                }

                totalAlmacenes--;

                Console.WriteLine("Confirmación: Almacén eliminado exitosamente.");
            }
            else
            {
                Console.WriteLine("El almacén no existe. No se pudo eliminar.");
            }

            Console.ReadLine();
        }

    }
}
