using Loja.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;
using Loja.Repositorios.SqlServer.ModelConfiguration;

namespace Loja.Repositorios.SqlServer
{
    public class LojaDbContext : DbContext
    {
        public LojaDbContext() : base("lojaSqlServer")
        {
            //1 - Enable-Migrations
            //2 - Add-Mrigration NomeDaModificação
            //3 - Update-Database
        }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedidos> Peditos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            //Alterar schema
            //modelBuilder.HasDefaultSchema("LJ");

            modelBuilder.Configurations.Add(new ProdutoConfiguration());
            modelBuilder.Configurations.Add(new CategoriaConfiguration());
            modelBuilder.Configurations.Add(new ProdutoImagemConfiguration());
            
            
            base.OnModelCreating(modelBuilder);
        }

        public System.Data.Entity.DbSet<Loja.Dominio.ProdutoImagem> ProdutoImagems { get; set; }
    }
}
