using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pessoal.Dominio.Entidades;

namespace Pessoal.Repositorios.SqlServer.Testes
{
    [TestClass]
    public class TarefaRepositorioTeste
    {
        private TarefaRepositorio repositorio;

        public TarefaRepositorioTeste()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
                

            repositorio = new TarefaRepositorio(
                config.GetConnectionString("pessoalSqlServer"));
        }

        [TestMethod]
        public void InserirTeste()
        {
            Tarefa tarefa = new Tarefa() {
                Concluida = true,
                Nome = "Curso",
                Observacao = "Acabanco",
                Prioridade = Prioridade.Alta
            };
            tarefa.Id = repositorio.Inserir(tarefa);

            Assert.IsTrue(tarefa.Id > 0);
            
        }

        [TestMethod]
        public void SelecionarTodosTeste()
        {
            var retorno = repositorio.Selecionar();

            Assert.IsTrue(retorno.Count > 0);
        }
        [TestMethod]
        public void SelecionarID()
        {
            Assert.IsNotNull(repositorio.Selecionar(2));
            Assert.IsNull(repositorio.Selecionar(0));

        }
        [TestMethod]
        public void AtualizarTeste()
        {
            var tarefa = new Tarefa() {
                Concluida = false,
                Id = 1,
                Nome = "Limpar Casa",
                Observacao = "hahah",
                Prioridade = Prioridade.Baixa
            };
            repositorio.Atualizar(tarefa);
            tarefa = repositorio.Selecionar(tarefa.Id);

            Assert.IsTrue(tarefa.Id == 1);
            Assert.AreEqual(tarefa.Prioridade, Prioridade.Baixa);
        }
        
        [TestMethod]
        public void ExcluirTeste()
        {
            repositorio.Excluir(1);
            Assert.IsNull(repositorio.Selecionar(1));
        }
    }
}
