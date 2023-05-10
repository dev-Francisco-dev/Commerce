using Commerce.Models.Domain;
using Commerce.Models.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Commerce.API.Data
{
    public class CommerceDbContext: DbContext
    {
        public CommerceDbContext(DbContextOptions<CommerceDbContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Telefone> Telefones { get; set; }

        protected override void OnModelCreating(ModelBuilder Modelbuider)
        {
            Modelbuider.ApplyConfiguration<Cliente>(new ClienteConfiguration());
            Modelbuider.ApplyConfiguration<Telefone>(new TelefoneConfiguration());
        }

    }
}
