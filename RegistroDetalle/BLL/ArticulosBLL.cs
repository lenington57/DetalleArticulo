using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RegistroDetalle.DAL;
using RegistroDetalle.Entidades;
using System.Data.Entity;
using System.Linq.Expressions;

namespace RegistroDetalle.BLL
{
    ///<summary>
    ///En esta clase se programa toda la lógica de negocio.
    ///</summary>
    public class ArticulosBLL
    {
        ///<summary>
        ///Permite Guardar una entidad en la Base de Datos.
        ///</summary>
        ///<param name="articulo">una instancia de Articulo</param>
        ///<returns>Retorna True si Guardó o False si no lo hizo</returns>
        public static bool Guardar(Articulos articulo)
        {
            bool paso = false;
            //creamos una instancia del contexto para poder conectar con la BD.
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Articulos.Add(articulo) != null)
                {
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
        public static bool Modificar(Articulos articulo)
        {
            bool paso = false;
            //creamos una instancia del contexto para poder conectar con la BD.
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(articulo).State = EntityState.Modified;
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
                Articulos articulo = contexto.Articulos.Find(id);

                contexto.Articulos.Remove(articulo);

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
        public static Articulos Buscar(int id)
        {
            //creamos una instancia del contexto para poder conectar con la BD.
            Contexto contexto = new Contexto();
            Articulos articulo = new Articulos();
            try
            {
                articulo = contexto.Articulos.Find(id);
                contexto.Dispose();//Siempre hay que cerrar la conexión.
            }
            catch (Exception)
            {
                throw;
            }
            return articulo;
        }

        ///<summary>
        ///Permite extraer una lista de Articulos de la Base de Datos.
        ///</summary>
        ///<param name="expression">Expresión Lambda conteniendo los filtros de búsqueda</param>
        ///<returns>Retorna una lista de Articulos</returns>
        public static List<Articulos> GetList(Expression<Func<Articulos, bool>> expression)
        {
            List<Articulos> articulos = new List<Articulos>();
            Contexto contexto = new Contexto();
            try
            {
                articulos = contexto.Articulos.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return articulos;
        }
    }
}
