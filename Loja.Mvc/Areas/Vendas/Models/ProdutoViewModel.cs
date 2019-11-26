using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Loja.Mvc.Areas.Vendas.Models
{
    public class ProdutoViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        
        [Display(Name ="Nome Categoria")]
        public string CategoriaNome { get; set; }

        [Required]
        [Display(Name = "Categoria Id")]
        public int? CategoriaId { get; set; }

        [Display(Name = "Categoria")]
        public List<SelectListItem> Categorias { get; set; } = new List<SelectListItem>();

        [Required]
        [Display(Name = "Preço")]
        [DataType(DataType.Currency)]
        public decimal Preco { get; set; }

        [Required]
        public int Estoque { get; set; }

        public ProdutoViewModel()
        {
            //Categorias = new List<SelectListItem>();
        }
    }
}