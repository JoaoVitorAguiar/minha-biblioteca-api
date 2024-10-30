using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MinhaBiblioteca.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddManyToManyInLoansCopiesOfTheBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loans_BookCopies_BookCopyId",
                table: "Loans");

            migrationBuilder.DropIndex(
                name: "IX_Loans_BookCopyId",
                table: "Loans");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0cc9e10d-5330-43a7-a256-3f00e7a111b9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3219f776-4516-472e-b872-cc2561a87089"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("37bd3107-f71f-4163-9d2d-1b6584ccd33c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("42d3e87a-d800-4cad-8e1b-df3d6bcf28ee"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("49b8f6bd-0ec4-47ce-9dc8-61aff779a05c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4f9d35d7-e889-4fe3-8136-39efcfc5c3e8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4fc2e6ff-7d37-41eb-8c04-c7cf18769a53"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("59c38890-e8a3-4f9f-b05e-39f45ce51b20"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6134c6b0-da2b-48d6-9661-951fce12c00b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6e7523d1-e7c0-49b8-adc0-a7fea794dcd3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("717ce636-8d8c-435a-bc62-13502d34c56a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9946192a-3920-4fa8-abbe-80568241fb0e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ad3902fd-9a3d-4d97-967a-bfc711c71029"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aed48971-3ba4-4b58-a148-2c5c39983b50"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c0f59472-43d8-43f5-bec3-72b41549673f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d52b9604-0115-4a46-9ebf-50c783e5a240"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d777686d-ad6e-47ba-a0d5-006d06f794c5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dca4797d-da2c-4c2e-a3ae-1d1987917f4d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ea53d7fa-4e44-48fd-b6d0-4244ff403fc9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f22c7c45-239f-49e8-a48a-90f6a7afeeb4"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("03658c3d-d92e-48c3-8ceb-270473123299"), new DateTime(2024, 10, 28, 11, 32, 17, 382, DateTimeKind.Utc).AddTicks(4003), "Terror", new DateTime(2024, 10, 28, 11, 32, 17, 382, DateTimeKind.Utc).AddTicks(4003) },
                    { new Guid("0eb5ff7a-bf20-467f-88eb-ad4a9e416cf4"), new DateTime(2024, 10, 28, 11, 32, 17, 382, DateTimeKind.Utc).AddTicks(4021), "Humor", new DateTime(2024, 10, 28, 11, 32, 17, 382, DateTimeKind.Utc).AddTicks(4021) },
                    { new Guid("1a6c942f-5b97-4e98-85a4-70049450d2a3"), new DateTime(2024, 10, 28, 11, 32, 17, 382, DateTimeKind.Utc).AddTicks(4043), "Religião", new DateTime(2024, 10, 28, 11, 32, 17, 382, DateTimeKind.Utc).AddTicks(4043) },
                    { new Guid("2391e2bc-e316-4d2d-8177-c9c77490ec5a"), new DateTime(2024, 10, 28, 11, 32, 17, 382, DateTimeKind.Utc).AddTicks(3980), "Ficção Científica", new DateTime(2024, 10, 28, 11, 32, 17, 382, DateTimeKind.Utc).AddTicks(3980) },
                    { new Guid("25d750fb-9a0a-4135-8520-4116f70238f9"), new DateTime(2024, 10, 28, 11, 32, 17, 382, DateTimeKind.Utc).AddTicks(4025), "Tecnologia", new DateTime(2024, 10, 28, 11, 32, 17, 382, DateTimeKind.Utc).AddTicks(4025) },
                    { new Guid("3bc3581c-77d6-415a-bf58-680c084e6730"), new DateTime(2024, 10, 28, 11, 32, 17, 382, DateTimeKind.Utc).AddTicks(4047), "Filosofia", new DateTime(2024, 10, 28, 11, 32, 17, 382, DateTimeKind.Utc).AddTicks(4047) },
                    { new Guid("3de6cf8e-b487-4477-a2e4-04e4f093bae3"), new DateTime(2024, 10, 28, 11, 32, 17, 382, DateTimeKind.Utc).AddTicks(3976), "Romance", new DateTime(2024, 10, 28, 11, 32, 17, 382, DateTimeKind.Utc).AddTicks(3976) },
                    { new Guid("7b678ab6-26f6-4857-87d9-5ab276a60b18"), new DateTime(2024, 10, 28, 11, 32, 17, 382, DateTimeKind.Utc).AddTicks(4007), "Autoajuda", new DateTime(2024, 10, 28, 11, 32, 17, 382, DateTimeKind.Utc).AddTicks(4008) },
                    { new Guid("7f29d28c-ce0a-4976-b130-a7cd51ea18c0"), new DateTime(2024, 10, 28, 11, 32, 17, 382, DateTimeKind.Utc).AddTicks(4034), "Saúde", new DateTime(2024, 10, 28, 11, 32, 17, 382, DateTimeKind.Utc).AddTicks(4034) },
                    { new Guid("92ab711d-b075-4b6f-a8f1-47bbec684f94"), new DateTime(2024, 10, 28, 11, 32, 17, 382, DateTimeKind.Utc).AddTicks(4030), "Negócios", new DateTime(2024, 10, 28, 11, 32, 17, 382, DateTimeKind.Utc).AddTicks(4030) },
                    { new Guid("951a1f02-ebc6-41da-85c2-4364cb1c3b26"), new DateTime(2024, 10, 28, 11, 32, 17, 382, DateTimeKind.Utc).AddTicks(3994), "História", new DateTime(2024, 10, 28, 11, 32, 17, 382, DateTimeKind.Utc).AddTicks(3994) },
                    { new Guid("9e9af7a0-5543-42d9-b222-082354502e17"), new DateTime(2024, 10, 28, 11, 32, 17, 382, DateTimeKind.Utc).AddTicks(3965), "Ação", new DateTime(2024, 10, 28, 11, 32, 17, 382, DateTimeKind.Utc).AddTicks(3966) },
                    { new Guid("a6b7efc7-724e-438f-8ff2-e2b4821f6b30"), new DateTime(2024, 10, 28, 11, 32, 17, 382, DateTimeKind.Utc).AddTicks(4051), "Arte", new DateTime(2024, 10, 28, 11, 32, 17, 382, DateTimeKind.Utc).AddTicks(4052) },
                    { new Guid("bb98d688-80e1-49ce-a9b3-92fca36a0b55"), new DateTime(2024, 10, 28, 11, 32, 17, 382, DateTimeKind.Utc).AddTicks(3971), "Aventura", new DateTime(2024, 10, 28, 11, 32, 17, 382, DateTimeKind.Utc).AddTicks(3971) },
                    { new Guid("cc5ce429-1295-4d68-be86-0d8a178d3461"), new DateTime(2024, 10, 28, 11, 32, 17, 382, DateTimeKind.Utc).AddTicks(3985), "Fantasia", new DateTime(2024, 10, 28, 11, 32, 17, 382, DateTimeKind.Utc).AddTicks(3985) },
                    { new Guid("d1c99335-1e96-40c6-8ced-ee6928cb634a"), new DateTime(2024, 10, 28, 11, 32, 17, 382, DateTimeKind.Utc).AddTicks(4016), "Drama", new DateTime(2024, 10, 28, 11, 32, 17, 382, DateTimeKind.Utc).AddTicks(4017) },
                    { new Guid("d96a5eeb-4713-4580-9076-79bf07249c79"), new DateTime(2024, 10, 28, 11, 32, 17, 382, DateTimeKind.Utc).AddTicks(3999), "Mistério", new DateTime(2024, 10, 28, 11, 32, 17, 382, DateTimeKind.Utc).AddTicks(3999) },
                    { new Guid("dbf6e799-8b73-4491-bd2d-c4bc237baeb8"), new DateTime(2024, 10, 28, 11, 32, 17, 382, DateTimeKind.Utc).AddTicks(4012), "Poesia", new DateTime(2024, 10, 28, 11, 32, 17, 382, DateTimeKind.Utc).AddTicks(4012) },
                    { new Guid("dd1ad99b-b10b-4752-be50-e1625c3ac987"), new DateTime(2024, 10, 28, 11, 32, 17, 382, DateTimeKind.Utc).AddTicks(4038), "Educação", new DateTime(2024, 10, 28, 11, 32, 17, 382, DateTimeKind.Utc).AddTicks(4039) },
                    { new Guid("debc9601-1d73-4561-8774-1f5d2365e8ef"), new DateTime(2024, 10, 28, 11, 32, 17, 382, DateTimeKind.Utc).AddTicks(3989), "Biografia", new DateTime(2024, 10, 28, 11, 32, 17, 382, DateTimeKind.Utc).AddTicks(3990) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Loans_BookCopyId",
                table: "Loans",
                column: "BookCopyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_BookCopies_BookCopyId",
                table: "Loans",
                column: "BookCopyId",
                principalTable: "BookCopies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loans_BookCopies_BookCopyId",
                table: "Loans");

            migrationBuilder.DropIndex(
                name: "IX_Loans_BookCopyId",
                table: "Loans");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("03658c3d-d92e-48c3-8ceb-270473123299"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0eb5ff7a-bf20-467f-88eb-ad4a9e416cf4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1a6c942f-5b97-4e98-85a4-70049450d2a3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2391e2bc-e316-4d2d-8177-c9c77490ec5a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("25d750fb-9a0a-4135-8520-4116f70238f9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3bc3581c-77d6-415a-bf58-680c084e6730"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3de6cf8e-b487-4477-a2e4-04e4f093bae3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7b678ab6-26f6-4857-87d9-5ab276a60b18"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7f29d28c-ce0a-4976-b130-a7cd51ea18c0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("92ab711d-b075-4b6f-a8f1-47bbec684f94"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("951a1f02-ebc6-41da-85c2-4364cb1c3b26"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9e9af7a0-5543-42d9-b222-082354502e17"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a6b7efc7-724e-438f-8ff2-e2b4821f6b30"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bb98d688-80e1-49ce-a9b3-92fca36a0b55"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cc5ce429-1295-4d68-be86-0d8a178d3461"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d1c99335-1e96-40c6-8ced-ee6928cb634a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d96a5eeb-4713-4580-9076-79bf07249c79"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dbf6e799-8b73-4491-bd2d-c4bc237baeb8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dd1ad99b-b10b-4752-be50-e1625c3ac987"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("debc9601-1d73-4561-8774-1f5d2365e8ef"));

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
                name: "IX_Loans_BookCopyId",
                table: "Loans",
                column: "BookCopyId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_BookCopies_BookCopyId",
                table: "Loans",
                column: "BookCopyId",
                principalTable: "BookCopies",
                principalColumn: "Id");
        }
    }
}
