using Commerce.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Commerce.Models.Configurations
{
    public class TelefoneConfiguration : IEntityTypeConfiguration<Telefone>
    {
        public void Configure(EntityTypeBuilder<Telefone> builder)
        {
            builder.Property(tl => tl.Id).IsRequired();
            builder.HasKey(tl => tl.Id);
            builder.Property(cl => cl.Celular).HasMaxLength(15);
            builder.Property(cl => cl.Comercial).HasMaxLength(15);
            
                    
        }
    }
}
