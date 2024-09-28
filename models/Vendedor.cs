public class Vendedor : Persona
{
    // Atributos privados
    private int carnet;           // Identificación del vendedor.
    private string direccion;     // Dirección del vendedor.

    // Constructor de la clase Vendedor. Inicializa los atributos de Persona y añade carnet y dirección.
    public Vendedor(string codigo, string nombre, string telefono, int carnet, string email, string direccion)
        : base(codigo, nombre, telefono, email)  // Llamada al constructor de la clase base (Persona)
    {
        this.carnet = carnet;       // Inicializa el atributo carnet.
        this.direccion = direccion; // Inicializa el atributo dirección.
    }

    // Propiedad que obtiene o establece el valor del carnet del vendedor.
    public int Carnet
    {
        get { return carnet; }
        set { carnet = value; }
    }

    // Propiedad que obtiene o establece la dirección del vendedor.
    public string Direccion
    {
        get { return direccion; }
        set { direccion = value; }
    }

    // Método que devuelve los datos del vendedor en formato JSON (sobrescribe el método de Persona).
    public new string ToJsonString()
    {
        // Llama al método ToJsonString de la clase base e incluye carnet y dirección del vendedor.
        return '{' + base.ToJsonString() + $", Carnet: {carnet}, Direccion: {direccion}" + '}';
    }

    // Método que convierte los datos del vendedor en un diccionario con pares clave-valor (sobrescribe el método de Persona).
    public new Dictionary<string, object> ToDictionary()
    {
        // Llama al método ToDictionary de la clase base y añade carnet y dirección.
        base.ToDictionary().Add("Carnet", carnet);
        base.ToDictionary().Add("Direccion", direccion);
        return base.ToDictionary();
    }
}
