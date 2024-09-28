// Capa de Acceso a Datos
using System.Collections.Generic;

public class ClienteRepository
{
    // Lista estática privada que simula una base de datos de clientes.
    static private List<Cliente> clientes = new List<Cliente>();

    // Método estático para agregar un nuevo cliente a la "base de datos".
    static public void AgregarCliente(Cliente cliente)
    {
        clientes.Add(cliente);  // Agrega el cliente a la lista de clientes.
    }

    // Método estático para obtener la lista de todos los clientes.
    static public List<Cliente> ObtenerClientes()
    {
        return clientes;  // Retorna la lista de clientes.
    }
}
