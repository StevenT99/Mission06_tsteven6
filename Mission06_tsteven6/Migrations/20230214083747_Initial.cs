using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission06_tsteven6.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    ApplicationId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    Lent = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.ApplicationId);
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "ApplicationId", "Category", "Director", "Edited", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Drama/Crime", "Frank Darabont", true, "Steve", "Steve loves this movie man", "R", "Shawshank Redemption", 1994 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "ApplicationId", "Category", "Director", "Edited", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Drama/Music", "Damien Chazelle", true, "Steve", "Steve loves this movie as well man", "R", "Whiplash", 2014 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "ApplicationId", "Category", "Director", "Edited", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Sport/Drama", "Frank Darabont", true, "Steve", "Steve loves this movie a lot man", "PG-13", "Creed", 2015 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");
        }
    }
}
