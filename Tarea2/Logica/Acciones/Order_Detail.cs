using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tarea2.Logica.Acciones
{
    public class Order_Detail
    {
        public IList<Tarea2.Order_Detail> ConsultarDetalleOrdenPorNombreArticulo(string articulo)
        {
            var elRepositorio = new Tarea2.Logica.Repositorio.Order_Detail();
            var elResultado = elRepositorio.ConsultarDetalleOrdenPorNombreArticulo(articulo);
            return elResultado;
        }

        public IList<Tarea2.Product> ConsultarDetalleOrdenPorNombreCategoria(string categoria)
        {
            var elRepositorio = new Tarea2.Logica.Repositorio.Order_Detail();
            var elResultado = elRepositorio.ConsultarDetalleOrdenPorNombreCategoria(categoria);
            return elResultado;
        }

        public Tarea2.Order_Detail ConsultarPorId(int id)
        {
            var misTablas = new Tarea2.Logica.Repositorio.Order_Detail();
            var elResultado = misTablas.ConsultarPorId(id);
            return elResultado;
        }
    }
}