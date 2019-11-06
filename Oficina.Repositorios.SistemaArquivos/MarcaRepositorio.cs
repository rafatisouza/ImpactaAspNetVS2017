using Oficina.Dominios;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;

namespace Oficina.Repositorios.SistemaArquivos
{
    public class MarcaRepositorio
    {


        //private string CaminhoArquivo = ConfigurationManager.AppSettings["caminhoArquivoMarca"];

        static string CaminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
        ConfigurationManager.AppSettings["caminhoArquivoMarca"]);
        
        //private string CaminhoArquivo = @"Dado/marca.txt";
        public List<Marca> Obter()
        {
            var marcas = new List<Marca>();
            foreach (var linha in File.ReadAllLines(CaminhoArquivo))
            {
                var conteudos = linha.Split('|').ToArray();
                Marca Marca = new Marca();
                Marca.Id = Convert.ToInt16(conteudos[0]);
                Marca.Nome = conteudos[1];

                marcas.Add(Marca);

            }

            return marcas;
        }

        public Marca Obter(int id)
        {
            var todos = Obter();

            Marca retorno = todos.SingleOrDefault(x => x.Id == id);

            return retorno;
        }
    }
}
