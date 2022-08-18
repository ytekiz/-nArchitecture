using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brans", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Brans",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "BMW" });

            migrationBuilder.InsertData(
                table: "Brans",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Mercesdes" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Brans");
        }
    }
}
