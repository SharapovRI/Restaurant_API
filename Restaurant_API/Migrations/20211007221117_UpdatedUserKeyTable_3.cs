using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurant_API.Migrations
{
    public partial class UpdatedUserKeyTable_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tables_users_userID",
                table: "tables");

            migrationBuilder.DropForeignKey(
                name: "FK_users_tables_tableID",
                table: "users");

            migrationBuilder.DropIndex(
                name: "IX_users_tableID",
                table: "users");

            migrationBuilder.AlterColumn<int>(
                name: "tableID",
                table: "users",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "table_id",
                table: "users",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "userID",
                table: "tables",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "user_id",
                table: "tables",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_users_tableID",
                table: "users",
                column: "tableID",
                unique: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tables_users_userID",
                table: "tables");

            migrationBuilder.DropForeignKey(
                name: "FK_users_tables_tableID",
                table: "users");

            migrationBuilder.DropIndex(
                name: "IX_users_tableID",
                table: "users");

            migrationBuilder.DropColumn(
                name: "table_id",
                table: "users");

            migrationBuilder.DropColumn(
                name: "user_id",
                table: "tables");

            migrationBuilder.AlterColumn<int>(
                name: "tableID",
                table: "users",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "userID",
                table: "tables",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_users_tableID",
                table: "users",
                column: "tableID");

            migrationBuilder.AddForeignKey(
                name: "FK_tables_users_userID",
                table: "tables",
                column: "userID",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_users_tables_tableID",
                table: "users",
                column: "tableID",
                principalTable: "tables",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
