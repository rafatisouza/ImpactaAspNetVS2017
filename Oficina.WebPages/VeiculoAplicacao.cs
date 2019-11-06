using Oficina.Dominios;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Oficina.WebPages
{
    public class VeiculoAplicacao
    {
        public VeiculoAplicacao()
        {
            PopularControles();
        }
        private readonly MarcaRepositorio marcaRepositoprio = new MarcaRepositorio();
        private readonly CorRepositorio corRepositorio = new CorRepositorio();
        private readonly ModeloRepositorio modeloRepositorio = new ModeloRepositorio();
        private readonly VeiculoRepositorio veiculoRepositorio = new VeiculoRepositorio();
        

        public List<Marca> Marcas { get; set; }
        public string MarcaSelecionada { get; set; }
        public List<Cor> Cores { get; set; }
        public List<Modelo> Modelos { get; set; } = new List<Modelo>();
        public List<Veiculo> Veiculos { get; set; }
        public List<Combustivel> Combustiveis { get; set; }
        public List<Cambio> Cambios { get; set; }

        private void PopularControles()
        {
            Marcas = marcaRepositoprio.Obter();
            MarcaSelecionada = HttpContext.Current.Request.QueryString["marcaId"];
            if (!string.IsNullOrEmpty(MarcaSelecionada))
            {
                Modelos = modeloRepositorio.ObterMarca(Convert.ToInt32(MarcaSelecionada));
            }
            Cores = corRepositorio.Obter();
        //    Modelos = modeloRepositorio.o;
            Combustiveis = Enum.GetValues(typeof(Combustivel)).Cast<Combustivel>().ToList();
            Cambios = Enum.GetValues(typeof(Cambio)).Cast<Cambio>().ToList();
        }

        public void Gravar() {
            var formulario = HttpContext.Current.Request.Form;
            var veiculo = new Veiculo()
            {
                Ano = Convert.ToInt16(formulario["ano"]),
                Cambio = (Cambio)Convert.ToInt32(formulario["cambio"]),
                Combustivel = (Combustivel)Convert.ToInt32(formulario["combustivel"]),
                Cor = corRepositorio.Obter(Convert.ToInt32(formulario["cor"])),
                Modelo = modeloRepositorio.ObterModelo(Convert.ToInt32(formulario["modelo"])),
                Observacao = formulario["observacao"],
                Placa = formulario["placa"]
        };
            
            veiculoRepositorio.Gravar(veiculo);
        }
    }

}