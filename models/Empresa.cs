
public class Empresa : Paint
{
    private string nombre;
    private string codigo;

    public Empresa(string nombre, string codigo)
    {
        this.nombre = nombre;
        this.codigo = codigo;
    }

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public string Codigo
    {
        get { return codigo; }
        set { codigo = value; }
    }

    public Dictionary<string, object> ToDictionary()
    {
        return new Dictionary<string, object>
    {
        { "Código", codigo },
        { "Nombre", nombre },
    };
    }

    public string ToJsonString()
    {
        return '{' + $"Código: {codigo}, Nombre: {nombre}" + '}';
    }
}
