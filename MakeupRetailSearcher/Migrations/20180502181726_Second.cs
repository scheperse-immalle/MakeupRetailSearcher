using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MakeupRetailSearcher.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Makeup",
                newName: "ID");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Makeup",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Link",
                table: "Makeup",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Retailer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Retailer_Name = table.Column<string>(nullable: true),
                    Retailer_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Retailer", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Retailer");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Makeup",
                newName: "id");

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Makeup",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
