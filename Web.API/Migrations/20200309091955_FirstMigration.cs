using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.API.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Downloads",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Remark = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Downloads", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Storages",
                columns: table => new
                {
                    Pru = table.Column<string>(maxLength: 100, nullable: false),
                    Pruspec = table.Column<string>(nullable: false),
                    Prunum = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storages", x => x.Pru);
                });

            migrationBuilder.CreateTable(
                name: "Uploads",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Remark = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uploads", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Pru", "Prunum", "Pruspec" },
                values: new object[] { "产品1", 1, "规格1" });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Pru", "Prunum", "Pruspec" },
                values: new object[] { "产品2", 2, "规格2" });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Pru", "Prunum", "Pruspec" },
                values: new object[] { "产品3", 3, "规格3" });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Pru", "Prunum", "Pruspec" },
                values: new object[] { "产品4", 4, "规格4" });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Pru", "Prunum", "Pruspec" },
                values: new object[] { "产品5", 5, "规格5" });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Pru", "Prunum", "Pruspec" },
                values: new object[] { "产品6", 6, "规格6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Downloads");

            migrationBuilder.DropTable(
                name: "Storages");

            migrationBuilder.DropTable(
                name: "Uploads");
        }
    }
}
