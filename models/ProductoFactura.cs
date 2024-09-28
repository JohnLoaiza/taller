public class ProductoFactura
{
    // Atributos privados
    private Producto producto;   // El producto asociado a esta línea de factura.
    private int cantidad;        // La cantidad de productos en esta línea de factura.

    // Constructor de la clase ProductoFactura. Inicializa los atributos producto y cantidad.
    public ProductoFactura(Producto producto, int cantidad)
    {
        this.producto = producto;   // Inicializa el producto asociado a la factura.
        this.cantidad = cantidad;   // Inicializa la cantidad de productos.
    }

    // Método que devuelve el producto asociado a esta línea de factura.
    public Producto GetProducto()
    {
        return producto;
    }

    // Método que devuelve la cantidad de productos en esta línea de factura.
    public int GetCantidad()
    {
        return cantidad;
    }

    // Método que calcula el subtotal de esta línea de factura, multiplicando el precio del producto por la cantidad.
    public double CalcularSubtotal()
    {
        return producto.Precio * cantidad;  // Retorna el precio total de los productos en la factura.
    }

    // Método que convierte los datos de la línea de factura en un diccionario con pares clave-valor.
    public Dictionary<string, object> ToDictionary()
    {
        // Retorna un diccionario que contiene el producto y la cantidad.
        return new Dictionary<string, object>
        {
            { "Producto", producto },
            { "Cantidad", cantidad }
        };
    }

    // Método que devuelve los datos de la línea de factura en formato JSON.
    public string ToJsonString()
    {
        // Retorna un string formateado en JSON con los datos del producto y la cantidad.
        return '{' + $"Producto: {producto}, Cantidad: {cantidad}" + '}';
    }
}
