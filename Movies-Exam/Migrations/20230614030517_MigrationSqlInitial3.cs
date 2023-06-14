using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movies_Exam.Migrations
{
    public partial class MigrationSqlInitial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staff_Role_RoleListId",
                table: "Staff");

            migrationBuilder.DropIndex(
                name: "IX_Staff_RoleListId",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "RoleListId",
                table: "Staff");

            migrationBuilder.RenameColumn(
                name: "TypeStaffId",
                table: "Staff",
                newName: "RoleId");

            migrationBuilder.AddColumn<int>(
                name: "Views",
                table: "Stadistics",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Staff_RoleId",
                table: "Staff",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_Role_RoleId",
                table: "Staff",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staff_Role_RoleId",
                table: "Staff");

            migrationBuilder.DropIndex(
                name: "IX_Staff_RoleId",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "Views",
                table: "Stadistics");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "Staff",
                newName: "TypeStaffId");

            migrationBuilder.AddColumn<Guid>(
                name: "RoleListId",
                table: "Staff",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Staff_RoleListId",
                table: "Staff",
                column: "RoleListId");

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_Role_RoleListId",
                table: "Staff",
                column: "RoleListId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
