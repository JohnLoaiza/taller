using System;
using System.Collections.Generic;

class Program
{

    private static ProductoService productoService = new ProductoService();
    private static ClienteService clienteService = new ClienteService();
    private static FacturaService facturaService = new FacturaService();
    static void Main()
    {
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("----- Menú -----");
            Console.WriteLine("1. Agregar Producto");
            Console.WriteLine("2. Ver Productos");
            Console.WriteLine("3. Agregar Cliente");
            Console.WriteLine("4. Ver Clientes");
            Console.WriteLine("5. Generar Factura");
            Console.WriteLine("6. Agregar Producto a la Factura");
            Console.WriteLine("7. Ver Factura Actual");
            Console.WriteLine("8. Guardar factura1");
             Console.WriteLine("9. Salir");
            Console.Write("Seleccione una opción: ");

            var opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    productoService.AgregarProducto();
                    break;
                case "2":
                    productoService.VerProductos();
                    break;
                case "3":
                    clienteService.AgregarCliente();
                    break;
                case "4":
                    clienteService.VerClientes();
                    break;
                case "5":
                   facturaService.GenerarFactura();
                    break;
                case "6":
                 facturaService.AgregarProductoAFactura();
                    break;
                case "7":
                  facturaService.VerFacturaActual();
                    break;
                case "8":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    break;
            }

            Console.WriteLine();
        }
    }

}
