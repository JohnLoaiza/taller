public class ProductoFactura
{
    private Producto producto;
    private int cantidad;

    public ProductoFactura(Producto producto, int cantidad)
    {
        this.producto = producto;
        this.cantidad = cantidad;
    }

    public Producto GetProducto()
    {
        return producto;
    }

    public int GetCantidad()
    {
        return cantidad;
    }

    public double CalcularSubtotal()
    {
        return producto.Precio * cantidad;
    }

     public Dictionary<string, object> ToDictionary()
    {
        return new Dictionary<string, object>
    {
        { "Producto", producto },
        { "Cantidad", cantidad },
    };
    }

    public string ToJsonString()
    {
        return '{' + $"Producto: {producto}, Cantidad: {cantidad}" + '}';
    }

   
}
