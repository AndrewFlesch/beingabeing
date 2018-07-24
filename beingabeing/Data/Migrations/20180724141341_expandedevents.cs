using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace beingabeing.Data.Migrations
{
    public partial class expandedevents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "Event",
                newName: "With");

            migrationBuilder.RenameColumn(
                name: "Group",
                table: "Event",
                newName: "Yogurt");

            migrationBuilder.AddColumn<int>(
                name: "Beans",
                table: "Event",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Beer",
                table: "Event",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Bread",
                table: "Event",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Butter",
                table: "Event",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Cheese",
                table: "Event",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Coffee",
                table: "Event",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DietSoda",
                table: "Event",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Dose",
                table: "Event",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Eggs",
                table: "Event",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Fish",
                table: "Event",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Fruit",
                table: "Event",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Intensity",
                table: "Event",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Juice",
                table: "Event",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Liquor",
                table: "Event",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Meat",
                table: "Event",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Nuts",
                table: "Event",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Oils",
                table: "Event",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Pasta",
                table: "Event",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Potatoes",
                table: "Event",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Rice",
                table: "Event",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Soda",
                table: "Event",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Sweats",
                table: "Event",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vegetable",
                table: "Event",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Water",
                table: "Event",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Where",
                table: "Event",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Wine",
                table: "Event",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Beans",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "Beer",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "Bread",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "Butter",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "Cheese",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "Coffee",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "DietSoda",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "Dose",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "Eggs",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "Fish",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "Fruit",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "Intensity",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "Juice",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "Liquor",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "Meat",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "Nuts",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "Oils",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "Pasta",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "Potatoes",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "Rice",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "Soda",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "Sweats",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "Vegetable",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "Water",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "Where",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "Wine",
                table: "Event");

            migrationBuilder.RenameColumn(
                name: "Yogurt",
                table: "Event",
                newName: "Group");

            migrationBuilder.RenameColumn(
                name: "With",
                table: "Event",
                newName: "Quantity");
        }
    }
}
