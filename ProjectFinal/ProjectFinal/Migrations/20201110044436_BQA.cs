using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectFinal.Migrations
{
    public partial class BQA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    Despition = table.Column<string>(nullable: true),
                    Count = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_products_categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Quần" },
                    { 2, "Áo" },
                    { 3, "Giày" },
                    { 4, "Phụ kiện" }
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "CategoryId", "Color", "Count", "Despition", "Name", "Price" },
                values: new object[,]
                {
                    { 2, 1, "Xám", 2, "Jeans được nhập khẩu từ Laos", "Jeans rách", 50.5 },
                    { 1, 2, "Trắng", 3, "Sơ mi được nhập khẩu từ Cambodia", "Sơ Mi", 35.399999999999999 },
                    { 4, 3, "Xanh", 3, "Giày được nhập khẩu từ Lào Cai", "Giày vans", 65.400000000000006 },
                    { 3, 4, "Nâu", 5, "Kính được nhập khẩu từ Brunei", "Kính râm", 65.400000000000006 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_products_CategoryId",
                table: "products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "categories");
        }
    }
}
