using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreApp.API.Migrations
{
    public partial class fix_incremention : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Authors",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Authors",
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
    }
}
