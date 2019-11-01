using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Oficina.Repositorios.SistemaArquivos;

namespace Oficina.Repositorios.SistemaArquivosTests
{
    [TestClass]
    public class CorRepositorioTests
    {
        CorRepositorio corRepositorio = new CorRepositorio();

        [TestMethod]
        public void ObterTest()
        {

            var cores = corRepositorio.Obter();
            foreach (var item in cores)
            {
                Console.WriteLine($"ID: {item.Id} - {item.Nome}");
            }

        }
        [TestMethod]
        public void ObterPorID()
        {

            var cor = corRepositorio.Obter(1);
            Assert.AreEqual(cor.Nome, "Branco");

            cor = corRepositorio.Obter(8);
            Assert.IsNull(cor);

        }
    }

}
