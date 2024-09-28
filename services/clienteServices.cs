// Capa de Lógica de Negocio
using System.Collections.Generic;

public class ClienteService
{
    // Método para agregar un nuevo cliente a la base de datos.
    public void AgregarCliente()
    {
        // Solicitar información del cliente al usuario.
        Console.Write("Ingrese el código del cliente: ");
        string codigo = Console.ReadLine();  // Leer el código del cliente.
        
        Console.Write("Ingrese el nombre del cliente: ");
        string nombre = Console.ReadLine();  // Leer el nombre del cliente.
        
        Console.Write("Ingrese el teléfono del cliente: ");
        string telefono = Console.ReadLine();  // Leer el teléfono del cliente.
        
        Console.Write("Ingrese el credito del cliente: ");
        double credito = Convert.ToDouble(Console.ReadLine());  // Leer el crédito del cliente y convertir a double.
        
        Console.Write("Ingrese el email del cliente: ");
        string email = Console.ReadLine();  // Leer el email del cliente.

        // Crear una nueva instancia de Cliente con la información proporcionada.
        var cliente = new Cliente(codigo, nombre, telefono, credito, email);
        
        // Agregar el cliente a la "base de datos".
        ClienteRepository.AgregarCliente(cliente);
        
        // Confirmar que el cliente ha sido agregado con éxito.
        Console.WriteLine("Cliente agregado con éxito.");
    }

    // Método para obtener la lista de clientes.
    public List<Cliente> ObtenerClientes()
    {
        return ClienteRepository.ObtenerClientes();  // Retornar la lista de clientes desde el repositorio.
    }

    // Método para mostrar los clientes en consola.
    public void VerClientes()
    {
        Console.WriteLine("----- Clientes -----");  // Encabezado para la lista de clientes.
        
        // Iterar sobre la lista de clientes y mostrar su representación en JSON.
        foreach (var cliente in ClienteRepository.ObtenerClientes())
        {
            Console.WriteLine(cliente.ToJsonString());  // Mostrar la información de cada cliente.
        }
    }
}
