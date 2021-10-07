using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurant_API.Migrations
{
    public partial class UpdatedUserKeyTable_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_tables_userID",
                table: "users");

            migrationBuilder.DropIndex(
                name: "IX_users_userID",
                table: "users");

            migrationBuilder.DropColumn(
                name: "userID",
                table: "users");

            migrationBuilder.CreateIndex(
                name: "IX_users_tableID",
                table: "users",
                column: "tableID");

            migrationBuilder.AddForeignKey(
                name: "FK_users_tables_tableID",
                table: "users",
                column: "tableID",
                principalTable: "tables",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_tables_tableID",
                table: "users");

            migrationBuilder.DropIndex(
                name: "IX_users_tableID",
                table: "users");

            migrationBuilder.AddColumn<int>(
                name: "userID",
                table: "users",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_users_userID",
                table: "users",
                column: "userID");

            migrationBuilder.AddForeignKey(
                name: "FK_users_tables_userID",
                table: "users",
                column: "userID",
                principalTable: "tables",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
