using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreApp.API.Migrations
{
    public partial class aa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "27c98c9f-39c3-48a3-8508-4867f55438ae",
                column: "ConcurrencyStamp",
                value: "51124980-b638-4edc-a1b6-3f4ca7060035");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6449c5cb-98bc-470e-9925-aaaa3b4b9eb0",
                column: "ConcurrencyStamp",
                value: "01d4e623-568a-440e-8725-cb357d1e2276");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0589e81b-acb0-46cc-9c6f-5549d07d9304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a6bed65-435a-4147-95d0-3e3dd4b8a3e2", "AQAAAAEAACcQAAAAELQXg5A+x5/62rlZ7xghYeo2nbXCVB77c6M8b833HrgZGHPxQGP5Ca4/lhFKnmxuBw==", "081c0ac6-7fec-4bac-964e-09599ade70dd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28abad97-e736-4145-bc4d-fb98958e1704",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "162281e5-3876-46cc-8e83-6b29b38e504a", "AQAAAAEAACcQAAAAEOCDXdfyflR53ue0yUQeyl/sKGQOf0YBRDcVENQbRZZiCELhmGy6zaa0W9gtEB6hbA==", "917c09a3-6469-4bb2-8601-5f016522c195" });
        }
    }
}
