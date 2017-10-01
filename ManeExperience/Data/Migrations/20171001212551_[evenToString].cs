using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ManeExperience.Data.Migrations
{
    public partial class evenToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EventCheckIn",
                table: "Events",
                nullable: true,
                oldClrType: typeof(bool));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "EventCheckIn",
                table: "Events",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
