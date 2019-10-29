using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AspNet.capitulo01VetoresColecoes.Testes {
    /// <summary>
    /// Descrição resumida para UnitTest1
    /// </summary>
    [TestClass]
    public class ColecoesTeste {
        public ColecoesTeste() {
            //
            // TODO: Adicionar lógica de construtor aqui
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Obtém ou define o contexto do teste que provê
        ///informação e funcionalidade da execução de teste atual.
        ///</summary>
        public TestContext TestContext {
            get {
                return testContextInstance;
            }
            set {
                testContextInstance = value;
            }
        }

        #region Atributos de teste adicionais
        //
        // É possível usar os seguintes atributos adicionais enquanto escreve os testes:
        //
        // Use ClassInitialize para executar código antes de executar o primeiro teste na classe
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup para executar código após a execução de todos os testes em uma classe
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize para executar código antes de executar cada teste 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup para executar código após execução de cada teste
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void Listteste() {
            var inteiros = new List<int>() {16, 3, 2, -81};
            inteiros.Add(15);
            inteiros[0] = 23;


            var maisInteiros = new List<int> {4, 2, 3 };
            inteiros.AddRange(maisInteiros);

            inteiros.Insert(0, 29);

            inteiros.Remove(2); //remove o primeiro item
            inteiros.RemoveAt(4); //remove por item
            inteiros.RemoveAll(x => x == 2); //remove todos os itens com valor = 2

            inteiros.Sort();

            var primeiro = inteiros.First();

            var ultimo = inteiros.Last();

            var media = inteiros.Average();

            foreach (var inteiro in inteiros) {
                Console.WriteLine($"{inteiros.IndexOf(inteiro)}:{inteiro}");
            }
        }
    }
}
