using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace beingabeing.Data.Migrations
{
    public partial class NewModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cat = table.Column<string>(nullable: true),
                    DateState = table.Column<DateTime>(nullable: false),
                    Duration = table.Column<int>(nullable: false),
                    Group = table.Column<int>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    OwnerID = table.Column<string>(nullable: true),
                    Quantity = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Event");
        }
    }
}
