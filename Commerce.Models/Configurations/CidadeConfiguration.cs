﻿using Commerce.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Commerce.Models.Configurations
{
    public class CidadeConfiguration : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> builder)
        {
            builder.Property(a => a.Id).IsRequired();
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Nome).HasMaxLength(200);
        }
    }
}
