using dominio = Biblioteca.Usuario.Dominio.Entidades;

namespace Biblioteca.Usuario.Aplicacion.Usuario
{
    public interface IUsuarioService
    {
        List<dominio.Usuario> ListarUsuarios();
        bool RegistrarUsuario(dominio.Usuario cliente);
        dominio.Usuario Usuario(int idUsuario);
        void Eliminar(int idUsuario);
    }
}
