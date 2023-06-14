using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movies_Exam.Migrations
{
    public partial class MigrationSqlInitial7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Role_Staff_StaffId",
                table: "Role");

            migrationBuilder.DropForeignKey(
                name: "FK_VisualContentStaff_Genre_GenreId",
                table: "VisualContentStaff");

            migrationBuilder.DropForeignKey(
                name: "FK_VisualContentStaff_Staff_StaffId",
                table: "VisualContentStaff");

            migrationBuilder.DropIndex(
                name: "IX_Role_StaffId",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "Role");

            migrationBuilder.RenameColumn(
                name: "GenreId",
                table: "VisualContentStaff",
                newName: "RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_VisualContentStaff_GenreId",
                table: "VisualContentStaff",
                newName: "IX_VisualContentStaff_RoleId");

            migrationBuilder.AlterColumn<Guid>(
                name: "StaffId",
                table: "VisualContentStaff",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_VisualContentStaff_Role_RoleId",
                table: "VisualContentStaff",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VisualContentStaff_Staff_StaffId",
                table: "VisualContentStaff",
                column: "StaffId",
                principalTable: "Staff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VisualContentStaff_Role_RoleId",
                table: "VisualContentStaff");

            migrationBuilder.DropForeignKey(
                name: "FK_VisualContentStaff_Staff_StaffId",
                table: "VisualContentStaff");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "VisualContentStaff",
                newName: "GenreId");

            migrationBuilder.RenameIndex(
                name: "IX_VisualContentStaff_RoleId",
                table: "VisualContentStaff",
                newName: "IX_VisualContentStaff_GenreId");

            migrationBuilder.AlterColumn<Guid>(
                name: "StaffId",
                table: "VisualContentStaff",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "StaffId",
                table: "Role",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Role_StaffId",
                table: "Role",
                column: "StaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_Role_Staff_StaffId",
                table: "Role",
                column: "StaffId",
                principalTable: "Staff",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VisualContentStaff_Genre_GenreId",
                table: "VisualContentStaff",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VisualContentStaff_Staff_StaffId",
                table: "VisualContentStaff",
                column: "StaffId",
                principalTable: "Staff",
                principalColumn: "Id");
        }
    }
}
