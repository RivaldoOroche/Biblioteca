using dominio = Biblioteca.Libro.Dominio.Entidades;

namespace Biblioteca.Libro.Aplicacion.Libro
{
    public interface ILibroService
    {
        List<dominio.Libro> ListarLibros();
        bool RegistrarLibro(dominio.Libro libro);
        dominio.Libro Libro(int idLibro);
        void Eliminar(int idLibro);   
    }
}
