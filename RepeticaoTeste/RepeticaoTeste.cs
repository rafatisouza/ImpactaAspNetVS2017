using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepeticaoTeste {
    [TestClass]
    public class RepeticaoTeste {
        [TestMethod]
        public void TabuadaTeste() {
            for (int i = 1; i <= 10; i++) {
                for (int x = 1; x <= 10; x++) {
                    Console.WriteLine($"Tabuada {i} x {x} = " + i * x);
                }
                Console.WriteLine(new string('-', 50));
            }
            
            
        }
        [TestMethod]
        public void EstruturaForTeste () {
            var i = 1;
            for (Console.WriteLine("iniciou"); i < 3; Console.WriteLine(i++)) {
                //++i;
            }            
        }
        /*for(1. Inicialização; 2. Critério; 4.Pós-execução){
             * 3.Execução
             * }
             */

        [TestMethod]
        public void ForApenasComCondicaoTeste() {
            var i = 1 ;
            for (; i <= 3;) {
                Console.WriteLine(i++);
            }
        }
        [TestMethod]
        public void ContinueTeste() {
            for (int i = 1; i <= 10; i++) {
                if (i <= 5) {
                    continue;
                }
                Console.Write(i);
            }

        }

        [TestMethod]
        public void TodastringEhUmVetorTeste() {
            var nome = "Rafael";            
            Assert.AreEqual(nome[0], 'R');
            Console.WriteLine();
            
            foreach (var item in nome) {
                Console.WriteLine(item);
            }
        }
    }
}
