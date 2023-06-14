using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movies_Exam.Migrations
{
    public partial class MigrationSqlInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stadistics",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stadistics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeContent",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameContent = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeContent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BornhDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TypeStaffId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Staff_Role_RoleListId",
                        column: x => x.RoleListId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VisualContent",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Synopsis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    RealeseYear = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<float>(type: "real", nullable: true),
                    Views = table.Column<int>(type: "int", nullable: false),
                    TypeContentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StadisticId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StadisticsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisualContent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VisualContent_Stadistics_StadisticsId",
                        column: x => x.StadisticsId,
                        principalTable: "Stadistics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VisualContent_TypeContent_TypeContentId",
                        column: x => x.TypeContentId,
                        principalTable: "TypeContent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VisualContentGenre",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GenreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VisualContentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisualContentGenre", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VisualContentGenre_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VisualContentGenre_VisualContent_VisualContentId",
                        column: x => x.VisualContentId,
                        principalTable: "VisualContent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VisualContentLanguage",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LanguageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LanguageSubtitleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VisualContentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisualContentLanguage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VisualContentLanguage_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VisualContentLanguage_VisualContent_VisualContentId",
                        column: x => x.VisualContentId,
                        principalTable: "VisualContent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VisualContentStaff",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GenreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VisualContentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StaffId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisualContentStaff", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VisualContentStaff_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VisualContentStaff_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VisualContentStaff_VisualContent_VisualContentId",
                        column: x => x.VisualContentId,
                        principalTable: "VisualContent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Staff_RoleListId",
                table: "Staff",
                column: "RoleListId");

            migrationBuilder.CreateIndex(
                name: "IX_VisualContent_StadisticsId",
                table: "VisualContent",
                column: "StadisticsId");

            migrationBuilder.CreateIndex(
                name: "IX_VisualContent_TypeContentId",
                table: "VisualContent",
                column: "TypeContentId");

            migrationBuilder.CreateIndex(
                name: "IX_VisualContentGenre_GenreId",
                table: "VisualContentGenre",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_VisualContentGenre_VisualContentId",
                table: "VisualContentGenre",
                column: "VisualContentId");

            migrationBuilder.CreateIndex(
                name: "IX_VisualContentLanguage_LanguageId",
                table: "VisualContentLanguage",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_VisualContentLanguage_VisualContentId",
                table: "VisualContentLanguage",
                column: "VisualContentId");

            migrationBuilder.CreateIndex(
                name: "IX_VisualContentStaff_GenreId",
                table: "VisualContentStaff",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_VisualContentStaff_StaffId",
                table: "VisualContentStaff",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_VisualContentStaff_VisualContentId",
                table: "VisualContentStaff",
                column: "VisualContentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VisualContentGenre");

            migrationBuilder.DropTable(
                name: "VisualContentLanguage");

            migrationBuilder.DropTable(
                name: "VisualContentStaff");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "VisualContent");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Stadistics");

            migrationBuilder.DropTable(
                name: "TypeContent");
        }
    }
}
