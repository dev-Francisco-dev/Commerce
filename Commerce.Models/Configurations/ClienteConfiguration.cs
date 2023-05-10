using Commerce.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Commerce.Models.Configurations
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.Property(cl => cl.Id).IsRequired();
            builder.HasKey(cl => cl.Id);
            builder.Property(cl => cl.Name).HasMaxLength(200);
            builder.Property(cl => cl.CpfOuCnpj).HasMaxLength(13);
            builder.HasMany(cl => cl.Telefones).WithOne(tl => tl.Cliente).HasForeignKey(tl => tl.ClienteId);
        }
    }
}
