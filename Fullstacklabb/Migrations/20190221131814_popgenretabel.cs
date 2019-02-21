using Microsoft.EntityFrameworkCore.Migrations;

namespace Fullstacklabb.Migrations
{
    public partial class popgenretabel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
               table: "Genres",
               columns: new[] { "Id", "Name" },
               values: new object[,]
               {
                            { "1", "Jazz"},
                            { "2", "Pop" },
                            { "3", "Rock" },
                            { "4", "Rap" },
                            { "5", "House" },
               });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DeleteData(
                 table: "Genres",
                 keyColumn: "Id",
                 keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "3");
            migrationBuilder.DeleteData(
               table: "Genres",
               keyColumn: "Id",
               keyValue: "4");
            migrationBuilder.DeleteData(
               table: "Genres",
               keyColumn: "Id",
               keyValue: "5");

        }
    }
}
