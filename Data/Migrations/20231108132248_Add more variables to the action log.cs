﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BudgetManager.Data.Migrations
{
    public partial class Addmorevariablestotheactionlog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ButtonClicked",
                table: "ActionLogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OnClickEvent",
                table: "ActionLogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ButtonClicked",
                table: "ActionLogs");

            migrationBuilder.DropColumn(
                name: "OnClickEvent",
                table: "ActionLogs");
        }
    }
}
