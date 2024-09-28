// Capa de Lógica de Negocio
using System.Collections.Generic;

public class FacturaService
{
    // Variable estática privada para almacenar la factura actual en uso.
    static private Factura facturaActual;

    // Método para generar una nueva factura.
    public void GenerarFactura()
    {
        Console.Write("Ingrese el número de la factura: ");
        string numeroFactura = Console.ReadLine();  // Leer el número de factura ingresado por el usuario.
        
        double number; // Declaración de la variable para verificar si el número es válido.
        
        // Verificar si el número de factura ingresado es un número válido.
        if (double.TryParse(numeroFactura, out number))
        {
            // Crear una nueva instancia de Factura con el número y la fecha actual.
            facturaActual = new Factura(numeroFactura, DateTime.Now);
            Console.WriteLine("Factura generada con éxito.");  // Mensaje de confirmación.
        }
        else
        {
            // Mensaje de error si el número de factura no es válido.
            Console.WriteLine($"{numeroFactura} no es un número de factura válido.");
        }
    }

    // Método para agregar un producto a la factura actual.
    public void AgregarProductoAFactura()
    {
        // Comprobar si hay una factura activa.
        if (facturaActual == null)
        {
            Console.WriteLine("No hay una factura activa. Por favor, genere una factura primero.");
            return;  // Salir del método si no hay factura activa.
        }

        Console.WriteLine("Seleccione un producto:");
        
        // Mostrar la lista de productos disponibles.
        for (int i = 0; i < ProductoRepository.ObtenerProductos().Count; i++)
        {
            Console.WriteLine($"{i + 1}. {ProductoRepository.ObtenerProductos()[i].ToJsonString()}");  // Mostrar información de cada producto.
        }

        Console.Write("Seleccione el número del producto a agregar: ");
        int index = Convert.ToInt32(Console.ReadLine()) - 1;  // Leer la selección del usuario y ajustar el índice.

        // Comprobar si la selección es válida.
        if (index < 0 || index >= ProductoRepository.ObtenerProductos().Count)
        {
            Console.WriteLine("Selección inválida.");  // Mensaje de error si la selección no es válida.
            return;  // Salir del método.
        }

        Console.Write("Ingrese la cantidad: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());  // Leer la cantidad del producto a agregar.

        // Crear un nuevo objeto ProductoFactura y agregarlo a la factura actual.
        var productoFactura = new ProductoFactura(ProductoRepository.ObtenerProductos()[index], cantidad);
        facturaActual.AgregarProducto(productoFactura);
        Console.WriteLine("Producto agregado a la factura.");  // Confirmar que el producto se ha agregado.
    }

    // Método para ver la factura actual.
    public void VerFacturaActual()
    {
        // Comprobar si hay una factura activa.
        if (facturaActual == null)
        {
            Console.WriteLine("No hay una factura activa.");  // Mensaje si no hay factura actual.
            return;  // Salir del método.
        }

        // Mostrar la factura actual.
        Console.WriteLine("----- -------------- -----");
        Console.WriteLine("----- Factura Actual -----");
        facturaActual.PaintFactura();  // Llamar al método para mostrar la factura.
    }
}
