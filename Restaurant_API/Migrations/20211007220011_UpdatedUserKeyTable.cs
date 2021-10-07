using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurant_API.Migrations
{
    public partial class UpdatedUserKeyTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "tableID",
                table: "users",
                type: "integer",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_tables_userID",
                table: "users");

            migrationBuilder.DropIndex(
                name: "IX_users_userID",
                table: "users");

            migrationBuilder.DropColumn(
                name: "tableID",
                table: "users");

            migrationBuilder.DropColumn(
                name: "userID",
                table: "users");
        }
    }
}
