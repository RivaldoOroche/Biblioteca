using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using Release.MongoDB.Repository;
using dominio = Biblioteca.Autor.Dominio.Entidades;


namespace Biblioteca.Autor.Aplicacion.Autor
{
    public class AutorService : IAutorService
    {
        private readonly ICollectionContext<dominio.Autor> _autor;
        private readonly IBaseRepository<dominio.Autor> _autorR;

        public AutorService(ICollectionContext<dominio.Autor> autor,
                                IBaseRepository<dominio.Autor> autorR)
        {
            _autor = autor;
            _autorR = autorR;
        }

        public List<dominio.Autor> ListarAutors()
        {
            Expression<Func<dominio.Autor, bool>> filter = s => s.esEliminado == false;
            var items = (_autor.Context().FindAsync(filter, null).Result).ToList();
            return items;
        }

        public bool RegistrarAutor(dominio.Autor autor)
        {
            autor.esEliminado = false;
            autor.fechaCreacion = DateTime.Now;
            autor.esActivo = true;           

            var p = _autorR.InsertOne(autor);

            return true;
        }

        public dominio.Autor Autor(int idAutor)
        {
            Expression<Func<dominio.Autor, bool>> filter = s => s.esEliminado == false && s.idAutor == idAutor;
            var item = (_autor.Context().FindAsync(filter, null).Result).FirstOrDefault();
            return item;
        }

        public void Eliminar(int idAutor)
        {
            Expression<Func<dominio.Autor, bool>> filter = s => s.esEliminado == false && s.idAutor == idAutor;
            var item = (_autor.Context().FindOneAndDelete(filter, null));

        }
    }
}
