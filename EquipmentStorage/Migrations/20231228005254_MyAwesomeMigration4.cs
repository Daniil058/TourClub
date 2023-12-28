using Microsoft.EntityFrameworkCore.Migrations;

namespace EquipmentStorage.Migrations
{
    public partial class MyAwesomeMigration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_user_interest_user_description_user_description_id",
                table: "user_interest");

            migrationBuilder.DropIndex(
                name: "ix_user_interest_user_description_id",
                table: "user_interest");

            migrationBuilder.DropColumn(
                name: "user_description_id",
                table: "user_interest");

            migrationBuilder.AddColumn<int>(
                name: "user_description_id",
                table: "interest",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "ix_interest_user_description_id",
                table: "interest",
                column: "user_description_id");

            migrationBuilder.AddForeignKey(
                name: "fk_interest_user_description_user_description_id",
                table: "interest",
                column: "user_description_id",
                principalTable: "user_description",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_interest_user_description_user_description_id",
                table: "interest");

            migrationBuilder.DropIndex(
                name: "ix_interest_user_description_id",
                table: "interest");

            migrationBuilder.DropColumn(
                name: "user_description_id",
                table: "interest");

            migrationBuilder.AddColumn<int>(
                name: "user_description_id",
                table: "user_interest",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "ix_user_interest_user_description_id",
                table: "user_interest",
                column: "user_description_id");

            migrationBuilder.AddForeignKey(
                name: "fk_user_interest_user_description_user_description_id",
                table: "user_interest",
                column: "user_description_id",
                principalTable: "user_description",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
