using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinhaBiblioteca.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublishedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Loans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoanDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Loans_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Loans_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryId",
                table: "Books",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Name",
                table: "Categories",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Loans_BookId",
                table: "Loans",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_UserId",
                table: "Loans",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "CreatedAt", "UpdatedAt" },
                values: new object[,]
                {
                    { Guid.NewGuid(), "Ação", DateTime.UtcNow, DateTime.UtcNow },
                    { Guid.NewGuid(), "Aventura", DateTime.UtcNow, DateTime.UtcNow },
                    { Guid.NewGuid(), "Romance", DateTime.UtcNow, DateTime.UtcNow },
                    { Guid.NewGuid(), "Ficção Científica", DateTime.UtcNow, DateTime.UtcNow },
                    { Guid.NewGuid(), "Fantasia", DateTime.UtcNow, DateTime.UtcNow },
                    { Guid.NewGuid(), "Biografia", DateTime.UtcNow, DateTime.UtcNow },
                    { Guid.NewGuid(), "História", DateTime.UtcNow, DateTime.UtcNow },
                    { Guid.NewGuid(), "Mistério", DateTime.UtcNow, DateTime.UtcNow },
                    { Guid.NewGuid(), "Terror", DateTime.UtcNow, DateTime.UtcNow },
                    { Guid.NewGuid(), "Autoajuda", DateTime.UtcNow, DateTime.UtcNow },
                    { Guid.NewGuid(), "Poesia", DateTime.UtcNow, DateTime.UtcNow },
                    { Guid.NewGuid(), "Drama", DateTime.UtcNow, DateTime.UtcNow },
                    { Guid.NewGuid(), "Humor", DateTime.UtcNow, DateTime.UtcNow },
                    { Guid.NewGuid(), "Tecnologia", DateTime.UtcNow, DateTime.UtcNow },
                    { Guid.NewGuid(), "Negócios", DateTime.UtcNow, DateTime.UtcNow },
                    { Guid.NewGuid(), "Saúde", DateTime.UtcNow, DateTime.UtcNow },
                    { Guid.NewGuid(), "Educação", DateTime.UtcNow, DateTime.UtcNow },
                    { Guid.NewGuid(), "Religião", DateTime.UtcNow, DateTime.UtcNow },
                    { Guid.NewGuid(), "Filosofia", DateTime.UtcNow, DateTime.UtcNow },
                    { Guid.NewGuid(), "Arte", DateTime.UtcNow, DateTime.UtcNow },
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Loans");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
