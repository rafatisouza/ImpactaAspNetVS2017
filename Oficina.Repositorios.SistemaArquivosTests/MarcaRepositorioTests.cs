using Oficina.Repositorios.SistemaArquivos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Oficina.Repositorios.SistemaArquivos.Tests
{
    [TestClass()]
    public class MarcaRepositorioTests
    {
        MarcaRepositorio marcaRepositorio = new MarcaRepositorio();
        [TestMethod()]
        public void MarcaObterTest()
        {

            var marcas = marcaRepositorio.Obter();
            Assert.IsTrue(marcas.Count > 0);
        }

        [TestMethod()]
        public void MarcaObterIDTest()
        {

            var marca = marcaRepositorio.Obter(1);
            Assert.AreEqual(marca.Nome, "Ford");

            marca = marcaRepositorio.Obter(20);
            Assert.IsNull(marca);
        }
        
    }
}