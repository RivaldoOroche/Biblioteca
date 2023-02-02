using dominio = Biblioteca.Prestamo.Dominio.Entidades;

namespace Biblioteca.Prestamo.Aplicacion.Prestamo
{
    public interface IPrestamoService
    {
        List<dominio.Prestamo> ListarPrestamos();
        bool RegistrarPrestamo(dominio.Prestamo prestamo);
        dominio.Prestamo Prestamo(int idPrestamo);
        void Eliminar(int idPrestamo);   
    }
}
