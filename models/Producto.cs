public class Producto : Paint
{
    private string codigoProducto;
    private string nombreProducto;
    private double precio;

    // Constructor
    public Producto(string codigoProducto, string nombreProducto, double precio)
    {
        this.codigoProducto = codigoProducto;
        this.nombreProducto = nombreProducto;
        this.precio = precio;
    }

    // Métodos públicos (Getters y Setters)
    public string CodigoProducto
    {
        get { return codigoProducto; }
        set { codigoProducto = value; }
    }

    public string NombreProducto
    {
        get { return nombreProducto; }
        set { nombreProducto = value; }
    }

    public double Precio
    {
        get { return precio; }
        set { precio = value; }
    }

     public Dictionary<string, object> ToDictionary()
    {
        return new Dictionary<string, object>
    {
        { "CodigoProducto", codigoProducto },
        { "NombreProducto", nombreProducto },
        { "Precio", precio },
    };
    }

    public string ToJsonString()
    {
        return '{' + $"CodigoProducto: {codigoProducto}, nombreProducto: {nombreProducto}, Precio: {precio}" + '}';
    }
}
