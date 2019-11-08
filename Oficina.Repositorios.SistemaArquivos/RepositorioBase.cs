using System;
using System.Configuration;
using System.IO;

namespace Oficina.Repositorios.SistemaArquivos
{
    public class RepositorioBase
    {
        public string CaminhoArquivo { get; }

        public RepositorioBase(string caminhoArquivo)
        {
             CaminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                                        ConfigurationManager.AppSettings[caminhoArquivo]);
        }

        
    }
}