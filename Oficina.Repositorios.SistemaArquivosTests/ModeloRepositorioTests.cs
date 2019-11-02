using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaArquivos.Tests
{
    [TestClass()]
    public class ModeloRepositorioTests
    {
        ModeloRepositorio repositorio = new ModeloRepositorio();
        [TestMethod()]
        public void ObterTest()
        {
            var modelos = repositorio.ObterMarca(2);
            foreach (var modelo in modelos)
            {
                Console.WriteLine($"{modelo.Id} - {modelo.Nome} - {modelo.Marca.Nome}");
            }
            modelos = repositorio.ObterMarca(9);
            Assert.IsTrue(modelos.Count == 0);
        }
        [TestMethod()]
        public void ObterModeloTest()
        {
            Dominios.Modelo modelo = repositorio.ObterModelo(4);
            Assert.AreEqual(modelo.Nome, "Polo");

            modelo = repositorio.ObterModelo(20);
            Assert.IsNull(modelo.Marca);
        }
    }
}