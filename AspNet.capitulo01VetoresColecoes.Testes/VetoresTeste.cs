using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspNet.capitulo01VetoresColecoes.Testes {
    [TestClass]
    public class VetoresTeste {
        [TestMethod]
        public void inicializacaoTeste() {
            var inteiros = new int[5];
            inteiros[0] = 48;
            inteiros[1] = 20;

            var decimais = new decimal[] {0.2m, 5,2.52m, 1.9m};

            decimal[] maisDecimais = {2, 5.8m, 0.5m };

            foreach (var item in decimais) {
                Console.WriteLine(item);                
            }
            Console.WriteLine($"O tamanho do vetor {nameof(decimais)} é decimais{decimais.Length}");
        }

        [TestMethod]
        public void RedimensionamentoTeste() {
            var decimais = new decimal[] {2.1m, 1.6m, -8};
            Array.Resize(ref decimais, 5);
            decimais[3] = 1.7m;
            foreach (var item in decimais) {
                Console.WriteLine(item);                
            }

        }
        [TestMethod]
        public void OrdenacaoTeste() {

            var decimais = new decimal[] { 2.1m, 1.5m, -8 };
            Array.Sort(decimais);
            Assert.AreEqual(decimais[0], -8m);
        }

        [TestMethod]
        public void ParamsTeste() {

            var valores = new decimal[] {10, 20, 50, 100 };
            Console.WriteLine(Media(valores));

            Console.WriteLine(Media(1.9m, 2.19m, 22, 0.3m));

            Console.WriteLine(valores.Average());
        }

        private decimal Media(decimal valor1, decimal valor2 ) {
            return (valor1 + valor2)/2;
        }
        /// <summary>
        /// Calcula a média dos valores informados
        /// </summary>
        /// <param name="valores"> valores a serem calculados</param>
        /// <returns>media</returns>
        private decimal Media(params decimal []valores) {
            var soma = 0m;
            foreach (var valor in valores) {
                soma += valor;
            }
            return decimal.Round((soma / valores.Length), 2);
        }
    }
}
