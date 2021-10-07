using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurant_API.Migrations
{
    public partial class UpdatedUserKeyTable_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tables_users_userID",
                table: "tables");

            migrationBuilder.DropForeignKey(
                name: "FK_users_tables_tableID",
                table: "users");

            migrationBuilder.RenameColumn(
                name: "tableID",
                table: "users",
                newName: "tableid");

            migrationBuilder.RenameIndex(
                name: "IX_users_tableID",
                table: "users",
                newName: "IX_users_tableid");

            migrationBuilder.RenameColumn(
                name: "userID",
                table: "tables",
                newName: "userid");

            migrationBuilder.RenameIndex(
                name: "IX_tables_userID",
                table: "tables",
                newName: "IX_tables_userid");

            migrationBuilder.AddForeignKey(
                name: "FK_tables_users_userid",
                table: "tables",
                column: "userid",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_users_tables_tableid",
                table: "users",
                column: "tableid",
                principalTable: "tables",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tables_users_userid",
                table: "tables");

            migrationBuilder.DropForeignKey(
                name: "FK_users_tables_tableid",
                table: "users");

            migrationBuilder.RenameColumn(
                name: "tableid",
                table: "users",
                newName: "tableID");

            migrationBuilder.RenameIndex(
                name: "IX_users_tableid",
                table: "users",
                newName: "IX_users_tableID");

            migrationBuilder.RenameColumn(
                name: "userid",
                table: "tables",
                newName: "userID");

            migrationBuilder.RenameIndex(
                name: "IX_tables_userid",
                table: "tables",
                newName: "IX_tables_userID");

            migrationBuilder.AddForeignKey(
                name: "FK_tables_users_userID",
                table: "tables",
                column: "userID",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_users_tables_tableID",
                table: "users",
                column: "tableID",
                principalTable: "tables",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
