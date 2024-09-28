public class Vendedor : Persona
{
    private int carnet;
    private string direccion;

    // Constructor
    public Vendedor(string codigo, string nombre, string telefono, int carnet, string email,string direccion)
        : base(codigo, nombre, telefono, email)
    {
        this.carnet = carnet;
        this.direccion = direccion;
    }

    // Getter y Setter para el atributo adicional
    public int Carnet
    {
        get { return carnet; }
        set { carnet = value; }
    }

    public string Direccion
    {
        get { return direccion; }
        set { direccion = value; }
    }


     public new string ToJsonString()
    {
        return '{' + base.ToJsonString() + $", Carnet: {carnet}, Direccion: {direccion}" + '}';
    }

     public new Dictionary<string, object> ToDictionary()
    {
        base.ToDictionary().Add("Carnet", carnet);
        base.ToDictionary().Add("Direccion", direccion);
         return base.ToDictionary();
    }
}
