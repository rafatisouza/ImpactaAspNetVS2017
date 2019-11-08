using Oficina.Dominios;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
    using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaArquivos
{
    public class CorRepositorio : RepositorioBase
    {
       
        public CorRepositorio() : base("caminhoArquivoCor")
        {
            
        }
        
        //ToDO: 00 - polimorfismo por sobrecarga
        public List <Cor> Obter()
        {            
            var cores = new List<Cor>();            
            foreach (var linha in File.ReadAllLines(CaminhoArquivo))   
            {
                Cor cor = new Cor();
                cor.Id =  Convert.ToInt16(linha.Substring(0, 5));
                cor.Nome = linha.Substring(5);

                cores.Add(cor);

            }

            return cores;
        }

        public Cor Obter(int id)
        {
            var todos = Obter();
            
           Cor retorno = todos.SingleOrDefault(x => x.Id == id);

            return retorno;
        }
    }
    
}
