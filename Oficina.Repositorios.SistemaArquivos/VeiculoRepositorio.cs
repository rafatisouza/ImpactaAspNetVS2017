﻿using Oficina.Dominios;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Oficina.Repositorios.SistemaArquivos
{
    public class VeiculoRepositorio
    {
        
        static string caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
        ConfigurationManager.AppSettings["caminhoArquivoVeiculo"]);
        XDocument arquivoXml = XDocument.Load(caminhoArquivo);

        public void Gravar<T>(T veiculo)
        {
            var registro = new StringWriter();
            var serilizador = new XmlSerializer(typeof(T));
            
            serilizador.Serialize(registro, veiculo);
            
            arquivoXml.Root.Add(XElement.Parse(registro.ToString()));
            arquivoXml.Save(caminhoArquivo);
        }
        
    }
}
