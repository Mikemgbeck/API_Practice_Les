using Microsoft.EntityFrameworkCore.Migrations;

namespace Commander.Migrations
{
    public partial class SeedTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
