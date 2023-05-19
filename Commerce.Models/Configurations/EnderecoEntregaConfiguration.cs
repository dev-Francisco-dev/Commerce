using Commerce.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Commerce.Models.Configurations
{
    public class EnderecoEntregaConfiguration : IEntityTypeConfiguration<EnderecoEntrega>
    {
        public void Configure(EntityTypeBuilder<EnderecoEntrega> builder)
        {
            builder.Property(cl => cl.id).IsRequired();
            builder.HasKey(cl =>  cl.id);
            builder.Property(cl => cl.Bairro).HasMaxLength(200);
            builder.Property(cl => cl.Cep).HasMaxLength(200);
            builder.Property(cl => cl.Numero).HasMaxLength(200);
            builder.Property(cl => cl.Logradouro).HasMaxLength(200);
            builder.HasOne(a => a.Cidade).WithMany(a => a.EnderecoEntrega).HasForeignKey(a => a.CidadeId);
                       
        }
    }
}
