using clienteRepository;
using clientes;

namespace iClientesRepository
{
    public interface IClientesRepository
    {
        void CrearCliente(Clientes cliente);
        List<Clientes> ObtenerClientes();
        void ModificarCliente(int id, Clientes cliente);
        Clientes ObtenerCliente(int id);
        void EliminarCliente(int id);
    }
}