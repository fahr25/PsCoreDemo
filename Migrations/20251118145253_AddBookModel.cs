using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PsCoreDemo.Migrations
{
    /// <inheritdoc />
    public partial class AddBookModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "Categories",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Author = table.Column<string>(type: "TEXT", nullable: true),
                    Genre = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: false),
                    Points = table.Column<int>(type: "INTEGER", nullable: false),
                    Inventory = table.Column<int>(type: "INTEGER", nullable: false),
                    MinAge = table.Column<int>(type: "INTEGER", nullable: false),
                    MaxAge = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_BookId",
                table: "Categories",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Books_BookId",
                table: "Categories",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Books_BookId",
                table: "Categories");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Categories_BookId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "Categories");
        }
    }
}
