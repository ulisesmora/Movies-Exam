using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movies_Exam.Migrations
{
    public partial class MigrationSqlInitial8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LanguageSubtitleId",
                table: "VisualContentLanguage");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "LanguageSubtitleId",
                table: "VisualContentLanguage",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
