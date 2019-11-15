using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ViagemOnline.Dominio;
using ViagensOnline.Repositorios.SqlServel;
using ViajensOline.MVC.Models;

namespace ViajensOline.MVC.Controllers
{
    public class DestinosController : Controller
    {
        private ViagensOnlineDbContext db = new ViagensOnlineDbContext();
        private string path;
        private string caminhoImagensDestinos = ConfigurationManager.AppSettings["caminhoImagensDestinos"];

        // GET: Destinos
        public ActionResult Index()
        {
            return View(Mapear(db.Destinos.ToList()));
        }

        private List<DestinoViewModel> Mapear(List<Destino> destinos)
        {
            List <DestinoViewModel> ViewModels = new List<DestinoViewModel>();

            foreach (var destino in destinos)
            {

                ViewModels.Add(Mapear(destino)); 
                    

            }

            return ViewModels;


        }

        private DestinoViewModel Mapear(Destino destino)
        {
            DestinoViewModel retorno = new DestinoViewModel() {
                CaminhoImagem = Path.Combine(caminhoImagensDestinos, destino.NomeImagem),
                Cidade = destino.Cidade,
                Id = destino.Id,
                Nome = destino.NomeImagem,
                Pais = destino.Pais                
            };
            return retorno;
            
        }

        // GET: Destinos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Destino destino = db.Destinos.Find(id);
            if (destino == null)
            {
                return HttpNotFound();
            }
            return View(Mapear(destino));
        }

        // GET: Destinos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Destinos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DestinoViewModel ViewModel)
        {
                if (ViewModel.ArquivoForto == null)
                {
                    ModelState.AddModelError("","Ops: selecione a imagem");
                }
            if (ModelState.IsValid)
            {
                SalvarFoto(ViewModel.ArquivoForto);
                db.Destinos.Add(Mapear(ViewModel));
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ViewModel);
        }

        private void SalvarFoto(HttpPostedFileBase arquivoForto)
        {
            var caminhoVirtual = Path.Combine(caminhoImagensDestinos, arquivoForto.FileName);
            arquivoForto.SaveAs(Request.MapPath(caminhoVirtual));
        }

        private Destino Mapear(DestinoViewModel viewModel)
        {
            Destino destino = new Destino() {
                   Cidade = viewModel.Cidade,
                   Id = viewModel.Id = viewModel.Id,
                   Nome = viewModel.Nome,
                   NomeImagem = viewModel.ArquivoForto.FileName,
                   Pais = viewModel.Pais
            };


            return destino;
        }

        // GET: Destinos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Destino destino = db.Destinos.Find(id);
            if (destino == null)
            {
                return HttpNotFound();
            }
            return View(Mapear(destino));
        }

        // POST: Destinos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(DestinoViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var destino = db.Destinos.Find(viewModel.Id);
                
                db.Entry(destino).CurrentValues.SetValues(viewModel);
                //db.Entry(viewModel).State = EntityState.Modified;
                if (viewModel.ArquivoForto != null)
                {
                    SalvarFoto(viewModel.ArquivoForto);
                    destino.NomeImagem = viewModel.ArquivoForto.FileName;
                }
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(viewModel);
        }

        // GET: Destinos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Destino destino = db.Destinos.Find(id);
            if (destino == null)
            {
                return HttpNotFound();
            }
            return View(Mapear(destino));
        }

        // POST: Destinos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Destino destino = db.Destinos.Find(id);
            db.Destinos.Remove(destino);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
