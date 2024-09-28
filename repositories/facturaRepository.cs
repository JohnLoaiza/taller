// Capa de Acceso a Datos
using System.Collections.Generic;

public class FacturaRepository
{
   static private List<Factura> facturas = new List<Factura>(); // Simulación de una base de datos

   static public void AgregarFactura(Factura factura)
    {
        facturas.Add(factura);
    }

   static public List<Factura> ObtenerFacturas()
    {
        return facturas;
    }
}
