using Microsoft.EntityFrameworkCore.Migrations;

namespace EquipmentStorage.Migrations
{
    public partial class MyAwesomeMigration7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_booking_user_description_user_id",
                table: "booking");

            migrationBuilder.DropForeignKey(
                name: "fk_interest_user_interest_user_interest_id",
                table: "interest");

            migrationBuilder.DropForeignKey(
                name: "fk_interest_user_description_interest_interests_id",
                table: "interest_user_description");

            migrationBuilder.DropForeignKey(
                name: "fk_interest_user_description_user_description_users_id",
                table: "interest_user_description");

            migrationBuilder.DropForeignKey(
                name: "fk_user_description_role_role_id",
                table: "user_description");

            migrationBuilder.DropPrimaryKey(
                name: "pk_user_interest",
                table: "user_interest");

            migrationBuilder.DropPrimaryKey(
                name: "pk_user_description",
                table: "user_description");

            migrationBuilder.DropPrimaryKey(
                name: "pk_interest",
                table: "interest");

            migrationBuilder.RenameTable(
                name: "user_interest",
                newName: "user_interests");

            migrationBuilder.RenameTable(
                name: "user_description",
                newName: "user_descriptions");

            migrationBuilder.RenameTable(
                name: "interest",
                newName: "interests");

            migrationBuilder.RenameIndex(
                name: "ix_user_description_role_id",
                table: "user_descriptions",
                newName: "ix_user_descriptions_role_id");

            migrationBuilder.RenameIndex(
                name: "ix_interest_user_interest_id",
                table: "interests",
                newName: "ix_interests_user_interest_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_user_interests",
                table: "user_interests",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_user_descriptions",
                table: "user_descriptions",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_interests",
                table: "interests",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_booking_user_descriptions_user_id",
                table: "booking",
                column: "user_id",
                principalTable: "user_descriptions",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_interest_user_description_interests_interests_id",
                table: "interest_user_description",
                column: "interests_id",
                principalTable: "interests",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_interest_user_description_user_descriptions_users_id",
                table: "interest_user_description",
                column: "users_id",
                principalTable: "user_descriptions",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_interests_user_interests_user_interest_id",
                table: "interests",
                column: "user_interest_id",
                principalTable: "user_interests",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_user_descriptions_role_role_id",
                table: "user_descriptions",
                column: "role_id",
                principalTable: "role",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_booking_user_descriptions_user_id",
                table: "booking");

            migrationBuilder.DropForeignKey(
                name: "fk_interest_user_description_interests_interests_id",
                table: "interest_user_description");

            migrationBuilder.DropForeignKey(
                name: "fk_interest_user_description_user_descriptions_users_id",
                table: "interest_user_description");

            migrationBuilder.DropForeignKey(
                name: "fk_interests_user_interests_user_interest_id",
                table: "interests");

            migrationBuilder.DropForeignKey(
                name: "fk_user_descriptions_role_role_id",
                table: "user_descriptions");

            migrationBuilder.DropPrimaryKey(
                name: "pk_user_interests",
                table: "user_interests");

            migrationBuilder.DropPrimaryKey(
                name: "pk_user_descriptions",
                table: "user_descriptions");

            migrationBuilder.DropPrimaryKey(
                name: "pk_interests",
                table: "interests");

            migrationBuilder.RenameTable(
                name: "user_interests",
                newName: "user_interest");

            migrationBuilder.RenameTable(
                name: "user_descriptions",
                newName: "user_description");

            migrationBuilder.RenameTable(
                name: "interests",
                newName: "interest");

            migrationBuilder.RenameIndex(
                name: "ix_user_descriptions_role_id",
                table: "user_description",
                newName: "ix_user_description_role_id");

            migrationBuilder.RenameIndex(
                name: "ix_interests_user_interest_id",
                table: "interest",
                newName: "ix_interest_user_interest_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_user_interest",
                table: "user_interest",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_user_description",
                table: "user_description",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_interest",
                table: "interest",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_booking_user_description_user_id",
                table: "booking",
                column: "user_id",
                principalTable: "user_description",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_interest_user_interest_user_interest_id",
                table: "interest",
                column: "user_interest_id",
                principalTable: "user_interest",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_interest_user_description_interest_interests_id",
                table: "interest_user_description",
                column: "interests_id",
                principalTable: "interest",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_interest_user_description_user_description_users_id",
                table: "interest_user_description",
                column: "users_id",
                principalTable: "user_description",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_user_description_role_role_id",
                table: "user_description",
                column: "role_id",
                principalTable: "role",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
