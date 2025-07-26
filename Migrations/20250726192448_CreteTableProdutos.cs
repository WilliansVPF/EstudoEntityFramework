using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EstudoEntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class CreteTableProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "produtos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produtos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "itensPedido",
                columns: table => new
                {
                    PedidosId = table.Column<int>(type: "int", nullable: false),
                    ProdutosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_itensPedido", x => new { x.PedidosId, x.ProdutosId });
                    table.ForeignKey(
                        name: "FK_itensPedido_pedido_PedidosId",
                        column: x => x.PedidosId,
                        principalTable: "pedido",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_itensPedido_produtos_ProdutosId",
                        column: x => x.ProdutosId,
                        principalTable: "produtos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_itensPedido_ProdutosId",
                table: "itensPedido",
                column: "ProdutosId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "itensPedido");

            migrationBuilder.DropTable(
                name: "produtos");
        }
    }
}
