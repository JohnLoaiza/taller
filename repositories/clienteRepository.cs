// Capa de Acceso a Datos
using System.Collections.Generic;

public class ClienteRepository
{
   static private List<Cliente> clientes = new List<Cliente>(); // Simulación de una base de datos

  static  public void AgregarCliente(Cliente cliente)
    {
        clientes.Add(cliente);
    }

  static  public List<Cliente> ObtenerClientes()
    {
        return clientes;
    }
}
