// Capa de Lógica de Negocio
using System.Collections.Generic;

public class ClienteService
{

    // Método para agregar un cliente
    public void AgregarCliente()
    {
        Console.Write("Ingrese el código del cliente: ");
        string codigo = Console.ReadLine();
        Console.Write("Ingrese el nombre del cliente: ");
        string nombre = Console.ReadLine();
        Console.Write("Ingrese el teléfono del cliente: ");
        string telefono = Console.ReadLine();
        Console.Write("Ingrese el credito del cliente: ");
        double credito = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el email del cliente: ");
        string email = Console.ReadLine();

        var cliente = new Cliente(codigo, nombre, telefono, credito, email);
        ClienteRepository.AgregarCliente(cliente);
        Console.WriteLine("Cliente agregado con éxito.");
    }

    public List<Cliente> ObtenerClientes()
    {
      return  ClienteRepository.ObtenerClientes();
    }

     // Método para ver los productos
    public void VerClientes()
    {
        Console.WriteLine("----- Clientes -----");
        foreach (var cliente in ClienteRepository.ObtenerClientes())
        {
            Console.WriteLine(cliente.ToJsonString());
        }
    }
}
