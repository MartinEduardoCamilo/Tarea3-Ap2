using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrestamosPersona.BLL;
using PrestamosPersona.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrestamosPersona.BLL.Tests
{
    [TestClass()]
    public class PrestamoBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Prestamo prestamo = new Prestamo(0, DateTime.Now, 1, "Deuda", 10000, 0);
            bool paso = PrestamoBLL.Guardar(prestamo);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Prestamo prestamo = new Prestamo(1, DateTime.Now, 1, "Deuda", 2000, 0);
            bool paso = PrestamoBLL.Modificar(prestamo);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = PrestamoBLL.Eliminar(1);
            Assert.IsNotNull(paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            var paso = PrestamoBLL.Buscar(1);
            Assert.AreEqual(paso, paso);
        }

        [TestMethod()]
        public void GetListTest()
        {
            List<Prestamo> persona = new List<Prestamo>();
            persona = PrestamoBLL.GetList(p => true);
            Assert.IsNotNull(persona);
        }

        [TestMethod()]
        public void ExisteTest()
        {
            var paso = PrestamoBLL.Existe(1);
            Assert.IsNotNull(paso);
        }
    }
}