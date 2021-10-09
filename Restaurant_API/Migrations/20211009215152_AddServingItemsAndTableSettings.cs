using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Restaurant_API.Migrations
{
    public partial class AddServingItemsAndTableSettings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "serving_items",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_serving_items", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "table_settings",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    serving_item_id = table.Column<int>(type: "integer", nullable: false),
                    table_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_table_settings", x => x.id);
                    table.ForeignKey(
                        name: "FK_table_settings_serving_items_serving_item_id",
                        column: x => x.serving_item_id,
                        principalTable: "serving_items",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_table_settings_tables_table_id",
                        column: x => x.table_id,
                        principalTable: "tables",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_table_settings_serving_item_id",
                table: "table_settings",
                column: "serving_item_id");

            migrationBuilder.CreateIndex(
                name: "IX_table_settings_table_id",
                table: "table_settings",
                column: "table_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "table_settings");

            migrationBuilder.DropTable(
                name: "serving_items");
        }
    }
}
