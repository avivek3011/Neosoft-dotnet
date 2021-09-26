using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "superhero",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    alias = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    hideout = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_superhero", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "superhero",
                columns: new[] { "id", "alias", "hideout", "name" },
                values: new object[,]
                {
                    { 1, "Superman", "NYC apartment", "Peter Parker" },
                    { 2, "Ironman", "Dumpyard", "Tony Stark" },
                    { 3, "Thor", "Asgard", "Thor" },
                    { 4, "Shaktiman", "tenant in a village", "Gangadhar" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "superhero");
        }
    }
}
