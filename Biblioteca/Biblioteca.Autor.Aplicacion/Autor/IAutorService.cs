using dominio = Biblioteca.Autor.Dominio.Entidades;

namespace Biblioteca.Autor.Aplicacion.Autor
{
    public interface IAutorService
    {
        List<dominio.Autor> ListarAutors();
        bool RegistrarAutor(dominio.Autor autor);
        dominio.Autor Autor(int idAutor);
        void Eliminar(int idAutor);   
    }
}
