﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    public class ArticulosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Articulos articulos = new Articulos();
            articulos.ArticulosId = 3;
            articulos.FechaVencimiento = DateTime.Now;
            articulos.Descripcion = "Arroz";
            articulos.Precio = 100f;
            articulos.Existencia = 20f;
            articulos.CantCotizada = 10f;
            paso = ArticulosBLL.Guardar(articulos);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            Articulos articulos = new Articulos();
            articulos.ArticulosId = 3;
            articulos.FechaVencimiento = DateTime.Now;
            articulos.Descripcion = "Arroz";
            articulos.Precio = 80f;
            articulos.Existencia = 45f;
            articulos.CantCotizada = 18f;
            paso = ArticulosBLL.Modificar(articulos);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            int id = 3;
            bool paso;
            paso = ArticulosBLL.Eliminar(id);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            int id = 2;
            Articulos articulos = new Articulos();
            articulos = ArticulosBLL.Buscar(id);
            Assert.IsNotNull(articulos);
        }

        [TestMethod()]
        public void GetListTest(Expression<Func<Articulos, bool>> expression)
        {
            Contexto contexto = new Contexto();

            List<Articulos> ListArticulos = new List<Articulos>();
            ListArticulos = contexto.Articulos.Where(expression).ToList();
            Assert.IsNotNull(ListArticulos);
        }
    }
}