using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaData.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pizza",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizza", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Cost = table.Column<double>(nullable: false),
                    PizzaName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Ingredients_Pizza_PizzaName",
                        column: x => x.PizzaName,
                        principalTable: "Pizza",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_PizzaName",
                table: "Ingredients",
                column: "PizzaName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Pizza");
        }
    }
}
