public class Producto : Paint
{
    // Atributos privados
    private string codigoProducto;   // Código del producto.
    private string nombreProducto;   // Nombre del producto.
    private double precio;           // Precio del producto.

    // Constructor de la clase Producto. Inicializa el código, nombre y precio del producto.
    public Producto(string codigoProducto, string nombreProducto, double precio)
    {
        this.codigoProducto = codigoProducto;   // Inicializa el código del producto.
        this.nombreProducto = nombreProducto;   // Inicializa el nombre del producto.
        this.precio = precio;                   // Inicializa el precio del producto.
    }

    // Método que obtiene o establece el código del producto.
    public string CodigoProducto
    {
        get { return codigoProducto; }
        set { codigoProducto = value; }
    }

    // Método que obtiene o establece el nombre del producto.
    public string NombreProducto
    {
        get { return nombreProducto; }
        set { nombreProducto = value; }
    }

    // Método que obtiene o establece el precio del producto.
    public double Precio
    {
        get { return precio; }
        set { precio = value; }
    }

    // Método que convierte los datos del producto en un diccionario con pares clave-valor.
    public Dictionary<string, object> ToDictionary()
    {
        // Retorna un diccionario que contiene el código, nombre y precio del producto.
        return new Dictionary<string, object>
        {
            { "CodigoProducto", codigoProducto },
            { "NombreProducto", nombreProducto },
            { "Precio", precio }
        };
    }

    // Método que devuelve los datos del producto en formato JSON.
    public string ToJsonString()
    {
        // Retorna un string formateado en JSON con los datos del producto.
        return '{' + $"CodigoProducto: {codigoProducto}, NombreProducto: {nombreProducto}, Precio: {precio}" + '}';
    }
}
