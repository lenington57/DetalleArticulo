using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using RegistroDetalle.DAL;

namespace RegistroDetalle.Entidades
{
    public class Repositorio<T> : IDisposable, IRepository<T> where T : class
    {
        //variable interna tipo Contexto
        internal Contexto _contexto;

        //Constructor de la clase
        public Repositorio(Contexto contexto)
        {
            _contexto = contexto;
        }

        //Programando el metodo buscar heredado de la interfaz IRepository<T>.
        public virtual T Buscar(int id)
        {
            T entity;
            try
            {
                entity = _contexto.Set<T>().Find(id);
                _contexto.Dispose();//Cerrando la conexión.
            }
            catch (Exception)
            {
                throw;
            }
            return entity;
        }

        //Programando el metodo Eliminar heredado de la interfaz IRepository<T>.
        public bool Eliminar(int id)
        {
            bool paso = false;
            try
            {
                T entity = _contexto.Set<T>().Find(id);
                _contexto.Set<T>().Remove(entity);
                if (_contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                _contexto.Dispose();//Cerrando la conexión.
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        //Programando el metodo GetList heredado de la interfaz IRepository<T>.
        public List<T> GetList(Expression<Func<T, bool>> expression)
        {
            List<T> Lista = new List<T>();
            try
            {
                Lista = _contexto.Set<T>().Where(expression).ToList();
                _contexto.Dispose();//Cerrando la conexión.
            }
            catch (Exception)
            {
                throw;
            }
            return Lista;
        }

        //Programando el metodo Modificar heredado de la interfaz IRepository<T>.
        public bool Guardar(T entity)
        {
            bool paso = false;
            try
            {
                if (_contexto.Set<T>().Add(entity) != null)
                {
                    _contexto.SaveChanges();//Cerrando la conexión.
                    paso = true;
                }
                _contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        //Programando el metodo Modificar heredado de la interfaz IRepository<T>.
        public virtual bool Modificar(T entity)
        {
            bool paso = false;
            try
            {
                _contexto.Entry(entity).State = EntityState.Modified;
                if (_contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                _contexto.Dispose();//Cerrando la conexión.
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public void Dispose()
        {
            _contexto.Dispose();
        }
    }
}
