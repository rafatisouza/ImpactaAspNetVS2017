using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViagemOnline.Dominio;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ViagensOnline.Repositorios.SqlServel
{
    public class ViagensOnlineDbContext : DbContext
    {
        public DbSet<Destino> Destinos { get; set; }

        public ViagensOnlineDbContext():base("ViagensOnlineConnectionString")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

    }
}
