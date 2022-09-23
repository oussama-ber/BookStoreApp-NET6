using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreApp.API.Migrations
{
    public partial class SeededDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "27c98c9f-39c3-48a3-8508-4867f55438ae", "51124980-b638-4edc-a1b6-3f4ca7060035", "Administrator", "ADMINISTRATOR" },
                    { "6449c5cb-98bc-470e-9925-aaaa3b4b9eb0", "01d4e623-568a-440e-8725-cb357d1e2276", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0589e81b-acb0-46cc-9c6f-5549d07d9304", 0, "6a6bed65-435a-4147-95d0-3e3dd4b8a3e2", "user@bookstore.com", false, "System", "User", false, null, "USER@BOOKSTORE.COM", "USER@BOOKSTORE.COM", "AQAAAAEAACcQAAAAELQXg5A+x5/62rlZ7xghYeo2nbXCVB77c6M8b833HrgZGHPxQGP5Ca4/lhFKnmxuBw==", null, false, "081c0ac6-7fec-4bac-964e-09599ade70dd", false, "user@bookstore.com" },
                    { "28abad97-e736-4145-bc4d-fb98958e1704", 0, "162281e5-3876-46cc-8e83-6b29b38e504a", "admin@bookstore.com", false, "System", "Admin", false, null, "ADMIN@BOOKSTORE.COM", "ADMIN@BOOKSTORE.COM", "AQAAAAEAACcQAAAAEOCDXdfyflR53ue0yUQeyl/sKGQOf0YBRDcVENQbRZZiCELhmGy6zaa0W9gtEB6hbA==", null, false, "917c09a3-6469-4bb2-8601-5f016522c195", false, "admin@bookstore.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6449c5cb-98bc-470e-9925-aaaa3b4b9eb0", "0589e81b-acb0-46cc-9c6f-5549d07d9304" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "27c98c9f-39c3-48a3-8508-4867f55438ae", "28abad97-e736-4145-bc4d-fb98958e1704" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6449c5cb-98bc-470e-9925-aaaa3b4b9eb0", "0589e81b-acb0-46cc-9c6f-5549d07d9304" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "27c98c9f-39c3-48a3-8508-4867f55438ae", "28abad97-e736-4145-bc4d-fb98958e1704" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "27c98c9f-39c3-48a3-8508-4867f55438ae");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6449c5cb-98bc-470e-9925-aaaa3b4b9eb0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0589e81b-acb0-46cc-9c6f-5549d07d9304");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28abad97-e736-4145-bc4d-fb98958e1704");
        }
    }
}
