﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FullStackApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class addedCarModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarPrice = table.Column<int>(type: "int", nullable: false),
                    CarLocation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarModels", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarModels");
        }
    }
}
