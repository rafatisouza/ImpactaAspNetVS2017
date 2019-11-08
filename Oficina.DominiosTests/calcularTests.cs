using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Dominios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Dominios.Tests
{
    [TestClass()]
    public class calcularTests
    {
        
        [TestMethod()]
        
        public void _calcularTests()
        {
            
            var cliente = new Cliente() {
            Id= 1,
            Nome= "Calos"};
            var Frete = new Frete(cliente, 20, UF.MG);            
            Console.WriteLine(Frete);

            Assert.AreEqual(Frete.ValorFrete, 0.35m);
            Assert.AreEqual(Frete.ValorTotal, 27.00m);
        }
    }
}