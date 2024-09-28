public class Empresa : Paint
{
    // Atributos privados
    private string nombre;  // Nombre de la empresa.
    private string codigo;  // Código único de la empresa.

    // Constructor que inicializa la empresa con su nombre y código.
    public Empresa(string nombre, string codigo)
    {
        this.nombre = nombre;  // Inicializa el nombre de la empresa.
        this.codigo = codigo;  // Inicializa el código de la empresa.
    }

    // Propiedad para obtener o establecer el nombre de la empresa.
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    // Propiedad para obtener o establecer el código de la empresa.
    public string Codigo
    {
        get { return codigo; }
        set { codigo = value; }
    }

    // Método que convierte los atributos de la empresa en un diccionario con pares clave-valor.
    public Dictionary<string, object> ToDictionary()
    {
        return new Dictionary<string, object>
        {
            { "Código", codigo },  // Agrega el código de la empresa al diccionario.
            { "Nombre", nombre },  // Agrega el nombre de la empresa al diccionario.
        };
    }

    // Método que devuelve los datos de la empresa en formato JSON-like.
    public string ToJsonString()
    {
        return '{' + $"Código: {codigo}, Nombre: {nombre}" + '}';  // Formatea los datos como una cadena similar a JSON.
    }
}
