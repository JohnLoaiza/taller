public class Cliente : Persona
{
    // Atributo privado que representa el crédito del cliente.
    private double credito;

    // Constructor de la clase Cliente. Inicializa los atributos heredados de Persona y el atributo crédito.
    public Cliente(string codigo, string nombre, string telefono, double credito, string email)
        : base(codigo, nombre, telefono, email)  // Llamada al constructor de la clase base (Persona)
    {
        this.credito = credito;  // Inicializa el atributo crédito.
    }

    // Propiedad que obtiene o establece el crédito del cliente.
    public double Credito
    {
        get { return credito; }
        set { credito = value; }
    }

    // Método que devuelve los datos del cliente en formato JSON (sobrescribe el método de Persona).
    public new string ToJsonString()
    {
        // Llama al método ToJsonString de la clase base e incluye el crédito del cliente.
        return '{' + base.ToJsonString() + $", Credito: {credito}" + '}';
    }

    // Método que convierte los datos del cliente en un diccionario con pares clave-valor (sobrescribe el método de Persona).
    public new Dictionary<string, object> ToDictionary()
    {
        // Llama al método ToDictionary de la clase base y añade el atributo crédito.
        base.ToDictionary().Add("Credito", credito);
        return base.ToDictionary();
    }
}
