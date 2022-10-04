using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreApp.API.Migrations
{
    public partial class fix_book : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Books",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "27c98c9f-39c3-48a3-8508-4867f55438ae",
                column: "ConcurrencyStamp",
                value: "7734e179-0849-440c-975a-5e8a02f406e5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6449c5cb-98bc-470e-9925-aaaa3b4b9eb0",
                column: "ConcurrencyStamp",
                value: "498dc903-bfb5-4513-9406-d9ad30d86dad");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0589e81b-acb0-46cc-9c6f-5549d07d9304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45eb8500-c003-43b7-ac19-14d00b267092", "AQAAAAEAACcQAAAAEN2IGh6IzWG6pRZsiooUREijSn2nmVi8zIRgWArtQzbkiAv0Vup8GFcLJ9gyHuZDMw==", "b8c9c378-96d7-4a6d-9e75-b3e112c043c8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28abad97-e736-4145-bc4d-fb98958e1704",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef1eaccc-3b1c-4aad-93ef-cd064715986b", "AQAAAAEAACcQAAAAENzflSI+82Fa0HxegSo9kIijoMDAw6iXPiCAGEqDCQ3JFICaWLinBwJK5TPrmIl/9Q==", "8ed190c0-c35e-4b75-a5db-5549110d7b86" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Books",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "27c98c9f-39c3-48a3-8508-4867f55438ae",
                column: "ConcurrencyStamp",
                value: "2ca1a2c8-c2e2-4529-92d5-527a46a46258");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6449c5cb-98bc-470e-9925-aaaa3b4b9eb0",
                column: "ConcurrencyStamp",
                value: "1f553d75-9438-41a0-b49d-9cfd889f278a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0589e81b-acb0-46cc-9c6f-5549d07d9304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7a581ba-9183-4d05-ac8c-d12dda4a1f68", "AQAAAAEAACcQAAAAEHgHFSrRlDxO0rjQMNBOsosIu9ACq/Y/TzRSxnuqIRhVFLbvoy0Ca/HQP0o1f/akpQ==", "57c0f162-9c5d-4c89-b370-479b7c7c3065" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28abad97-e736-4145-bc4d-fb98958e1704",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "230903e8-e054-4ac0-8b37-23fa69cba19b", "AQAAAAEAACcQAAAAEMR7lugP7X+mapkBnhICO8xuy2ji2eqcwHd3mfsTBtaZvihc1dCQ805w6cJq2A9Dzw==", "26c19753-2158-450c-897e-7bb040fba882" });
        }
    }
}
