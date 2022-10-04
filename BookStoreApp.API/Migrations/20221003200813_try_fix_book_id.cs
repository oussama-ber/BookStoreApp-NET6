using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreApp.API.Migrations
{
    public partial class try_fix_book_id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Books",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Books",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "27c98c9f-39c3-48a3-8508-4867f55438ae",
                column: "ConcurrencyStamp",
                value: "4acf3333-3957-4530-a71c-6a49f7b6dda3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6449c5cb-98bc-470e-9925-aaaa3b4b9eb0",
                column: "ConcurrencyStamp",
                value: "dca93e80-1973-413b-89d7-d7abd8f6494f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0589e81b-acb0-46cc-9c6f-5549d07d9304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5fa09f6-ec07-4c2e-8894-aae7dfcfc771", "AQAAAAEAACcQAAAAEIIKj+RpBjYNN7stL/aT3H28T7D6MR8kfJLE6zrP8Oh8yd9cdo2XhvT4jSX/15bf3Q==", "fe612685-b2bd-4d93-abdd-6aca1388cc2c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28abad97-e736-4145-bc4d-fb98958e1704",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba23d0ef-4737-46d1-a2fd-d5fcd53581f7", "AQAAAAEAACcQAAAAEIklaNaPvE3IRchtv0+Lfj5QiQ/o0ZVj/MUWL20OvxH6ry2UyMtWcdymPmaNeHJIOg==", "9be84921-860b-4b97-9b87-4dda66a2721d" });
        }
    }
}
