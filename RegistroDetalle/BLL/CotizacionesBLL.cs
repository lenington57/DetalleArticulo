using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RegistroDetalle.DAL;
using RegistroDetalle.Entidades;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RegistroDetalle.BLL
{
    ///<summary>
    ///En esta clase se programa toda la lógica de negocio.
    ///</summary>
    public class CotizacionesBLL
    {
        ///<summary>
        ///Permite Guardar una entidad en la Base de Datos.
        ///</summary>
        ///<param name="articulo">una instancia de Articulo</param>
        ///<returns>Retorna True si Guardó o False si no lo hizo</returns>
        public static bool Guardar(Cotizaciones cotizaciones)
        {
            bool paso = false;
            //creamos una instancia del contexto para poder conectar con la BD.
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Cotizaciones.Add(cotizaciones) != null)
                {
                    foreach (var item in cotizaciones.Detalle)
                    {
                        contexto.Articulos.Find(item.ArticulosId).Existencia -= item.CantidadCotizada;
                    }
                    contexto.SaveChanges();//Guardar los cambios.
                    paso = true;
                }
                contexto.Dispose();//Siempre hay que cerrar la conexión.
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        ///<summary>
        ///Permite Modificar una entidad en la Base de Datos.
        ///</summary>
        ///<param name="articulo">una instancia de Articulo</param>
        ///<returns>Retorna True si Modificó o False si no lo hizo</returns>
        public static bool Modificar(Cotizaciones cotizaciones)
        {
            bool paso = false;
            //creamos una instancia del contexto para poder conectar con la BD.
            Contexto contexto = new Contexto();
            try
            {
                var CantCotAnt = CotizacionesBLL.Buscar(cotizaciones.CotizacionId);

                foreach (var item in CantCotAnt.Detalle)//recorrer el detalle anterior
                {
                    //restar todas las cantidades cotizadas
                    contexto.Articulos.Find(item.ArticulosId).Existencia -= item.CantidadCotizada;

                    //determinar si el item no esta en el detalle actual
                    if (!cotizaciones.Detalle.ToList().Exists(v => v.Id == item.Id))
                    {
                        contexto.Articulos.Find(item.ArticulosId).Existencia -= item.CantidadCotizada;
                        item.Articulos = null; //quitar la cantidad para que EF no intente hacerle nada
                        contexto.Entry(item).State = EntityState.Deleted;
                    }
                }

                //recorrer el detalle
                foreach (var item in cotizaciones.Detalle)
                {
                    //Sumar todas las cantidades cotizadas
                    contexto.Articulos.Find(item.ArticulosId).Existencia += item.CantidadCotizada;

                    //Muy importante indicar que pasara con la entidad del detalle
                    var estado = item.Id > 0 ? EntityState.Modified : EntityState.Added;
                    contexto.Entry(item).State = estado;
                }

                contexto.Entry(cotizaciones).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();//Siempre hay que cerrar la conexión.
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        ///<summary>
        ///Permite Eliminar una entidad en la Base de Datos.
        ///</summary>
        ///<param name="id">El id el Articulo que desea Eliminar</param>
        ///<returns>Retorna True si Eliminó o False si no lo hizo</returns>
        public static bool Eliminar(int id)
        {
            bool paso = false;
            //creamos una instancia del contexto para poder conectar con la BD.
            Contexto contexto = new Contexto();
            try
            {
                Cotizaciones cotizaciones = contexto.Cotizaciones.Find(id);

                foreach (var item in cotizaciones.Detalle)
                {
                    var articulos = contexto.Articulos.Find(item.ArticulosId);
                    articulos.CantCotizada -= item.CantidadCotizada;

                }
                contexto.Cotizaciones.Remove(cotizaciones);

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();//Siempre hay que cerrar la conexión.
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        ///<summary>
        ///Permite Buscar una entidad en la Base de Datos.
        ///</summary>
        ///<param name="id">El id el Articulo que desea encontrarar</param>
        ///<returns>Retorna el Articulo encontrado</returns>
        public static Cotizaciones Buscar(int id)
        {
            //creamos una instancia del contexto para poder conectar con la BD.
            Contexto contexto = new Contexto();
            Cotizaciones cotizaciones = new Cotizaciones();
            try
            {
                cotizaciones = contexto.Cotizaciones.Find(id);

                if (cotizaciones != null)
                {
                    //Cargar la lista en este punto porque
                    //luego de hacer Dispose() el Contexto 
                    //no sera posible leer la lista
                    cotizaciones.Detalle.Count();
                    //Cargar las Descripcion
                    //Cargar el Nombre Descripcion
                    foreach (var item in cotizaciones.Detalle)
                    {
                        //forzando la Descripcion y Nombres a cargarse
                        string s = item.Articulos.Descripcion;
                        string ss = item.Personas.Nombres;
                    }
                }
                contexto.Dispose();//Siempre hay que cerrar la conexión.
            }
            catch (Exception)
            {
                throw;
            }
            return cotizaciones;
        }

        ///<summary>
        ///Permite extraer una lista de Articulos de la Base de Datos.
        ///</summary>
        ///<param name="expression">Expresión Lambda conteniendo los filtros de búsqueda</param>
        ///<returns>Retorna una lista de Articulos</returns>
        public static List<Cotizaciones> GetList(Expression<Func<Cotizaciones, bool>> expression)
        {
            List<Cotizaciones> cotizaciones = new List<Cotizaciones>();
            Contexto contexto = new Contexto();
            try
            {
                cotizaciones = contexto.Cotizaciones.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return cotizaciones;
        }

        public static float Importe(float cantidad, float precio)
        {
            float CalImporte = 0;

            CalImporte = cantidad * precio;

            return CalImporte;
        }
    }
}
