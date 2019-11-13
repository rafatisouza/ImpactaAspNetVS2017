using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViagemOnline.Dominio;

namespace ViagensOnline.Repositorios.SqlServel
{
    public class ViagensOnlineDbContext : DbContext
    {
        public DbSet<Destino> Destinos { get; set; }

        public ViagensOnlineDbContext():base("ViagensOnlineConnectionString")
        {

        }
        
    }
}
