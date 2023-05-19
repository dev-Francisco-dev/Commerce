using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Commerce.API.Migrations
{
    /// <inheritdoc />
    public partial class BancoInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CpfOuCnpj = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Telefones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    Celular = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Comercial = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Telefones_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    EstadoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cidades_Estados_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EnderecoEntregas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    CidadeId = table.Column<int>(type: "int", nullable: false),
                    Logradouro = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Cep = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnderecoEntregas", x => x.id);
                    table.ForeignKey(
                        name: "FK_EnderecoEntregas_Cidades_CidadeId",
                        column: x => x.CidadeId,
                        principalTable: "Cidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EnderecoEntregas_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "CpfOuCnpj", "Email", "Name" },
                values: new object[,]
                {
                    { 1, "31421991870", "Ninocz@hotmail.com", "Francisco Alixandre" },
                    { 2, "32145698774", "marcela@gmail.com", "Marcela Martins" },
                    { 3, "78945612354", "gio@gmail.com", "Giovanna ferreia" },
                    { 4, "45632198754", "Alice@gmail.com", "Alice" }
                });

            migrationBuilder.InsertData(
                table: "Estados",
                columns: new[] { "Id", "nome" },
                values: new object[,]
                {
                    { 1, "Osasco" },
                    { 2, "São Paulo" },
                    { 3, "Santana de Parnaiba" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { 1, 1, "Osasco" },
                    { 2, 2, "Barueri" },
                    { 3, 3, "Santana de Parnaiba" }
                });

            migrationBuilder.InsertData(
                table: "EnderecoEntregas",
                columns: new[] { "id", "Bairro", "Cep", "CidadeId", "ClienteId", "Complemento", "Logradouro", "Numero" },
                values: new object[,]
                {
                    { 1, "Mutinga", "64512-230", 1, 1, "Casa", "Avenida", "100" },
                    { 2, "Piratininga", "47851-365", 1, 2, "Ape", "rua", "200" },
                    { 3, "Veloso", "65214-200", 3, 2, "Ape", "Avenida", "5621" },
                    { 4, "Centro", "89564-780", 3, 3, "Casa", "rua", "4711" },
                    { 5, "Remedios", "32569-210", 2, 3, "Ape", "Avenida", "156" },
                    { 6, "Santo Antonio", "21452-100", 2, 3, "Ape", "Avenida", "65241" },
                    { 7, "Mutinga", "06286-210", 1, 1, "Casa", "rua", "342" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cidades_EstadoId",
                table: "Cidades",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_EnderecoEntregas_CidadeId",
                table: "EnderecoEntregas",
                column: "CidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_EnderecoEntregas_ClienteId",
                table: "EnderecoEntregas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefones_ClienteId",
                table: "Telefones",
                column: "ClienteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EnderecoEntregas");

            migrationBuilder.DropTable(
                name: "Telefones");

            migrationBuilder.DropTable(
                name: "Cidades");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Estados");
        }
    }
}
