// Capa de Acceso a Datos
using System.Collections.Generic;

public class ProductoRepository
{
  static  private List<Producto> productos = new List<Producto>(); // Simulación de una base de datos

 static   public void AgregarProducto(Producto producto)
    {
        productos.Add(producto);
    }

  static  public List<Producto> ObtenerProductos()
    {
        return productos;
    }

    
}
