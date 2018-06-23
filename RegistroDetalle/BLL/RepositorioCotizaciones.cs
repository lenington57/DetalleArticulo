using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RegistroDetalle.BLL;
using RegistroDetalle.DAL;
using RegistroDetalle.Entidades;
using System.Data.Entity;

namespace RegistroDetalle.BLL
{
    public class RepositorioCotizaciones : Repositorio<Cotizaciones>
    {
        public RepositorioCotizaciones(Contexto contexto) : base(contexto)
        {

        }
        public override Cotizaciones Buscar(int id)
        {
            Cotizaciones cotizaciones = new Cotizaciones();

            try
            {
                cotizaciones = _contexto.Cotizaciones.Find(id);

                cotizaciones.Detalle.Count();

                foreach (var item in cotizaciones.Detalle)//Cargar los nombres de las ciudades    
                { string s = item.Personas.Nombres; } //forzando la ciudad a cargarse
            }
            catch (Exception)
            {
                throw;
            }

            return cotizaciones;

        }


        public override bool Modificar(Cotizaciones cotizaciones)
        {
            bool paso = false;

            try
            {
                foreach (var item in cotizaciones.Detalle)
                {
                    var estado = item.Id > 0 ? EntityState.Modified : EntityState.Added; //Muy dicar que pasara con la entidad del detalle
                    _contexto.Entry(item).State = estado;

                }
                //Idicar que se esta modificando el encabezado
                _contexto.Entry(cotizaciones).State = EntityState.Modified;

                if (_contexto.SaveChanges() > 0)
                    paso = true;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }
    }
}
