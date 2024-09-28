// Capa de Acceso a Datos
using System.Collections.Generic;

public class FacturaRepository
{
    // Lista estática privada que simula una base de datos de facturas.
    static private List<Factura> facturas = new List<Factura>();

    // Método estático para agregar una nueva factura a la "base de datos".
    static public void AgregarFactura(Factura factura)
    {
        facturas.Add(factura);  // Agrega la factura a la lista de facturas.
    }

    // Método estático para obtener la lista de todas las facturas.
    static public List<Factura> ObtenerFacturas()
    {
        return facturas;  // Retorna la lista de facturas.
    }
}
