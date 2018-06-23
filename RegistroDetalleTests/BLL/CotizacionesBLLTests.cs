using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegistroDetalle.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RegistroDetalle.Entidades;
using RegistroDetalle.DAL;
using System.Linq.Expressions;

namespace RegistroDetalle.BLL.Tests
{
    [TestClass()]
    public class CotizacionesBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Cotizaciones cotizaciones = new Cotizaciones
            {
                Fecha = DateTime.Now,
                Observaciones = "Producto bueno"
            };

            cotizaciones.Detalle.Add(new DetalleCotizaciones(0,0,1,1,2f,50f,100f));
            cotizaciones.Detalle.Add(new DetalleCotizaciones(0, 0, 2, 3, 4f, 10f, 40f));

            bool paso = CotizacionesBLL.Guardar(cotizaciones);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            int idcotizaciones = CotizacionesBLL.GetList(x => true)[0].CotizacionId;
            Cotizaciones cotizaciones = CotizacionesBLL.Buscar(idcotizaciones);

            //agregtar otro
            cotizaciones.Detalle.Add(new DetalleCotizaciones(0, cotizaciones.CotizacionId, 2, 4, 50f,2f,100f));
            bool paso = CotizacionesBLL.Modificar(cotizaciones);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            int idcotizaciones = CotizacionesBLL.GetList(x => true)[0].CotizacionId;
            bool paso = CotizacionesBLL.Eliminar(idcotizaciones);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            int idcotizaciones = CotizacionesBLL.GetList(x => true)[0].CotizacionId;

            Cotizaciones cotizaciones = CotizacionesBLL.Buscar(idcotizaciones);
            bool paso = cotizaciones.Detalle.Count > 0;
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void GetListTest(Expression<Func<Cotizaciones, bool>> expression)
        {
            Contexto contexto = new Contexto();

            List<Cotizaciones> ListCotizaciones = new List<Cotizaciones>();
            ListCotizaciones = contexto.Cotizaciones.Where(expression).ToList();
            Assert.IsNotNull(ListCotizaciones);
        }
    }
}