public abstract class Persona: Paint
{
    private string codigo;
    private string nombre;
    private string email;
    private string telefono;

    // Constructor
    public Persona(string codigo, string nombre, string telefono, string email)
    {
        this.codigo = codigo;
        this.nombre = nombre;
        this.telefono = telefono;
        this.email = email;
    }

    // Métodos públicos (Getters y Setters)
    public string Codigo
    {
        get { return codigo; }
        set { codigo = value; }
    }

    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public string Telefono
    {
        get { return telefono; }
        set { telefono = value; }
    }

    public string ToJsonString()
    {
        return $"Código: {codigo}, Nombre: {nombre}, Teléfono: {telefono}";
    }

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
