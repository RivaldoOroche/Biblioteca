using dominio = Biblioteca.Cliente.Dominio.Entidades;

namespace Biblioteca.Cliente.Aplicacion.Cliente
{
    public interface IClienteService
    {
        List<dominio.Cliente> ListarClientes();
        bool RegistrarCliente(dominio.Cliente cliente);
        dominio.Cliente Cliente(int idCliente);
        void Eliminar(int idCliente);   
    }
}
