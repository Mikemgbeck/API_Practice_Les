using Microsoft.EntityFrameworkCore.Migrations;

namespace Commander.Migrations
{
    public partial class SeedRoleData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "12559b0f-ec1b-405b-8507-9b87d47f8171", "ebe97c64-b776-41c4-9179-9e997f8234b4", "ApplicationRole", "Admin", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "e73b96b3-47ef-44c0-805c-b289f098466d", "d0b9772b-fe9a-4998-925a-6947a92d65b0", "ApplicationRole", "User", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "c9e71208-afda-4b9e-bdb7-692eb72d3364", "76db8524-92a1-45da-be94-e1aaaba9497c", "ApplicationRole", "PremiumUser", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12559b0f-ec1b-405b-8507-9b87d47f8171");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9e71208-afda-4b9e-bdb7-692eb72d3364");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e73b96b3-47ef-44c0-805c-b289f098466d");
        }
    }
}
