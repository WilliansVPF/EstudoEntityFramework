using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EstudoEntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableEnderecos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "enderecos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    estado = table.Column<string>(type: "nvarchar(2)", nullable: false),
                    cidade = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    bairro = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    logradouro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numero = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    clienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_enderecos", x => x.id);
                    table.ForeignKey(
                        name: "FK_enderecos_clientesTypeConfiguration_clienteId",
                        column: x => x.clienteId,
                        principalTable: "clientesTypeConfiguration",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_enderecos_clienteId",
                table: "enderecos",
                column: "clienteId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "enderecos");
        }
    }
}
