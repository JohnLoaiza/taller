// Capa de Lógica de Negocio
using System.Collections.Generic;

public class ProductoService
{


    // Método para agregar un producto
    public void AgregarProducto()
    {
        Console.Write("Ingrese el código del producto: ");
        string codigo = Console.ReadLine();
        Console.Write("Ingrese el nombre del producto: ");
        string nombre = Console.ReadLine();
        Console.Write("Ingrese el precio del producto: ");
        string precio = Console.ReadLine();
        double number; // Declaración de la variable
        if (double.TryParse(precio, out number))
        {
            var producto = new Producto(codigo, nombre, number);
            ProductoRepository.AgregarProducto(producto);
            Console.WriteLine("Producto agregado con éxito.");

        }
        else
        {
            Console.WriteLine($"{precio} no es un precio válido.");
        }
    }

    public List<Producto> ObtenerProductos()
    {
        return ProductoRepository.ObtenerProductos();
    }

    // Método para ver los productos
    public void VerProductos()
    {
        Console.WriteLine("----- Productos -----");
        foreach (var producto in ProductoRepository.ObtenerProductos())
        {
            Console.WriteLine(producto.ToJsonString());
        }
    }
}
