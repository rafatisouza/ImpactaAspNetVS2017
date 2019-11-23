using Microsoft.VisualStudio.TestTools.UnitTesting;
using Loja.Repositorios.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Loja.Dominio;
using System.Data.Entity;

namespace Loja.Repositorios.SqlServer.Tests
{
    [TestClass()]
    public class LojaDbContextTest
    {
        private readonly LojaDbContext db = new LojaDbContext();


        public LojaDbContextTest()
        {
            db.Database.Log = LogarQuery;
        }

        private void LogarQuery(string query)
        {
            Debug.WriteLine(query);
        }

        [TestMethod()]
        public void InserirCategoriaTest()
        {
            var categoria = new Categoria();
            categoria.Nome = "Eletrônicos";

            db.Categorias.Add(categoria);
            db.SaveChanges();
        }
        [TestMethod]
        public void InserirProduto()
        {
            var produto = new Produto();
            produto.Nome = "Grampeador";
            produto.Preco = 100.00m;
            //produto.Categoria = db.Categorias.Find(1);;
            produto.Categoria = new Categoria() { Nome = "Papelaria" };
            db.Produtos.Add(produto);
            db.SaveChanges();
        }

        [TestMethod]
        public void LazyLoadTeste()
        {
            var produto = db.Produtos.Where(x => x.Nome == "Grampeador").First();
            
            Console.WriteLine(produto.Categoria.Nome);

        }

        [TestMethod]
        public void IncludeTest()
        {
            var produto = db.Produtos.Include(p => p.Categoria).Single(p => p.Id == 1);
            Console.WriteLine(produto.Nome + produto.Categoria);
        }

        [TestMethod]
        [DataRow(1)]
        public void QueryableTeste(int estoque)
        {
            var query = db.Produtos.Where(p => p.Preco > 10);
            if (estoque > 0)
            {
                query = query.Where(p => p.Estoque > estoque);
            }
            query.OrderBy(p => p.Nome);

            var primeiro = query.FirstOrDefault();
            //var primeiro = query.First();
            //var ultimo = query.AsEnumerable().Last();
            //var unico = query.Single();
            var todos = query.ToList();
            
        }
    }
}