using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurant_API.Migrations
{
    public partial class UpdatedUserKeyTable_5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tables_users_userid",
                table: "tables");

            migrationBuilder.DropForeignKey(
                name: "FK_users_tables_tableid",
                table: "users");

            migrationBuilder.DropIndex(
                name: "IX_users_tableid",
                table: "users");

            migrationBuilder.DropIndex(
                name: "IX_tables_userid",
                table: "tables");

            migrationBuilder.DropColumn(
                name: "tableid",
                table: "users");

            migrationBuilder.DropColumn(
                name: "userid",
                table: "tables");

            migrationBuilder.CreateIndex(
                name: "IX_users_table_id",
                table: "users",
                column: "table_id");

            migrationBuilder.CreateIndex(
                name: "IX_tables_user_id",
                table: "tables",
                column: "user_id");

            migrationBuilder.AddForeignKey(
                name: "FK_tables_users_user_id",
                table: "tables",
                column: "user_id",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_users_tables_table_id",
                table: "users",
                column: "table_id",
                principalTable: "tables",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tables_users_user_id",
                table: "tables");

            migrationBuilder.DropForeignKey(
                name: "FK_users_tables_table_id",
                table: "users");

            migrationBuilder.DropIndex(
                name: "IX_users_table_id",
                table: "users");

            migrationBuilder.DropIndex(
                name: "IX_tables_user_id",
                table: "tables");

            migrationBuilder.AddColumn<int>(
                name: "tableid",
                table: "users",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "userid",
                table: "tables",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_users_tableid",
                table: "users",
                column: "tableid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tables_userid",
                table: "tables",
                column: "userid");

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
    }
}
