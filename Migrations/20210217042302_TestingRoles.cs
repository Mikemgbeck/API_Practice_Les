using Microsoft.EntityFrameworkCore.Migrations;

namespace Commander.Migrations
{
    public partial class TestingRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "669ce19d-0797-419a-8dd4-454a6f38658d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ac05764f-cb61-452d-90ec-0671943e9d0c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cdeabdfb-bb4d-40cf-80e5-f79434f06279");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetRoles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetRoles");

            // migrationBuilder.InsertData(
            //     table: "AspNetUsers",
            //     columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
            //     values: new object[] { "cdeabdfb-bb4d-40cf-80e5-f79434f06279", 0, "3abd2db7-7e7f-4dbf-9b3b-9354cc3d301e", "BobTheSavage", "bob@gmail.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEGKuENybevdornjiDjEnA5pPmygbQgsmlIq1MU68R2iVeMSeXgl94Gm5Ic14asNlrQ==", null, false, "358e4168-f28d-4018-b50a-6f838940237a", false, "bob" });

            // migrationBuilder.InsertData(
            //     table: "AspNetUsers",
            //     columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
            //     values: new object[] { "ac05764f-cb61-452d-90ec-0671943e9d0c", 0, "dfb7f581-0a46-4f9d-bfa2-f6e299c6605f", "AndyTheKind", "andy@gmail.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEOtJGqT+RiaX/Yi2Z7KQHSgR/lKiiJfvv3+tZ2gCAebiMgDBui0SHQVi/EoyIwv1Yg==", null, false, "dac1f99d-210c-4bd2-9ace-33d1721ac36e", false, "andy" });

            // migrationBuilder.InsertData(
            //     table: "AspNetUsers",
            //     columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
            //     values: new object[] { "669ce19d-0797-419a-8dd4-454a6f38658d", 0, "5403df4b-63b1-4dea-8adb-af3f34e020e7", "GeorgeTheWise", "georige@gmail.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEMCZRapb+2k718UXP4VNp6puONW4ruXyL5e/rgRAiAYEZpCYtK9C2SknQ3gTD677yg==", null, false, "d7c8f5bf-f98c-4ea4-a957-6014da4d62e0", false, "george" });
        }
    }
}
