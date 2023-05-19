using Commerce.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Commerce.Models.Configurations
{
    public class EstadoConfiguration : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder.Property(a => a.Id).IsRequired();
            builder.HasKey(a => a.Id);
            builder.HasMany(a => a.Cidades).WithOne(a => a.Estado).HasForeignKey(a => a.EstadoId);    
        }

    }
}