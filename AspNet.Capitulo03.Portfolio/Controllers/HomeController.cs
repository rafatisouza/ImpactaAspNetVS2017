using AspNet.Capitulo03.Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNet.Capitulo03.Portfolio.Controllers
{
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpGet]// opcional
        public ActionResult Contact() {
            ViewBag.Message = "Deixe sua mensagem";

            return View();
        }
        //public ActionResult Contact(string nome, string email, string mensagem) {
        //--------------------------------------------------------------------
        //public ActionResult Contact(FormCollection formulario) {
        //    var nome = formulario["nome"];
        [HttpPost]
        public ActionResult Contact(ContatoViewModel contato) {
            if (!ModelState.IsValid) {
                return View(contato);
            }

            var stringConexao = ConfigurationManager.ConnectionStrings["portfolioConnectionString"].ConnectionString;
            using (var conexao = new SqlConnection(stringConexao)) {
                conexao.Open();
                const string instrucao = @"INSERT INTO [dbo].[Contato]
                                               ([Nome]
                                               ,[Email]
                                               ,[Mensagem])
                                         VALUES
                                               (@Nome
                                               ,@Email
                                               ,@mensagem)";
                //Todo: não esqueça do meu IDisposable
                using (var comando = new SqlCommand(instrucao, conexao)) {

                    comando.Parameters.AddWithValue("Nome", contato.Nome);
                    comando.Parameters.AddWithValue("Email", contato.Email);
                    comando.Parameters.AddWithValue("mensagem", contato.Mensagem);
                    comando.ExecuteNonQuery();

                }
                ModelState.Clear();
                ViewBag.Sucesso = true;
                return View();
            }

        }

        public ActionResult Portfolio() 
        {
            const string diretorioImagens = "/Content/Imagens/Portifolio";
            var caminhos = Directory.EnumerateFiles(Server.MapPath(diretorioImagens));
            var portifoliViewModel = new PortfolioViewModel();
            foreach (var caminho in caminhos)
            {
                portifoliViewModel.CaminhosImagens.Add($"{diretorioImagens}/{Path.GetFileName(caminho)}");
            }
            return View(portifoliViewModel);
        }

    }
}