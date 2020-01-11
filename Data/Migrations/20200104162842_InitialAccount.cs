using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Store.Data.Migrations
{
    public partial class InitialAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    email = table.Column<string>(nullable: false),
                    password = table.Column<string>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    first_name = table.Column<string>(nullable: true),
                    last_name = table.Column<string>(nullable: true),
                    birth_day = table.Column<DateTime>(nullable: true),
                    registration = table.Column<string>(maxLength: 10, nullable: true),
                    salary = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "address",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    zip_code = table.Column<string>(nullable: false),
                    number = table.Column<int>(nullable: false),
                    street = table.Column<string>(nullable: false),
                    country = table.Column<string>(nullable: false),
                    state = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: false),
                    neighborhood = table.Column<string>(nullable: true),
                    complement = table.Column<string>(nullable: true),
                    person_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_address", x => x.Id);
                    table.ForeignKey(
                        name: "FK_address_users_person_id",
                        column: x => x.person_id,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "phone",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    country_code = table.Column<string>(nullable: false),
                    area_code = table.Column<string>(nullable: true),
                    number = table.Column<string>(nullable: false),
                    PersonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_phone", x => x.Id);
                    table.ForeignKey(
                        name: "FK_phone_users_PersonId",
                        column: x => x.PersonId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_address_person_id",
                table: "address",
                column: "person_id");

            migrationBuilder.CreateIndex(
                name: "IX_phone_PersonId",
                table: "phone",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "address");

            migrationBuilder.DropTable(
                name: "phone");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
