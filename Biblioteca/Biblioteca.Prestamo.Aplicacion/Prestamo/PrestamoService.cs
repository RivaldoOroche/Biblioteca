using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using Release.MongoDB.Repository;
using dominio = Biblioteca.Prestamo.Dominio.Entidades;


namespace Biblioteca.Prestamo.Aplicacion.Prestamo
{
    public class PrestamoService : IPrestamoService
    {
        private readonly ICollectionContext<dominio.Prestamo> _prestamo;
        private readonly IBaseRepository<dominio.Prestamo> _prestamoR;

        public PrestamoService(ICollectionContext<dominio.Prestamo> Prestamo,
                                IBaseRepository<dominio.Prestamo> PrestamoR)
        {
            _prestamo = Prestamo;
            _prestamoR = PrestamoR;
        }

        public List<dominio.Prestamo> ListarPrestamos()
        {
            Expression<Func<dominio.Prestamo, bool>> filter = s => s.esEliminado == false;
            var items = (_prestamo.Context().FindAsync(filter, null).Result).ToList();
            return items;
        }

        public bool RegistrarPrestamo(dominio.Prestamo Prestamo)
        {
            Prestamo.esEliminado = false;
            Prestamo.fechaCreacion = DateTime.Now;
            Prestamo.esActivo = true;           

            var p = _prestamoR.InsertOne(Prestamo);

            return true;
        }

        public dominio.Prestamo Prestamo(int idPrestamo)
        {
            Expression<Func<dominio.Prestamo, bool>> filter = s => s.esEliminado == false && s.idPrestamo == idPrestamo;
            var item = (_prestamo.Context().FindAsync(filter, null).Result).FirstOrDefault();
            return item;
        }

        public void Eliminar(int idPrestamo)
        {
            Expression<Func<dominio.Prestamo, bool>> filter = s => s.esEliminado == false && s.idPrestamo == idPrestamo;
            var item = (_prestamo.Context().FindOneAndDelete(filter, null));

        }
    }
}
