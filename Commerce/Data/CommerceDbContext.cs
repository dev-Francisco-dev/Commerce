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
        public DbSet<EnderecoEntrega> EnderecoEntregas { get; set; }
        public DbSet<Cidade> Cidades { get; set; }

        protected override void OnModelCreating(ModelBuilder Modelbuider)
        {
            Modelbuider.ApplyConfiguration<Cliente>(new ClienteConfiguration());
            Modelbuider.ApplyConfiguration<Telefone>(new TelefoneConfiguration());
            Modelbuider.ApplyConfiguration<EnderecoEntrega>(new EnderecoEntregaConfiguration());
            Modelbuider.ApplyConfiguration<Cidade>(new CidadeConfiguration());
        }

    }
}
