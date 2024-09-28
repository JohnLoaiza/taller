using System.Reflection.Metadata.Ecma335;

public class Factura : Paint
{
    private string numeroFactura;
    private DateTime fecha;
    private List<ProductoFactura> productos;  // Relación con productos

    // Constructor
    public Factura(string numeroFactura, DateTime fecha)
    {
        this.numeroFactura = numeroFactura;
        this.fecha = fecha;
        productos = new List<ProductoFactura>();
    }

    // Métodos públicos (Getters y Setters)
    public string NumeroFactura
    {
        get { return numeroFactura; }
        set { numeroFactura = value; }
    }

    public DateTime Fecha
    {
        get { return fecha; }
        set { fecha = value; }
    }

    // Métodos para gestionar productos
    public void AgregarProducto(ProductoFactura producto)
    {
        productos.Add(producto);
    }

    public List<ProductoFactura> ObtenerProductos()
    {
        return productos;
    }

    public Dictionary<string, object> ToDictionary()
    {
        return new Dictionary<string, object>
    {
        { "NumeroFactura", numeroFactura },
        { "Fecha", fecha },
        { "Productos", productos },
    };
    }

    public string ToJsonString()
    {
        var init = '{' + $"NumeroFactura: {numeroFactura}, Fecha: {fecha}, Productos:";

        return init;
    }

    public void PaintFactura()
    {
        Console.WriteLine($"Numero de factura: {numeroFactura}----");
        Console.WriteLine($"Fecha: {fecha}-----");
        Console.WriteLine($"-------------------------");
        Console.WriteLine("Cantidad         Producto");
        for (int i = 0; i < productos.Count; i++)
        {
            Console.WriteLine($"{productos[i].GetCantidad()}            {productos[i].GetProducto().NombreProducto}");
        }
        Console.WriteLine($"-------------------------");
        Console.WriteLine("Total: " + TotalFactura());
    }

    public double TotalFactura()
    {
        double count = 0;
        for (int i = 0; i < productos.Count; i++)
        {
            count += productos[i].GetCantidad() * productos[i].GetProducto().Precio;
        }
        return count;
    }
}
