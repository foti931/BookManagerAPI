using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class UpdateBookDomain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "InsTime",
                table: "Books",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsRental",
                table: "Books",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdTime",
                table: "Books",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsTime", "JAN", "UpdTime" },
                values: new object[] { new DateTime(2020, 8, 9, 17, 14, 18, 179, DateTimeKind.Local).AddTicks(2161), "1", new DateTime(2020, 8, 9, 17, 14, 18, 180, DateTimeKind.Local).AddTicks(4589) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsTime", "JAN", "UpdTime" },
                values: new object[] { new DateTime(2020, 8, 9, 17, 14, 18, 180, DateTimeKind.Local).AddTicks(5277), "2", new DateTime(2020, 8, 9, 17, 14, 18, 180, DateTimeKind.Local).AddTicks(5291) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsTime", "JAN", "UpdTime" },
                values: new object[] { new DateTime(2020, 8, 9, 17, 14, 18, 180, DateTimeKind.Local).AddTicks(5325), "3", new DateTime(2020, 8, 9, 17, 14, 18, 180, DateTimeKind.Local).AddTicks(5326) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InsTime",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "IsRental",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "UpdTime",
                table: "Books");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "JAN",
                value: null);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "JAN",
                value: null);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "JAN",
                value: null);
        }
    }
}
