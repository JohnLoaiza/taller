using System.Reflection.Metadata.Ecma335;
using System;
using System.Collections.Generic;

public class Factura : Paint
{
    // Atributos privados
    private string numeroFactura; // Número único que identifica la factura.
    private DateTime fecha;       // Fecha en que se emitió la factura.
    private List<ProductoFactura> productos;  // Lista de productos asociados a la factura.

    // Constructor que inicializa la factura con su número y fecha.
    public Factura(string numeroFactura, DateTime fecha)
    {
        this.numeroFactura = numeroFactura;  // Inicializa el número de factura.
        this.fecha = fecha;                  // Inicializa la fecha de la factura.
        productos = new List<ProductoFactura>(); // Inicializa la lista de productos.
    }

    // Propiedad para obtener o establecer el número de la factura.
    public string NumeroFactura
    {
        get { return numeroFactura; }
        set { numeroFactura = value; }
    }

    // Propiedad para obtener o establecer la fecha de la factura.
    public DateTime Fecha
    {
        get { return fecha; }
        set { fecha = value; }
    }

    // Método para agregar un producto a la lista de productos de la factura.
    public void AgregarProducto(ProductoFactura producto)
    {
        productos.Add(producto);  // Agrega el producto a la lista.
    }

    // Método para obtener la lista de productos de la factura.
    public List<ProductoFactura> ObtenerProductos()
    {
        return productos;  // Retorna la lista de productos.
    }

    // Método para convertir los datos de la factura en un diccionario con pares clave-valor.
    public Dictionary<string, object> ToDictionary()
    {
        return new Dictionary<string, object>
        {
            { "NumeroFactura", numeroFactura },
            { "Fecha", fecha },
            { "Productos", productos },  // Asocia la lista de productos a la clave "Productos".
        };
    }

    // Método para devolver los datos de la factura en formato JSON.
    public string ToJsonString()
    {
        var init = '{' + $"NumeroFactura: {numeroFactura}, Fecha: {fecha}, Productos:";  // Devuelve una cadena JSON-like.
        return init;
    }

    // Método para imprimir la factura en la consola.
    public void PaintFactura()
    {
        Console.WriteLine($"Numero de factura: {numeroFactura}----");  // Imprime el número de la factura.
        Console.WriteLine($"Fecha: {fecha}-----");                     // Imprime la fecha de la factura.
        Console.WriteLine($"-------------------------");
        Console.WriteLine("Cantidad         Producto");                // Imprime encabezado para la lista de productos.
        for (int i = 0; i < productos.Count; i++)                       // Recorre la lista de productos y los imprime.
        {
            Console.WriteLine($"{productos[i].GetCantidad()}            {productos[i].GetProducto().NombreProducto}");
        }
        Console.WriteLine($"-------------------------");
        Console.WriteLine("Total: " + TotalFactura());                  // Imprime el total de la factura.
    }

    // Método que calcula el total de la factura sumando los precios de todos los productos.
    public double TotalFactura()
    {
        double count = 0;
        for (int i = 0; i < productos.Count; i++)  // Recorre la lista de productos y suma los precios.
        {
            count += productos[i].GetCantidad() * productos[i].GetProducto().Precio;
        }
        return count;  // Retorna el total de la factura.
    }
}
