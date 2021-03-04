using Microsoft.EntityFrameworkCore.Migrations;

namespace Commander.Migrations
{
    public partial class TryingIdentityFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7cce3ae0-11f1-45b5-ae12-96966f8875af");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae83a9b8-63c4-427b-aa69-14c6029a174f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2f6132f-e85d-41f8-8f0c-ff77ea1da591");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "cdeabdfb-bb4d-40cf-80e5-f79434f06279", 0, "3abd2db7-7e7f-4dbf-9b3b-9354cc3d301e", "BobTheSavage", "bob@gmail.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEGKuENybevdornjiDjEnA5pPmygbQgsmlIq1MU68R2iVeMSeXgl94Gm5Ic14asNlrQ==", null, false, "358e4168-f28d-4018-b50a-6f838940237a", false, "bob" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ac05764f-cb61-452d-90ec-0671943e9d0c", 0, "dfb7f581-0a46-4f9d-bfa2-f6e299c6605f", "AndyTheKind", "andy@gmail.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEOtJGqT+RiaX/Yi2Z7KQHSgR/lKiiJfvv3+tZ2gCAebiMgDBui0SHQVi/EoyIwv1Yg==", null, false, "dac1f99d-210c-4bd2-9ace-33d1721ac36e", false, "andy" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "669ce19d-0797-419a-8dd4-454a6f38658d", 0, "5403df4b-63b1-4dea-8adb-af3f34e020e7", "GeorgeTheWise", "georige@gmail.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEMCZRapb+2k718UXP4VNp6puONW4ruXyL5e/rgRAiAYEZpCYtK9C2SknQ3gTD677yg==", null, false, "d7c8f5bf-f98c-4ea4-a957-6014da4d62e0", false, "george" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7cce3ae0-11f1-45b5-ae12-96966f8875af", 0, "b70f5d9a-4143-4d15-8906-ef5fe6a556e1", "BobTheSavage", "bob@gmail.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEFHyrylkEDuulYPaVyNCg6DEL79NWoLI+PzDOMWCEYDoZ3D9LP/sY7TGfUZvIGjsXA==", null, false, "f704b867-ae1c-4ff4-b4c1-08bcfbb25dca", false, "bob" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b2f6132f-e85d-41f8-8f0c-ff77ea1da591", 0, "58006cf5-162a-492e-a735-2eaa903e96fe", "AndyTheKind", "andy@gmail.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEEebzD956/ilb48EqmnMEu2twszHAiwNry8ljQ38K0VME2MEX5H1USmU08mBbemTtA==", null, false, "7ad53ad6-d3ef-4004-a886-110125e097f1", false, "andy" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ae83a9b8-63c4-427b-aa69-14c6029a174f", 0, "46f433b8-06be-4e6c-914d-ae836c553e35", "GeorgeTheWise", "georige@gmail.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEBdK1jFiPAlPsM7EZBjd2Xr+nhwmoGfqxrbyMBfyBMiKVCtjDWnGSnn4NRzD2dpvQA==", null, false, "2b13eab9-d099-4cdb-97e1-5f3af4b09648", false, "george" });
        }
    }
}
