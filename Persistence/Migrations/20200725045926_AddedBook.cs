using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using static System.Data.Entity.Migrations.Model.UpdateDatabaseOperation;

namespace Persistence.Migrations
{
    public partial class AddedBook : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Gerne = table.Column<string>(nullable: true),
                    Detail = table.Column<string>(nullable: true),
                    Other = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Detail", "Gerne", "Other", "Title" },
                values: new object[] { 1, null, null, null, "First" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Detail", "Gerne", "Other", "Title" },
                values: new object[] { 2, null, null, null, "Second" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Detail", "Gerne", "Other", "Title" },
                values: new object[] { 3, null, null, null, "Third" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
