using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Dominios;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaArquivos.Tests
{
    [TestClass()]
    public class VeiculoRepositorioTest
    {
        [TestMethod()]
        public void GravarTest()
        {

            VeiculoPasseio veiculo = new VeiculoPasseio() {
                Ano = 2019,
                Cambio = Cambio.Automatico,
                Combustivel = Combustivel.Flex,
                Cor = new CorRepositorio().Obter(1),
                Modelo  = new ModeloRepositorio().ObterModelo(1),
                Observacao = "usado",
                Placa = "abc-1234",
                TipoCarroceria = TipoCarroceria.Hatch
            };
            new VeiculoRepositorio().Gravar(veiculo);
        }
    }
}