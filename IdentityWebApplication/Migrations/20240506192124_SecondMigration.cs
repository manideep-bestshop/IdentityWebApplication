using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IdentityWebApplication.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "671d6a2c-e13e-427a-9a37-d5781b691d3d", null, "admin", "admin" },
                    { "c104855e-a33e-4045-a553-8535a1de5ac1", null, "seller", "seller" },
                    { "e991589b-14b1-4313-a995-c63fe1abf8ea", null, "client", "client" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "671d6a2c-e13e-427a-9a37-d5781b691d3d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c104855e-a33e-4045-a553-8535a1de5ac1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e991589b-14b1-4313-a995-c63fe1abf8ea");
        }
    }
}
