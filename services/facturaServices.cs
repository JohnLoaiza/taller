// Capa de Lógica de Negocio
using System.Collections.Generic;

public class FacturaService
{

   static private Factura facturaActual;


    // Método para generar una nueva factura
    public void GenerarFactura()
    {
        Console.Write("Ingrese el número de la factura: ");
        string numeroFactura = Console.ReadLine();
        double number; // Declaración de la variable
        if (double.TryParse(numeroFactura, out number))
        {
            facturaActual = new Factura(numeroFactura, DateTime.Now);
        Console.WriteLine("Factura generada con éxito.");

        }
        else
        {
            Console.WriteLine($"{number} no es un numero de factura válido.");
        }
       
    }

    // Método para agregar un producto a la factura actual
    public void AgregarProductoAFactura()
    {
        if (facturaActual == null)
        {
            Console.WriteLine("No hay una factura activa. Por favor, genere una factura primero.");
            return;
        }

        Console.WriteLine("Seleccione un producto:");
       
        for (int i = 0; i < ProductoRepository.ObtenerProductos().Count; i++)
        {
            Console.WriteLine($"{i + 1}. {ProductoRepository.ObtenerProductos()[i].ToJsonString()}");
        }

        Console.Write("Seleccione el número del producto a agregar: ");
        int index = Convert.ToInt32(Console.ReadLine()) - 1;

        if (index < 0 || index >= ProductoRepository.ObtenerProductos().Count)
        {
            Console.WriteLine("Selección inválida.");
            return;
        }

        Console.Write("Ingrese la cantidad: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        var productoFactura = new ProductoFactura(ProductoRepository.ObtenerProductos()[index], cantidad);
        facturaActual.AgregarProducto(productoFactura);
        Console.WriteLine("Producto agregado a la factura.");
    }

    // Método para ver la factura actual
    public void VerFacturaActual()
    {
        if (facturaActual == null)
        {
            Console.WriteLine("No hay una factura activa.");
            return;
        }

        Console.WriteLine("----- Factura Actual -----");
        facturaActual.PaintFactura();
    }
}
