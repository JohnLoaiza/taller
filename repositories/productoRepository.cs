// Capa de Acceso a Datos
using System.Collections.Generic;

public class ProductoRepository
{
    // Lista estática privada que simula una base de datos de productos.
    static private List<Producto> productos = new List<Producto>();

    // Método estático para agregar un nuevo producto a la "base de datos".
    static public void AgregarProducto(Producto producto)
    {
        productos.Add(producto);  // Agrega el producto a la lista de productos.
    }

    // Método estático para obtener la lista de todos los productos.
    static public List<Producto> ObtenerProductos()
    {
        return productos;  // Retorna la lista de productos.
    }
}
