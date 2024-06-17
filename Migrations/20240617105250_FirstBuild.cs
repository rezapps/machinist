using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace machinist.Migrations
{
    /// <inheritdoc />
    public partial class FirstBuild : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Logo = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: false),
                    Desc = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Machine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MachineId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Desc = table.Column<string>(type: "TEXT", nullable: false),
                    RoomNr = table.Column<string>(type: "TEXT", nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: true),
                    StatusChanged = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CompanyId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Machine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Machine_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Commando",
                columns: table => new
                {
                    CommandoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Desc = table.Column<string>(type: "TEXT", nullable: false),
                    ExeTime = table.Column<int>(type: "INTEGER", nullable: false),
                    MachineId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commando", x => x.CommandoId);
                    table.ForeignKey(
                        name: "FK_Commando_Machine_MachineId",
                        column: x => x.MachineId,
                        principalTable: "Machine",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Commando_MachineId",
                table: "Commando",
                column: "MachineId");

            migrationBuilder.CreateIndex(
                name: "IX_Machine_CompanyId",
                table: "Machine",
                column: "CompanyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Commando");

            migrationBuilder.DropTable(
                name: "Machine");

            migrationBuilder.DropTable(
                name: "Company");
        }
    }
}
