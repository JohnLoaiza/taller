public abstract class Persona : Paint
{
    // Atributos privados
    private string codigo;
    private string nombre;
    private string email;
    private string telefono;

    // Constructor de la clase Persona. Inicializa los atributos código, nombre, teléfono y email.
    public Persona(string codigo, string nombre, string telefono, string email)
    {
        this.codigo = codigo;
        this.nombre = nombre;
        this.telefono = telefono;
        this.email = email;
    }

    // Propiedad que obtiene o establece el código de la persona.
    public string Codigo
    {
        get { return codigo; }
        set { codigo = value; }
    }

    // Propiedad que obtiene o establece el correo electrónico de la persona.
    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    // Propiedad que obtiene o establece el nombre de la persona.
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    // Propiedad que obtiene o establece el número de teléfono de la persona.
    public string Telefono
    {
        get { return telefono; }
        set { telefono = value; }
    }

    // Método que devuelve los datos de la persona en formato JSON (como un string).
    public string ToJsonString()
    {
        return $"Código: {codigo}, Nombre: {nombre}, Teléfono: {telefono}";
    }

    // Método que convierte los datos de la persona en un diccionario con pares clave-valor.
    public Dictionary<string, object> ToDictionary()
    {
        return new Dictionary<string, object>
        {
            { "Código", codigo },
            { "Nombre", nombre },
            { "Teléfono", telefono }
        };
    }
}
