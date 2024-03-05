using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LINQ_Operations.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    GenreId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BookAuthors",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookAuthors", x => new { x.BookId, x.AuthorId });
                    table.ForeignKey(
                        name: "FK_BookAuthors_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookAuthors_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "FirstName", "LastName", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 4, 16, 4, 2, 46, DateTimeKind.Local).AddTicks(9367), null, "Jack", "London", 1, null },
                    { 2, new DateTime(2024, 3, 4, 16, 4, 2, 46, DateTimeKind.Local).AddTicks(9370), null, "George", "Orwell", 1, null },
                    { 3, new DateTime(2024, 3, 4, 16, 4, 2, 46, DateTimeKind.Local).AddTicks(9371), null, "Freida", "McFadden", 1, null },
                    { 4, new DateTime(2024, 3, 4, 16, 4, 2, 46, DateTimeKind.Local).AddTicks(9372), null, "Lev", "Tolstoy", 1, null },
                    { 5, new DateTime(2024, 3, 4, 16, 4, 2, 46, DateTimeKind.Local).AddTicks(9373), null, "Oğuz", "Atay", 1, null },
                    { 6, new DateTime(2024, 3, 4, 16, 4, 2, 46, DateTimeKind.Local).AddTicks(9374), null, "Mihailovic", "Dostoyevski", 1, null },
                    { 7, new DateTime(2024, 3, 4, 16, 4, 2, 46, DateTimeKind.Local).AddTicks(9375), null, "J.K.", "Rowling", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { "ask", new DateTime(2024, 3, 4, 16, 4, 2, 46, DateTimeKind.Local).AddTicks(9105), null, "Aşk", 1, null },
                    { "bilimkurgu", new DateTime(2024, 3, 4, 16, 4, 2, 46, DateTimeKind.Local).AddTicks(9104), null, "Bilim Kurgu", 1, null },
                    { "korku", new DateTime(2024, 3, 4, 16, 4, 2, 46, DateTimeKind.Local).AddTicks(9102), null, "Korku", 1, null },
                    { "macera", new DateTime(2024, 3, 4, 16, 4, 2, 46, DateTimeKind.Local).AddTicks(9105), null, "Macera", 1, null },
                    { "polisiye", new DateTime(2024, 3, 4, 16, 4, 2, 46, DateTimeKind.Local).AddTicks(9103), null, "Polisiye", 1, null },
                    { "roman", new DateTime(2024, 3, 4, 16, 4, 2, 46, DateTimeKind.Local).AddTicks(9089), null, "Roman", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "GenreId", "Price", "Status", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 4, 16, 4, 2, 46, DateTimeKind.Local).AddTicks(9269), null, "macera", 50.5, 1, "Beyaz Diş", null },
                    { 2, new DateTime(2024, 3, 4, 16, 4, 2, 46, DateTimeKind.Local).AddTicks(9271), null, "roman", 91.450000000000003, 1, "Suç ve Ceza", null },
                    { 3, new DateTime(2024, 3, 4, 16, 4, 2, 46, DateTimeKind.Local).AddTicks(9273), null, "korku", 100.0, 1, "1984", null },
                    { 4, new DateTime(2024, 3, 4, 16, 4, 2, 46, DateTimeKind.Local).AddTicks(9274), null, "polisiye", 150.80000000000001, 1, "Sakın Yalan Söyleme", null },
                    { 5, new DateTime(2024, 3, 4, 16, 4, 2, 46, DateTimeKind.Local).AddTicks(9275), null, "roman", 200.0, 1, "Savaş ve Barış", null },
                    { 6, new DateTime(2024, 3, 4, 16, 4, 2, 46, DateTimeKind.Local).AddTicks(9276), null, "ask", 82.0, 1, "Tutunamayanlar", null },
                    { 7, new DateTime(2024, 3, 4, 16, 4, 2, 46, DateTimeKind.Local).AddTicks(9277), null, "roman", 75.0, 1, "Beyaz Geceler", null },
                    { 8, new DateTime(2024, 3, 4, 16, 4, 2, 46, DateTimeKind.Local).AddTicks(9278), null, "roman", 50.0, 1, "İnsan Ne ile Yaşar", null },
                    { 9, new DateTime(2024, 3, 4, 16, 4, 2, 46, DateTimeKind.Local).AddTicks(9288), null, "bilimkurgu", 80.0, 1, "Harry Potter Azkaban Tutsağı", null }
                });

            migrationBuilder.InsertData(
                table: "BookAuthors",
                columns: new[] { "AuthorId", "BookId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 4, 2 },
                    { 2, 3 },
                    { 3, 4 },
                    { 4, 5 },
                    { 5, 6 },
                    { 6, 7 },
                    { 4, 8 },
                    { 7, 9 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthors_AuthorId",
                table: "BookAuthors",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_GenreId",
                table: "Books",
                column: "GenreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookAuthors");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
