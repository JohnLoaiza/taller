public class Cliente : Persona
{
    private double credito;

    // Constructor
    public Cliente(string codigo, string nombre, string telefono, double credito, string email)
        : base(codigo, nombre, telefono, email)
    {
        this.credito = credito;
    }

    // Getter y Setter para el atributo adicional
    public double Credito
    {
        get { return credito; }
        set { credito = value; }
    }

     public new string ToJsonString()
    {
        return '{' + base.ToJsonString() + $", Credito: {credito}" + '}';
    }

     public new Dictionary<string, object> ToDictionary()
    {
        base.ToDictionary().Add("Credito", credito);
         return base.ToDictionary();
    }
}
