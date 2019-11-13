using Microsoft.VisualStudio.TestTools.UnitTesting;
using ViagensOnline.Repositorios.SqlServel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViagemOnline.Dominio;

namespace ViagensOnline.Repositorios.SqlServel.Tests
{
    [TestClass()]
    public class calcularTests
    {
        ViagensOnlineDbContext db = new ViagensOnlineDbContext();

        [TestMethod()]
        public void ViagensOnlineDbContextTests()
        {
            
            //Assert.Fail();

        }
        [TestMethod()]
        public void Inserir()
        {
            var viagem = new Destino() {
                Cidade = "Londres",                
                Nome = "Conhe a cidade do harry Potter",
                NomeImagem = "londres",
                Pais = "Brasil"
            };
            db.Destinos.Add(viagem);
            db.SaveChanges();
        }
    }
}