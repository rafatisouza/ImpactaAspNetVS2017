using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ViajensOline.MVC.Models
{
    public class DestinoViewModel
    {            
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "País")]
        public string Pais { get; set; }

        [Required]
        public string Cidade { get; set; }
                
        [Display(Name = "Caminho Imagem")]
        public string CaminhoImagem { get; set; }

        [DisplayName("Foto")]
        public HttpPostedFileBase ArquivoForto { get; set; }
    }
}