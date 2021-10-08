using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurant_API.Migrations
{
    public partial class EditPortionAndDish : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Portion_Dish_dish_id",
                table: "Portion");

            migrationBuilder.DropForeignKey(
                name: "FK_Portion_tables_table_id",
                table: "Portion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Portion",
                table: "Portion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dish",
                table: "Dish");

            migrationBuilder.RenameTable(
                name: "Portion",
                newName: "portions");

            migrationBuilder.RenameTable(
                name: "Dish",
                newName: "dishes");

            migrationBuilder.RenameIndex(
                name: "IX_Portion_table_id",
                table: "portions",
                newName: "IX_portions_table_id");

            migrationBuilder.RenameIndex(
                name: "IX_Portion_dish_id",
                table: "portions",
                newName: "IX_portions_dish_id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "dishes",
                newName: "name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_portions",
                table: "portions",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_dishes",
                table: "dishes",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_portions_dishes_dish_id",
                table: "portions",
                column: "dish_id",
                principalTable: "dishes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_portions_tables_table_id",
                table: "portions",
                column: "table_id",
                principalTable: "tables",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_portions_dishes_dish_id",
                table: "portions");

            migrationBuilder.DropForeignKey(
                name: "FK_portions_tables_table_id",
                table: "portions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_portions",
                table: "portions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_dishes",
                table: "dishes");

            migrationBuilder.RenameTable(
                name: "portions",
                newName: "Portion");

            migrationBuilder.RenameTable(
                name: "dishes",
                newName: "Dish");

            migrationBuilder.RenameIndex(
                name: "IX_portions_table_id",
                table: "Portion",
                newName: "IX_Portion_table_id");

            migrationBuilder.RenameIndex(
                name: "IX_portions_dish_id",
                table: "Portion",
                newName: "IX_Portion_dish_id");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Dish",
                newName: "Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Portion",
                table: "Portion",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dish",
                table: "Dish",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Portion_Dish_dish_id",
                table: "Portion",
                column: "dish_id",
                principalTable: "Dish",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Portion_tables_table_id",
                table: "Portion",
                column: "table_id",
                principalTable: "tables",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
