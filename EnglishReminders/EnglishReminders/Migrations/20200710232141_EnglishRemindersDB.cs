using Microsoft.EntityFrameworkCore.Migrations;

namespace EnglishReminders.Migrations
{
    public partial class EnglishRemindersDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DbUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DbWords",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Turkish = table.Column<string>(nullable: true),
                    English = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbWords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DbScores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CorrectCout = table.Column<int>(nullable: false),
                    WrongCount = table.Column<int>(nullable: false),
                    ScorePoint = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbScores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DbScores_DbUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "DbUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DbuserWords",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    WordsId = table.Column<int>(nullable: false),
                    IsAnswered = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbuserWords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DbuserWords_DbUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "DbUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DbuserWords_DbWords_WordsId",
                        column: x => x.WordsId,
                        principalTable: "DbWords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DbScores_UserId",
                table: "DbScores",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DbuserWords_UserId",
                table: "DbuserWords",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DbuserWords_WordsId",
                table: "DbuserWords",
                column: "WordsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DbScores");

            migrationBuilder.DropTable(
                name: "DbuserWords");

            migrationBuilder.DropTable(
                name: "DbUsers");

            migrationBuilder.DropTable(
                name: "DbWords");
        }
    }
}
