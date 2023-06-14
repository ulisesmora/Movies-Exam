using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movies_Exam.Migrations
{
    public partial class MigrationSqlInitial9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "VisualContentStaff",
                newName: "VisualContentStaffId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "VisualContentLanguage",
                newName: "VisualContentLanguageId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "VisualContentGenre",
                newName: "VisualContentGenreId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "VisualContent",
                newName: "VisualContentId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TypeContent",
                newName: "TypeContentId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Staff",
                newName: "StaffId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Stadistics",
                newName: "StadisticsId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Role",
                newName: "RoleId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Language",
                newName: "LanguageId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Genre",
                newName: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VisualContentStaffId",
                table: "VisualContentStaff",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "VisualContentLanguageId",
                table: "VisualContentLanguage",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "VisualContentGenreId",
                table: "VisualContentGenre",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "VisualContentId",
                table: "VisualContent",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TypeContentId",
                table: "TypeContent",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "StaffId",
                table: "Staff",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "StadisticsId",
                table: "Stadistics",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "Role",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "LanguageId",
                table: "Language",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "GenreId",
                table: "Genre",
                newName: "Id");
        }
    }
}
