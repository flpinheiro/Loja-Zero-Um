using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Store.Data.Migrations
{
    public partial class initialSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "Discriminator", "email", "password", "birth_day", "first_name", "last_name" },
                values: new object[] { 1, "Client", "flpinheiro@gmail.com", "12345678", new DateTime(1985, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Felipe Luís", "Pinheiro" });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "Discriminator", "email", "password", "birth_day", "first_name", "last_name", "registration", "salary" },
                values: new object[] { 2, "Employee", "mrosa@gmail.com", "a mais gata", new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marcelle", "Rosa", "1234568", 3500m });

            migrationBuilder.InsertData(
                table: "address",
                columns: new[] { "Id", "city", "complement", "country", "neighborhood", "number", "person_id", "state", "street", "zip_code" },
                values: new object[,]
                {
                    { 1, "Brasília", null, "Brasil", "Taguatinga", 25, 1, "DF", "QNB 03", "72115030" },
                    { 2, "Brasilia", "You Life Style, ap 309", "Brasil", "Aguas Claras", 18, 2, "DF", "Av araucarias", "71153-410" }
                });

            migrationBuilder.InsertData(
                table: "phone",
                columns: new[] { "Id", "area_code", "country_code", "number", "PersonId" },
                values: new object[,]
                {
                    { 1, "61", "55", "995599415", 1 },
                    { 2, "61", "55", "996767867", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "address",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "address",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "phone",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "phone",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
