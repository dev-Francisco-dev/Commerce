﻿// <auto-generated />
using Commerce.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Commerce.API.Migrations
{
    [DbContext(typeof(CommerceDbContext))]
    partial class CommerceDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Commerce.Models.Domain.Cidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EstadoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("EstadoId");

                    b.ToTable("Cidades");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EstadoId = 1,
                            Nome = "Osasco"
                        },
                        new
                        {
                            Id = 2,
                            EstadoId = 2,
                            Nome = "Barueri"
                        },
                        new
                        {
                            Id = 3,
                            EstadoId = 3,
                            Nome = "Santana de Parnaiba"
                        });
                });

            modelBuilder.Entity("Commerce.Models.Domain.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CpfOuCnpj")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CpfOuCnpj = "31421991870",
                            Email = "Ninocz@hotmail.com",
                            Name = "Francisco Alixandre"
                        },
                        new
                        {
                            Id = 2,
                            CpfOuCnpj = "32145698774",
                            Email = "marcela@gmail.com",
                            Name = "Marcela Martins"
                        },
                        new
                        {
                            Id = 3,
                            CpfOuCnpj = "78945612354",
                            Email = "gio@gmail.com",
                            Name = "Giovanna ferreia"
                        },
                        new
                        {
                            Id = 4,
                            CpfOuCnpj = "45632198754",
                            Email = "Alice@gmail.com",
                            Name = "Alice"
                        });
                });

            modelBuilder.Entity("Commerce.Models.Domain.EnderecoEntrega", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("CidadeId")
                        .HasColumnType("int");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("id");

                    b.HasIndex("CidadeId");

                    b.HasIndex("ClienteId");

                    b.ToTable("EnderecoEntregas");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Bairro = "Mutinga",
                            Cep = "64512-230",
                            CidadeId = 1,
                            ClienteId = 1,
                            Complemento = "Casa",
                            Logradouro = "Avenida",
                            Numero = "100"
                        },
                        new
                        {
                            id = 2,
                            Bairro = "Piratininga",
                            Cep = "47851-365",
                            CidadeId = 1,
                            ClienteId = 2,
                            Complemento = "Ape",
                            Logradouro = "rua",
                            Numero = "200"
                        },
                        new
                        {
                            id = 3,
                            Bairro = "Veloso",
                            Cep = "65214-200",
                            CidadeId = 3,
                            ClienteId = 2,
                            Complemento = "Ape",
                            Logradouro = "Avenida",
                            Numero = "5621"
                        },
                        new
                        {
                            id = 4,
                            Bairro = "Centro",
                            Cep = "89564-780",
                            CidadeId = 3,
                            ClienteId = 3,
                            Complemento = "Casa",
                            Logradouro = "rua",
                            Numero = "4711"
                        },
                        new
                        {
                            id = 5,
                            Bairro = "Remedios",
                            Cep = "32569-210",
                            CidadeId = 2,
                            ClienteId = 3,
                            Complemento = "Ape",
                            Logradouro = "Avenida",
                            Numero = "156"
                        },
                        new
                        {
                            id = 6,
                            Bairro = "Santo Antonio",
                            Cep = "21452-100",
                            CidadeId = 2,
                            ClienteId = 3,
                            Complemento = "Ape",
                            Logradouro = "Avenida",
                            Numero = "65241"
                        },
                        new
                        {
                            id = 7,
                            Bairro = "Mutinga",
                            Cep = "06286-210",
                            CidadeId = 1,
                            ClienteId = 1,
                            Complemento = "Casa",
                            Logradouro = "rua",
                            Numero = "342"
                        });
                });

            modelBuilder.Entity("Commerce.Models.Domain.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Estados");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            nome = "Osasco"
                        },
                        new
                        {
                            Id = 2,
                            nome = "São Paulo"
                        },
                        new
                        {
                            Id = 3,
                            nome = "Santana de Parnaiba"
                        });
                });

            modelBuilder.Entity("Commerce.Models.Domain.Telefone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Comercial")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Telefones");
                });

            modelBuilder.Entity("Commerce.Models.Domain.Cidade", b =>
                {
                    b.HasOne("Commerce.Models.Domain.Estado", "Estado")
                        .WithMany("Cidades")
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estado");
                });

            modelBuilder.Entity("Commerce.Models.Domain.EnderecoEntrega", b =>
                {
                    b.HasOne("Commerce.Models.Domain.Cidade", "Cidade")
                        .WithMany("EnderecoEntrega")
                        .HasForeignKey("CidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Commerce.Models.Domain.Cliente", "Cliente")
                        .WithMany("enderecoEntregas")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cidade");

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Commerce.Models.Domain.Telefone", b =>
                {
                    b.HasOne("Commerce.Models.Domain.Cliente", "Cliente")
                        .WithMany("Telefones")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Commerce.Models.Domain.Cidade", b =>
                {
                    b.Navigation("EnderecoEntrega");
                });

            modelBuilder.Entity("Commerce.Models.Domain.Cliente", b =>
                {
                    b.Navigation("Telefones");

                    b.Navigation("enderecoEntregas");
                });

            modelBuilder.Entity("Commerce.Models.Domain.Estado", b =>
                {
                    b.Navigation("Cidades");
                });
#pragma warning restore 612, 618
        }
    }
}
