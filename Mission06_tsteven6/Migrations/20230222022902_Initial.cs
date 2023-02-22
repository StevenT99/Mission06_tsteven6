using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission06_tsteven6.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Categoryname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    ApplicationId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    Lent = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.ApplicationId);
                    table.ForeignKey(
                        name: "FK_Responses_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Categoryname" },
                values: new object[] { 1, "Action" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Categoryname" },
                values: new object[] { 2, "Animation" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Categoryname" },
                values: new object[] { 3, "Comedy" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Categoryname" },
                values: new object[] { 4, "Crime" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Categoryname" },
                values: new object[] { 5, "Drama" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Categoryname" },
                values: new object[] { 6, "Fantasy" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Categoryname" },
                values: new object[] { 7, "Historical" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Categoryname" },
                values: new object[] { 8, "Horror" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Categoryname" },
                values: new object[] { 9, "Romance" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Categoryname" },
                values: new object[] { 10, "Science Fiction" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Categoryname" },
                values: new object[] { 11, "Thriller" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Categoryname" },
                values: new object[] { 12, "Western" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Categoryname" },
                values: new object[] { 13, "Sports" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Categoryname" },
                values: new object[] { 14, "Other" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "ApplicationId", "CategoryId", "Director", "Edited", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, 5, "Frank Darabont", true, "Steve", "Steve loves this movie man", "R", "Shawshank Redemption", 1994 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "ApplicationId", "CategoryId", "Director", "Edited", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, 5, "Damien Chazelle", true, "Steve", "Steve loves this movie as well man", "R", "Whiplash", 2014 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "ApplicationId", "CategoryId", "Director", "Edited", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, 13, "Frank Darabont", true, "Steve", "Steve loves this movie a lot man", "PG-13", "Creed", 2015 });

            migrationBuilder.CreateIndex(
                name: "IX_Responses_CategoryId",
                table: "Responses",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
