using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    JanCode1 = table.Column<string>(maxLength: 13, nullable: true),
                    JanCode2 = table.Column<string>(maxLength: 13, nullable: true),
                    IsbnCode = table.Column<string>(maxLength: 15, nullable: true),
                    Title = table.Column<string>(maxLength: 200, nullable: true),
                    InsTime = table.Column<DateTime>(nullable: false),
                    UpdTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: false),
                    UserPass = table.Column<string>(nullable: false),
                    LastLoggedIn = table.Column<DateTime>(nullable: true),
                    InsTime = table.Column<DateTime>(nullable: false),
                    UpdTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OwnedBookInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BookId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    InsTime = table.Column<DateTime>(nullable: false),
                    UpdTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OwnedBookInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OwnedBookInfos_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OwnedBookInfos_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "InsTime", "IsbnCode", "JanCode1", "JanCode2", "Title", "UpdTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 9, 20, 17, 9, 45, 891, DateTimeKind.Local).AddTicks(4106), "987-4-12354-123", "1234567890123", "1234567890123", "テスト本１", new DateTime(2020, 9, 20, 17, 9, 45, 892, DateTimeKind.Local).AddTicks(3275) },
                    { 2, new DateTime(2020, 9, 20, 17, 9, 45, 892, DateTimeKind.Local).AddTicks(3649), "986-4-12354-123", "2345678901234", "2345678901234", "テスト本２", new DateTime(2020, 9, 20, 17, 9, 45, 892, DateTimeKind.Local).AddTicks(3661) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "InsTime", "LastLoggedIn", "LastName", "UpdTime", "UserName", "UserPass" },
                values: new object[,]
                {
                    { 1, "たくや", new DateTime(2020, 9, 20, 17, 9, 45, 893, DateTimeKind.Local).AddTicks(5317), null, "たなか", new DateTime(2020, 9, 20, 17, 9, 45, 893, DateTimeKind.Local).AddTicks(5627), "TAKUYA", "TEST" },
                    { 2, "ころ", new DateTime(2020, 9, 20, 17, 9, 45, 893, DateTimeKind.Local).AddTicks(5935), null, "ころ", new DateTime(2020, 9, 20, 17, 9, 45, 893, DateTimeKind.Local).AddTicks(5943), "koro", "koro" }
                });

            migrationBuilder.InsertData(
                table: "OwnedBookInfos",
                columns: new[] { "Id", "BookId", "InsTime", "UpdTime", "UserId" },
                values: new object[] { 1, 1, new DateTime(2020, 9, 20, 17, 9, 45, 893, DateTimeKind.Local).AddTicks(7171), new DateTime(2020, 9, 20, 17, 9, 45, 893, DateTimeKind.Local).AddTicks(7433), 1 });

            migrationBuilder.CreateIndex(
                name: "IX_OwnedBookInfos_BookId",
                table: "OwnedBookInfos",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_OwnedBookInfos_UserId",
                table: "OwnedBookInfos",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OwnedBookInfos");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
