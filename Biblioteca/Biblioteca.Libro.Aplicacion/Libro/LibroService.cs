using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using Release.MongoDB.Repository;
using dominio = Biblioteca.Libro.Dominio.Entidades;


namespace Biblioteca.Libro.Aplicacion.Libro
{
    public class LibroService : ILibroService
    {
        private readonly ICollectionContext<dominio.Libro> _libro;
        private readonly IBaseRepository<dominio.Libro> _libroR;

        public LibroService(ICollectionContext<dominio.Libro> libro,
                                IBaseRepository<dominio.Libro> libroR)
        {
            _libro = libro;
            _libroR = libroR;
        }

        public List<dominio.Libro> ListarLibros()
        {
            Expression<Func<dominio.Libro, bool>> filter = s => s.esEliminado == false;
            var items = (_libro.Context().FindAsync(filter, null).Result).ToList();
            return items;
        }

        public bool RegistrarLibro(dominio.Libro Libro)
        {
            Libro.esEliminado = false;
            Libro.fechaCreacion = DateTime.Now;
            Libro.esActivo = true;           

            var p = _libroR.InsertOne(Libro);

            return true;
        }

        public dominio.Libro Libro(int idLibro)
        {
            Expression<Func<dominio.Libro, bool>> filter = s => s.esEliminado == false && s.idLibro == idLibro;
            var item = (_libro.Context().FindAsync(filter, null).Result).FirstOrDefault();
            return item;
        }

        public void Eliminar(int idLibro)
        {
            Expression<Func<dominio.Libro, bool>> filter = s => s.esEliminado == false && s.idLibro == idLibro;
            var item = (_libro.Context().FindOneAndDelete(filter, null));

        }
    }
}
