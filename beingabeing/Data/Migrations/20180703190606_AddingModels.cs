using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace beingabeing.Data.Migrations
{
    public partial class AddingModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appetite",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cat = table.Column<string>(nullable: true),
                    DateState = table.Column<DateTime>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    OwnerID = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appetite", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Consumings",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Beans = table.Column<int>(nullable: false),
                    Beer = table.Column<int>(nullable: false),
                    Bread = table.Column<int>(nullable: false),
                    Butter = table.Column<int>(nullable: false),
                    Cat = table.Column<string>(nullable: true),
                    Cheese = table.Column<int>(nullable: false),
                    Coffee = table.Column<int>(nullable: false),
                    DateState = table.Column<DateTime>(nullable: false),
                    DietSoda = table.Column<int>(nullable: false),
                    Eggs = table.Column<int>(nullable: false),
                    Fish = table.Column<int>(nullable: false),
                    Fruit = table.Column<int>(nullable: false),
                    Juice = table.Column<int>(nullable: false),
                    Liquor = table.Column<int>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    Meat = table.Column<int>(nullable: false),
                    MyProperty = table.Column<int>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    Nuts = table.Column<int>(nullable: false),
                    Oils = table.Column<int>(nullable: false),
                    OwnerID = table.Column<string>(nullable: true),
                    Pasta = table.Column<int>(nullable: false),
                    Potatoes = table.Column<int>(nullable: false),
                    Rice = table.Column<int>(nullable: false),
                    Soda = table.Column<int>(nullable: false),
                    Sweats = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Vegetable = table.Column<int>(nullable: false),
                    Water = table.Column<int>(nullable: false),
                    Wine = table.Column<int>(nullable: false),
                    Yogurt = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consumings", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EmotionalStates",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cat = table.Column<string>(nullable: true),
                    DateState = table.Column<DateTime>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    OwnerID = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmotionalStates", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Exercise",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cat = table.Column<string>(nullable: true),
                    DateState = table.Column<DateTime>(nullable: false),
                    Duration = table.Column<int>(nullable: false),
                    Intensity = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    OwnerID = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercise", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Pills",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cat = table.Column<string>(nullable: true),
                    DateState = table.Column<DateTime>(nullable: false),
                    Dose = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    OwnerID = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pills", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Poop",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cat = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Density = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    OwnerID = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poop", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Sickness",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cat = table.Column<string>(nullable: true),
                    DateState = table.Column<DateTime>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    OwnerID = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sickness", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Sleep",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cat = table.Column<string>(nullable: true),
                    Duration = table.Column<int>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    OwnerID = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    WentDown = table.Column<DateTime>(nullable: false),
                    WokeUp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sleep", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Social",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cat = table.Column<string>(nullable: true),
                    DateState = table.Column<DateTime>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    OwnerID = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Where = table.Column<string>(nullable: true),
                    With = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Social", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Stats",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Arms = table.Column<int>(nullable: false),
                    BodyFat = table.Column<int>(nullable: false),
                    Cat = table.Column<string>(nullable: true),
                    Chest = table.Column<int>(nullable: false),
                    DateState = table.Column<DateTime>(nullable: false),
                    Diastolic = table.Column<int>(nullable: false),
                    HDL = table.Column<int>(nullable: false),
                    Height = table.Column<int>(nullable: false),
                    LDL = table.Column<int>(nullable: false),
                    Legs = table.Column<int>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    OwnerID = table.Column<string>(nullable: true),
                    Systolic = table.Column<int>(nullable: false),
                    VLDL = table.Column<int>(nullable: false),
                    Waist = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stats", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Weather",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cat = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    OwnerID = table.Column<string>(nullable: true),
                    Temperature = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weather", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Working",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cat = table.Column<string>(nullable: true),
                    DateState = table.Column<DateTime>(nullable: false),
                    Duration = table.Column<int>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    OwnerID = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Working", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appetite");

            migrationBuilder.DropTable(
                name: "Consumings");

            migrationBuilder.DropTable(
                name: "EmotionalStates");

            migrationBuilder.DropTable(
                name: "Exercise");

            migrationBuilder.DropTable(
                name: "Pills");

            migrationBuilder.DropTable(
                name: "Poop");

            migrationBuilder.DropTable(
                name: "Sickness");

            migrationBuilder.DropTable(
                name: "Sleep");

            migrationBuilder.DropTable(
                name: "Social");

            migrationBuilder.DropTable(
                name: "Stats");

            migrationBuilder.DropTable(
                name: "Weather");

            migrationBuilder.DropTable(
                name: "Working");
        }
    }
}
