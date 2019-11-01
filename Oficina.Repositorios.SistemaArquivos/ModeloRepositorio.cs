using Oficina.Dominios;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Oficina.Repositorios.SistemaArquivos
{
    public class ModeloRepositorio
    {
        XDocument arquivoXml = XDocument.Load(ConfigurationManager.AppSettings["caminhoArquivoModelo"]);
        public List<Modelo> ObterMarca(int marcaId)
        {
            var modelos = new List<Modelo>();
            var modelo = new Modelo();
            var marcaRepositorio = new MarcaRepositorio().Obter(marcaId);
            foreach (var elemento in arquivoXml.Descendants("modelo"))
            {
                if(Convert.ToInt16(elemento.Element("marcaId").Value) == marcaId)
                {
                    modelo.Id = Convert.ToInt32(elemento.Element("id").Value);
                    modelo.Nome = elemento.Element("nome").Value;
                    modelo.Marca = marcaRepositorio;
                    modelos.Add(modelo);
                }                   
            }
            return modelos;
        }

        public Modelo ObterModelo(int modeloId)
        {
            Modelo modelo = null;
                        
            foreach (var elemento in arquivoXml.Descendants("modelo"))
            {
                var marcaRepositorio = new MarcaRepositorio().Obter(Convert.ToInt16(elemento.Element("id").Value));
                if (Convert.ToInt16(elemento.Element("Id").Value) == modeloId)
                {
                    modelo.Id = Convert.ToInt32(elemento.Element("id").Value);
                    modelo.Nome = elemento.Element("nome").Value;
                    modelo.Marca = marcaRepositorio;
                    break;
                }
            }
            return modelo;
        }
    }
}
