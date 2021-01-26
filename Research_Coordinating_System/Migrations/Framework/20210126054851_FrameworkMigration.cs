using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Research_Coordinating_System.Migrations.Framework
{
    public partial class FrameworkMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PaperCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaperCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskName = table.Column<string>(nullable: true),
                    DeadLine = table.Column<DateTime>(nullable: false),
                    File = table.Column<string>(nullable: true),
                    TaskAuthor = table.Column<string>(nullable: true),
                    AssignesTo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaperDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaperTilte = table.Column<string>(nullable: true),
                    AuthorName = table.Column<string>(nullable: true),
                    JournalorConferenceName = table.Column<string>(nullable: true),
                    Volume = table.Column<string>(nullable: true),
                    Page = table.Column<string>(nullable: true),
                    ConferenceLocation = table.Column<string>(nullable: true),
                    Submitdate = table.Column<DateTime>(nullable: false),
                    PaperCategoryId = table.Column<int>(nullable: false),
                    ResearchSeminarId = table.Column<int>(nullable: true),
                    ResearchCollaborationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaperDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaperDetails_PaperCategories_PaperCategoryId",
                        column: x => x.PaperCategoryId,
                        principalTable: "PaperCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResearchCollaborations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartnerName = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    PaperDetailsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResearchCollaborations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResearchCollaborations_PaperDetails_PaperDetailsId",
                        column: x => x.PaperDetailsId,
                        principalTable: "PaperDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResearchSeminars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    ResourcePerson = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Vanue = table.Column<string>(nullable: true),
                    NumberOfParticipants = table.Column<string>(nullable: true),
                    PaperDetailsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResearchSeminars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResearchSeminars_PaperDetails_PaperDetailsId",
                        column: x => x.PaperDetailsId,
                        principalTable: "PaperDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PaperDetails_PaperCategoryId",
                table: "PaperDetails",
                column: "PaperCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PaperDetails_PaperTilte",
                table: "PaperDetails",
                column: "PaperTilte",
                unique: true,
                filter: "[PaperTilte] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ResearchCollaborations_PaperDetailsId",
                table: "ResearchCollaborations",
                column: "PaperDetailsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ResearchSeminars_PaperDetailsId",
                table: "ResearchSeminars",
                column: "PaperDetailsId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ResearchCollaborations");

            migrationBuilder.DropTable(
                name: "ResearchSeminars");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "PaperDetails");

            migrationBuilder.DropTable(
                name: "PaperCategories");
        }
    }
}
