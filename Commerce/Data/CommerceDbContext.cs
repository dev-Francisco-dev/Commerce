using Commerce.Models.Domain;
using Commerce.Models.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Commerce.API.Data
{
    public class CommerceDbContext : DbContext
    {
        public CommerceDbContext(DbContextOptions<CommerceDbContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
        public DbSet<EnderecoEntrega> EnderecoEntregas { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Estado> Estados { get; set; }

        protected override void OnModelCreating(ModelBuilder Modelbuider)
        {
            Modelbuider.ApplyConfiguration<Cliente>(new ClienteConfiguration());
            Modelbuider.ApplyConfiguration<Telefone>(new TelefoneConfiguration());
            Modelbuider.ApplyConfiguration<EnderecoEntrega>(new EnderecoEntregaConfiguration());
            Modelbuider.ApplyConfiguration<Cidade>(new CidadeConfiguration());

            Modelbuider.Entity<Cliente>().HasData(
                new Cliente() { Id = 1, Name = "Francisco Alixandre", CpfOuCnpj = "31421991870", Email = "Ninocz@hotmail.com" },
                new Cliente() { Id = 2, Name = "Marcela Martins", CpfOuCnpj = "32145698774", Email = "marcela@gmail.com" },
                new Cliente() { Id = 3, Name = "Giovanna ferreia", CpfOuCnpj = "78945612354", Email = "gio@gmail.com" },
                new Cliente() { Id = 4, Name = "Alice", CpfOuCnpj = "45632198754", Email = "Alice@gmail.com" });

            Modelbuider.Entity<Cidade>().HasData(
                new Cidade() { Id = 1, EstadoId = 1,  Nome = "Osasco" },
                new Cidade() { Id = 2, EstadoId = 2, Nome = "Barueri" },
                new Cidade() { Id = 3, EstadoId = 3, Nome = "Santana de Parnaiba" }
                );

            Modelbuider.Entity<EnderecoEntrega>().HasData(
                 
                 new EnderecoEntrega() { id = 1, CidadeId = 1, ClienteId = 1, Bairro = "Mutinga", Cep = "64512-230", Complemento = "Casa", Numero = "100", Logradouro = "Avenida" },
                 new EnderecoEntrega() { id = 2, CidadeId = 1, ClienteId = 2, Bairro = "Piratininga", Cep = "47851-365", Complemento = "Ape", Numero = "200", Logradouro = "rua" },
                 new EnderecoEntrega() { id = 3, CidadeId = 3, ClienteId = 2, Bairro = "Veloso", Cep = "65214-200", Complemento = "Ape", Numero = "5621", Logradouro = "Avenida" },
                 new EnderecoEntrega() { id = 4, CidadeId = 3, ClienteId = 3, Bairro = "Centro", Cep = "89564-780", Complemento = "Casa", Numero = "4711", Logradouro = "rua" },
                 new EnderecoEntrega() { id = 5, CidadeId = 2, ClienteId = 3, Bairro = "Remedios", Cep = "32569-210", Complemento = "Ape", Numero = "156", Logradouro = "Avenida" },
                 new EnderecoEntrega() { id = 6, CidadeId = 2, ClienteId = 3, Bairro = "Santo Antonio", Cep = "21452-100", Complemento = "Ape", Numero = "65241", Logradouro = "Avenida" },
                 new EnderecoEntrega() { id = 7, CidadeId = 1, ClienteId = 1, Bairro = "Mutinga", Cep = "06286-210", Complemento = "Casa", Numero = "342", Logradouro = "rua" });

            Modelbuider.Entity<Estado>().HasData(
                new Estado() { Id = 1, nome = "Osasco" },
                new Estado() { Id = 2, nome = "São Paulo" },
                new Estado() { Id = 3, nome = "Santana de Parnaiba" }
                );
        }

    }
}
