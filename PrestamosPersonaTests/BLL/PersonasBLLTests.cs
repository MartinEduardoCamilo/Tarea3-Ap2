using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrestamosPersona.BLL;
using PrestamosPersona.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrestamosPersona.BLL.Tests
{
    [TestClass()]
    public class PersonasBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Persona persona = new Persona(0, "Martinz", "8092368896", "40212912998", "kjdfhjbgfrkljioj", DateTime.Now, 0);
            bool paso = PersonasBLL.Guardar(persona);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Persona persona = new Persona(1, "Martin", "8092368896", "40212912998", "kjdfhjbgfrkljioj", DateTime.Now, 0);
            bool paso = PersonasBLL.Modificar(persona);
            Assert.AreEqual(paso, paso);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = PersonasBLL.Eliminar(1);
            Assert.IsNotNull(paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            var encontrar = PersonasBLL.Buscar(1);
            Assert.AreEqual(encontrar, encontrar);
        }

        [TestMethod()]
        public void GetListTest()
        {
            List<Persona> persona = new List<Persona>();
            persona = PersonasBLL.GetList(p => true);
            Assert.IsNotNull(persona);
        }

        [TestMethod()]
        public void ExisteTest()
        {
            var paso = PersonasBLL.Existe(1);
            Assert.IsNotNull(paso);
        }
    }
}