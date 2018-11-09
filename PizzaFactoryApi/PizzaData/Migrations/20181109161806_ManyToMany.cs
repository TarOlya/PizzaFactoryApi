using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaData.Migrations
{
    public partial class ManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_Pizza_PizzaName",
                table: "Ingredients");

            migrationBuilder.DropIndex(
                name: "IX_Ingredients_PizzaName",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "PizzaName",
                table: "Ingredients");

            migrationBuilder.AddColumn<string>(
                name: "IngredientName",
                table: "Pizza",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PizzaName",
                table: "Pizza",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pizza_IngredientName",
                table: "Pizza",
                column: "IngredientName");

            migrationBuilder.CreateIndex(
                name: "IX_Pizza_PizzaName",
                table: "Pizza",
                column: "PizzaName");

            migrationBuilder.AddForeignKey(
                name: "FK_Pizza_Ingredients_IngredientName",
                table: "Pizza",
                column: "IngredientName",
                principalTable: "Ingredients",
                principalColumn: "Name",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizza_Pizza_PizzaName",
                table: "Pizza",
                column: "PizzaName",
                principalTable: "Pizza",
                principalColumn: "Name",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizza_Ingredients_IngredientName",
                table: "Pizza");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizza_Pizza_PizzaName",
                table: "Pizza");

            migrationBuilder.DropIndex(
                name: "IX_Pizza_IngredientName",
                table: "Pizza");

            migrationBuilder.DropIndex(
                name: "IX_Pizza_PizzaName",
                table: "Pizza");

            migrationBuilder.DropColumn(
                name: "IngredientName",
                table: "Pizza");

            migrationBuilder.DropColumn(
                name: "PizzaName",
                table: "Pizza");

            migrationBuilder.AddColumn<string>(
                name: "PizzaName",
                table: "Ingredients",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_PizzaName",
                table: "Ingredients",
                column: "PizzaName");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_Pizza_PizzaName",
                table: "Ingredients",
                column: "PizzaName",
                principalTable: "Pizza",
                principalColumn: "Name",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
