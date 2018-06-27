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
    public class PersonasBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Personas personas = new Personas();
            personas.PersonaId = 3;
            personas.Fecha = DateTime.Now;
            personas.Cedula = "0000000000";
            personas.Telefono = "0000000000";
            personas.Direccion = "Alcarrizos";
            paso = PersonasBLL.Guardar(personas);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            Personas personas = new Personas();
            personas.PersonaId = 5;
            personas.Nombres = "Maria";
            personas.Fecha = DateTime.Now;
            personas.Cedula = "0000000000";
            personas.Telefono = "1111111111";
            personas.Direccion = "Montañas Gal";
            paso = PersonasBLL.Modificar(personas);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            int id = 3;
            bool paso;
            paso = PersonasBLL.Eliminar(id);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            int id = 2;
            Personas personas = new Personas();
            personas = PersonasBLL.Buscar(id);
            Assert.IsNotNull(personas);
        }

        [TestMethod()]
        public void GetListTest(Expression<Func<Personas, bool>> expression)
        {
            Contexto contexto = new Contexto();

            List<Personas> ListPersonas = new List<Personas>();
            ListPersonas = contexto.Personas.Where(expression).ToList();
            Assert.IsNotNull(ListPersonas);
        }
    }
}