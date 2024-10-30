using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

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
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: false),
                    Role = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    ISBN = table.Column<string>(type: "text", nullable: false),
                    Author = table.Column<string>(type: "text", nullable: false),
                    PublishedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                name: "BookCopies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BookId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookCopies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookCopies_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Loans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    BookCopyId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Loans_BookCopies_BookCopyId",
                        column: x => x.BookCopyId,
                        principalTable: "BookCopies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Loans_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0cc9e10d-5330-43a7-a256-3f00e7a111b9"), new DateTime(2024, 10, 24, 17, 56, 0, 187, DateTimeKind.Utc).AddTicks(1880), "Negócios", new DateTime(2024, 10, 24, 17, 56, 0, 187, DateTimeKind.Utc).AddTicks(1881) },
                    { new Guid("3219f776-4516-472e-b872-cc2561a87089"), new DateTime(2024, 10, 24, 17, 56, 0, 187, DateTimeKind.Utc).AddTicks(1714), "Aventura", new DateTime(2024, 10, 24, 17, 56, 0, 187, DateTimeKind.Utc).AddTicks(1716) },
                    { new Guid("37bd3107-f71f-4163-9d2d-1b6584ccd33c"), new DateTime(2024, 10, 24, 17, 56, 0, 187, DateTimeKind.Utc).AddTicks(1829), "Poesia", new DateTime(2024, 10, 24, 17, 56, 0, 187, DateTimeKind.Utc).AddTicks(1830) },
                    { new Guid("42d3e87a-d800-4cad-8e1b-df3d6bcf28ee"), new DateTime(2024, 10, 24, 17, 56, 0, 187, DateTimeKind.Utc).AddTicks(1892), "Saúde", new DateTime(2024, 10, 24, 17, 56, 0, 187, DateTimeKind.Utc).AddTicks(1893) },
                    { new Guid("49b8f6bd-0ec4-47ce-9dc8-61aff779a05c"), new DateTime(2024, 10, 24, 17, 56, 0, 187, DateTimeKind.Utc).AddTicks(1867), "Tecnologia", new DateTime(2024, 10, 24, 17, 56, 0, 187, DateTimeKind.Utc).AddTicks(1868) },
                    { new Guid("4f9d35d7-e889-4fe3-8136-39efcfc5c3e8"), new DateTime(2024, 10, 24, 17, 56, 0, 187, DateTimeKind.Utc).AddTicks(1805), "Terror", new DateTime(2024, 10, 24, 17, 56, 0, 187, DateTimeKind.Utc).AddTicks(1805) },
                    { new Guid("4fc2e6ff-7d37-41eb-8c04-c7cf18769a53"), new DateTime(2024, 10, 24, 17, 56, 0, 187, DateTimeKind.Utc).AddTicks(1728), "Romance", new DateTime(2024, 10, 24, 17, 56, 0, 187, DateTimeKind.Utc).AddTicks(1729) },
                    { new Guid("59c38890-e8a3-4f9f-b05e-39f45ce51b20"), new DateTime(2024, 10, 24, 17, 56, 0, 187, DateTimeKind.Utc).AddTicks(1930), "Filosofia", new DateTime(2024, 10, 24, 17, 56, 0, 187, DateTimeKind.Utc).AddTicks(1931) },
                    { new Guid("6134c6b0-da2b-48d6-9661-951fce12c00b"), new DateTime(2024, 10, 24, 17, 56, 0, 187, DateTimeKind.Utc).AddTicks(1754), "Fantasia", new DateTime(2024, 10, 24, 17, 56, 0, 187, DateTimeKind.Utc).AddTicks(1755) },
                    { new Guid("6e7523d1-e7c0-49b8-adc0-a7fea794dcd3"), new DateTime(2024, 10, 24, 17, 56, 0, 187, DateTimeKind.Utc).AddTicks(1904), "Educação", new DateTime(2024, 10, 24, 17, 56, 0, 187, DateTimeKind.Utc).AddTicks(1905) },
                    { new Guid("717ce636-8d8c-435a-bc62-13502d34c56a"), new DateTime(2024, 10, 24, 17, 56, 0, 187, DateTimeKind.Utc).AddTicks(1855), "Humor", new DateTime(2024, 10, 24, 17, 56, 0, 187, DateTimeKind.Utc).AddTicks(1856) },
                    { new Guid("9946192a-3920-4fa8-abbe-80568241fb0e"), new DateTime(2024, 10, 24, 17, 56, 0, 187, DateTimeKind.Utc).AddTicks(1698), "Ação", new DateTime(2024, 10, 24, 17, 56, 0, 187, DateTimeKind.Utc).AddTicks(1699) },
                    { new Guid("ad3902fd-9a3d-4d97-967a-bfc711c71029"), new DateTime(2024, 10, 24, 17, 56, 0, 187, DateTimeKind.Utc).AddTicks(1766), "Biografia", new DateTime(2024, 10, 24, 17, 56, 0, 187, DateTimeKind.Utc).AddTicks(1767) },
                    { new Guid("aed48971-3ba4-4b58-a148-2c5c39983b50"), new DateTime(2024, 10, 24, 17, 56, 0, 187, DateTimeKind.Utc).AddTicks(1741), "Ficção Científica", new DateTime(2024, 10, 24, 17, 56, 0, 187, DateTimeKind.Utc).AddTicks(1742) },
                    { new Guid("c0f59472-43d8-43f5-bec3-72b41549673f"), new DateTime(2024, 10, 24, 17, 56, 0, 187, DateTimeKind.Utc).AddTicks(1942), "Arte", new DateTime(2024, 10, 24, 17, 56, 0, 187, DateTimeKind.Utc).AddTicks(1943) },
                    { new Guid("d52b9604-0115-4a46-9ebf-50c783e5a240"), new DateTime(2024, 10, 24, 17, 56, 0, 187, DateTimeKind.Utc).AddTicks(1779), "História", new DateTime(2024, 10, 24, 17, 56, 0, 187, DateTimeKind.Utc).AddTicks(1780) },
                    { new Guid("d777686d-ad6e-47ba-a0d5-006d06f794c5"), new DateTime(2024, 10, 24, 17, 56, 0, 187, DateTimeKind.Utc).AddTicks(1817), "Autoajuda", new DateTime(2024, 10, 24, 17, 56, 0, 187, DateTimeKind.Utc).AddTicks(1818) },
                    { new Guid("dca4797d-da2c-4c2e-a3ae-1d1987917f4d"), new DateTime(2024, 10, 24, 17, 56, 0, 187, DateTimeKind.Utc).AddTicks(1842), "Drama", new DateTime(2024, 10, 24, 17, 56, 0, 187, DateTimeKind.Utc).AddTicks(1843) },
                    { new Guid("ea53d7fa-4e44-48fd-b6d0-4244ff403fc9"), new DateTime(2024, 10, 24, 17, 56, 0, 187, DateTimeKind.Utc).AddTicks(1917), "Religião", new DateTime(2024, 10, 24, 17, 56, 0, 187, DateTimeKind.Utc).AddTicks(1918) },
                    { new Guid("f22c7c45-239f-49e8-a48a-90f6a7afeeb4"), new DateTime(2024, 10, 24, 17, 56, 0, 187, DateTimeKind.Utc).AddTicks(1792), "Mistério", new DateTime(2024, 10, 24, 17, 56, 0, 187, DateTimeKind.Utc).AddTicks(1793) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookCopies_BookId",
                table: "BookCopies",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryId",
                table: "Books",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_ISBN",
                table: "Books",
                column: "ISBN",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Name",
                table: "Categories",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Loans_BookCopyId",
                table: "Loans",
                column: "BookCopyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Loans_UserId",
                table: "Loans",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Loans");

            migrationBuilder.DropTable(
                name: "BookCopies");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
