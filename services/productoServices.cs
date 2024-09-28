// Capa de Lógica de Negocio
using System.Collections.Generic;

public class ProductoService
{
    // Método para agregar un producto.
    public void AgregarProducto()
    {
        Console.Write("Ingrese el código del producto: ");
        string codigo = Console.ReadLine();  // Leer el código del producto ingresado por el usuario.
        
        Console.Write("Ingrese el nombre del producto: ");
        string nombre = Console.ReadLine();  // Leer el nombre del producto.

        Console.Write("Ingrese el precio del producto: ");
        string precio = Console.ReadLine();  // Leer el precio del producto como cadena de texto.

        double number; // Declaración de la variable para almacenar el precio como número.
        
        // Verificar si el precio ingresado es un número válido.
        if (double.TryParse(precio, out number))
        {
            // Crear una nueva instancia de Producto con los datos ingresados.
            var producto = new Producto(codigo, nombre, number);
            // Agregar el producto a la "base de datos".
            ProductoRepository.AgregarProducto(producto);
            Console.WriteLine("Producto agregado con éxito.");  // Mensaje de confirmación.
        }
        else
        {
            // Mensaje de error si el precio no es válido.
            Console.WriteLine($"{precio} no es un precio válido.");
        }
    }

    // Método para obtener la lista de productos.
    public List<Producto> ObtenerProductos()
    {
        return ProductoRepository.ObtenerProductos();  // Retornar la lista de productos de la "base de datos".
    }

    // Método para mostrar los productos.
    public void VerProductos()
    {
        Console.WriteLine("----- Productos -----");  // Encabezado de la lista de productos.
        
        // Iterar sobre la lista de productos y mostrar la información de cada uno.
        foreach (var producto in ProductoRepository.ObtenerProductos())
        {
            Console.WriteLine(producto.ToJsonString());  // Mostrar el producto en formato JSON.
        }
    }
}
