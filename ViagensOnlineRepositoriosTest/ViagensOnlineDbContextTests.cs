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

        [TestMethod]
        public void AtualizarTeste()
        {
            var destino = db.Destinos.Where(x => x.Id == 1).SingleOrDefault();
            
            //var destino = db.Destinos.Find(1);
            
            destino.Nome = "Salvaor";
            destino.NomeImagem = "Farol da barra";
            db.SaveChanges();
            destino = db.Destinos.Find(1);
            Assert.AreEqual(destino.Nome, "Salvaor");
        }
        [TestMethod]
        public void ExcluirTeste()
        {
            var destino = db.Destinos.SingleOrDefault(x => x.Id == 2);

            if (destino != null)
            {
                db.Destinos.Remove(destino);
                db.SaveChanges();
            }
            

            destino = db.Destinos.SingleOrDefault(x => x.Id == 1);

            Assert.IsNull(destino);


        }
    }
}