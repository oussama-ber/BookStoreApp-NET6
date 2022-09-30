using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreApp.API.Migrations
{
    public partial class auto_increment_author : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "27c98c9f-39c3-48a3-8508-4867f55438ae",
                column: "ConcurrencyStamp",
                value: "e3f90900-1931-4e26-9209-382d8a05fba7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6449c5cb-98bc-470e-9925-aaaa3b4b9eb0",
                column: "ConcurrencyStamp",
                value: "e9961878-ff05-4ed6-9b72-d334b38e6edf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0589e81b-acb0-46cc-9c6f-5549d07d9304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d0982a2-631c-4bdc-b238-ad73026363ff", "AQAAAAEAACcQAAAAEDhl6tmqz74ktU7RwZ71Rv/4UjGQeqCCbWFygmIRGn0EeCC3WldHAF85VvbOtEFzGQ==", "64e964c1-d22b-48e6-af6d-3e1e02b8cd03" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28abad97-e736-4145-bc4d-fb98958e1704",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c43001b0-2edd-42e7-b68d-92d3cb7a331a", "AQAAAAEAACcQAAAAEIuOUc1udjjcGUPOZiUvKB4gcJjvez2bnnp69qz02Jq+3ZvGj0ecnoqDFSvDariBEg==", "b7f4fde9-9273-41b1-a3b2-41479ffa716b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "27c98c9f-39c3-48a3-8508-4867f55438ae",
                column: "ConcurrencyStamp",
                value: "dc1846d3-4e5f-4484-a7fe-fa2eb425dd7d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6449c5cb-98bc-470e-9925-aaaa3b4b9eb0",
                column: "ConcurrencyStamp",
                value: "f3115a2c-042b-427d-a6ba-b6fbce8643cc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0589e81b-acb0-46cc-9c6f-5549d07d9304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "032e2556-ad8f-413b-b262-1f0ebbd17d5d", "AQAAAAEAACcQAAAAEHUB649Pt3IGVMXnPjnMssThxF4r6TzUE3MBgP56OtqEp20kzrQDtnOysFnw++YjQA==", "ddfcaae7-5ea7-43bb-8003-f0fb3ce55972" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28abad97-e736-4145-bc4d-fb98958e1704",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51d84505-5955-4a4e-b573-47460c7ba72b", "AQAAAAEAACcQAAAAENw8tIclEokTrNofM98ig/BdVHbO0MCTUDcMYZJ5sDA6l2p60O/00E56SZIrXGRvEQ==", "00ecb56e-6b3a-4fe6-9f2c-83e9fcba54d4" });
        }
    }
}
