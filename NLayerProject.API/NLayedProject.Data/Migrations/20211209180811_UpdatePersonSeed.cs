using Microsoft.EntityFrameworkCore.Migrations;

namespace NLayerProject.Data.Migrations
{
    public partial class UpdatePersonSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Name", "SurName" },
                values: new object[] { 1, "Mehmet", "Şener" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Name", "SurName" },
                values: new object[] { 2, "Ahmet Yasin", "Bahçıvan" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
