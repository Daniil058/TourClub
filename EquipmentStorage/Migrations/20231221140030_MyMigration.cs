using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EquipmentStorage.Migrations
{
    public partial class MyMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "category_equipment",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    orientation = table.Column<string>(type: "text", nullable: false),
                    category = table.Column<string>(type: "text", nullable: false),
                    type = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_category_equipment", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "condition",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_condition", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "role",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_role", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "status_booking",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_status_booking", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "equipment",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    category_equipment_id = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    inventory_number = table.Column<int>(type: "integer", nullable: false),
                    color = table.Column<string>(type: "text", nullable: true),
                    property1 = table.Column<string>(type: "text", nullable: true),
                    property2 = table.Column<string>(type: "text", nullable: true),
                    photo_path = table.Column<string>(type: "text", nullable: true),
                    producer = table.Column<string>(type: "text", nullable: true),
                    weight = table.Column<float>(type: "real", nullable: true),
                    cost = table.Column<float>(type: "real", nullable: true),
                    cost_rent = table.Column<float>(type: "real", nullable: true),
                    production_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    condition_id = table.Column<int>(type: "integer", nullable: false),
                    problems = table.Column<string>(type: "text", nullable: true),
                    storage_location = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_equipment", x => x.id);
                    table.ForeignKey(
                        name: "fk_equipment_category_equipment_category_equipment_id",
                        column: x => x.category_equipment_id,
                        principalTable: "category_equipment",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_equipment_condition_condition_id",
                        column: x => x.condition_id,
                        principalTable: "condition",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "user_auth",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    login = table.Column<string>(type: "text", nullable: false),
                    password = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: true),
                    phone = table.Column<string>(type: "text", nullable: true),
                    role_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_user_auth", x => x.id);
                    table.ForeignKey(
                        name: "fk_user_auth_role_role_id",
                        column: x => x.role_id,
                        principalTable: "role",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "user_description",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    surname = table.Column<string>(type: "text", nullable: false),
                    patronymic = table.Column<string>(type: "text", nullable: true),
                    birthday = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    role_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_user_description", x => x.id);
                    table.ForeignKey(
                        name: "fk_user_description_role_role_id",
                        column: x => x.role_id,
                        principalTable: "role",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "booking",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    request_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    start_booking_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    finish_booking_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    user_id = table.Column<int>(type: "integer", nullable: false),
                    equipment_id = table.Column<int>(type: "integer", nullable: true),
                    status_booking_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_booking", x => x.id);
                    table.ForeignKey(
                        name: "fk_booking_equipment_equipment_id",
                        column: x => x.equipment_id,
                        principalTable: "equipment",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_booking_status_booking_status_booking_id",
                        column: x => x.status_booking_id,
                        principalTable: "status_booking",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_booking_user_description_user_id",
                        column: x => x.user_id,
                        principalTable: "user_description",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "user_interest",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_user_interest", x => x.id);
                    table.ForeignKey(
                        name: "fk_user_interest_user_description_user_id",
                        column: x => x.user_id,
                        principalTable: "user_description",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "interest",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    user_description_id = table.Column<int>(type: "integer", nullable: true),
                    user_interest_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_interest", x => x.id);
                    table.ForeignKey(
                        name: "fk_interest_user_description_user_description_id",
                        column: x => x.user_description_id,
                        principalTable: "user_description",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_interest_user_interest_user_interest_id",
                        column: x => x.user_interest_id,
                        principalTable: "user_interest",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "ix_booking_equipment_id",
                table: "booking",
                column: "equipment_id");

            migrationBuilder.CreateIndex(
                name: "ix_booking_status_booking_id",
                table: "booking",
                column: "status_booking_id");

            migrationBuilder.CreateIndex(
                name: "ix_booking_user_id",
                table: "booking",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_equipment_category_equipment_id",
                table: "equipment",
                column: "category_equipment_id");

            migrationBuilder.CreateIndex(
                name: "ix_equipment_condition_id",
                table: "equipment",
                column: "condition_id");

            migrationBuilder.CreateIndex(
                name: "ix_interest_user_description_id",
                table: "interest",
                column: "user_description_id");

            migrationBuilder.CreateIndex(
                name: "ix_interest_user_interest_id",
                table: "interest",
                column: "user_interest_id");

            migrationBuilder.CreateIndex(
                name: "ix_user_auth_role_id",
                table: "user_auth",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "ix_user_description_role_id",
                table: "user_description",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "ix_user_interest_user_id",
                table: "user_interest",
                column: "user_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "booking");

            migrationBuilder.DropTable(
                name: "interest");

            migrationBuilder.DropTable(
                name: "user_auth");

            migrationBuilder.DropTable(
                name: "equipment");

            migrationBuilder.DropTable(
                name: "status_booking");

            migrationBuilder.DropTable(
                name: "user_interest");

            migrationBuilder.DropTable(
                name: "category_equipment");

            migrationBuilder.DropTable(
                name: "condition");

            migrationBuilder.DropTable(
                name: "user_description");

            migrationBuilder.DropTable(
                name: "role");
        }
    }
}
