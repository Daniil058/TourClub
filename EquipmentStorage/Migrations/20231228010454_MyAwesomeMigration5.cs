using Microsoft.EntityFrameworkCore.Migrations;

namespace EquipmentStorage.Migrations
{
    public partial class MyAwesomeMigration5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "interest_user_description",
                columns: table => new
                {
                    interests_id = table.Column<int>(type: "integer", nullable: false),
                    users_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_interest_user_description", x => new { x.interests_id, x.users_id });
                    table.ForeignKey(
                        name: "fk_interest_user_description_interest_interests_id",
                        column: x => x.interests_id,
                        principalTable: "interest",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_interest_user_description_user_description_users_id",
                        column: x => x.users_id,
                        principalTable: "user_description",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_interest_user_description_users_id",
                table: "interest_user_description",
                column: "users_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "interest_user_description");

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
    }
}
