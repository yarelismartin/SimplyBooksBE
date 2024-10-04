using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SimplyBooks.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false),
                    Favorite = table.Column<bool>(type: "boolean", nullable: false),
                    Uid = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    AuthorId = table.Column<int>(type: "integer", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    Sale = table.Column<bool>(type: "boolean", nullable: false),
                    Uid = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Email", "Favorite", "FirstName", "Image", "LastName", "Uid" },
                values: new object[,]
                {
                    { 1, "george.orwell@example.com", true, "George", "orwell.jpg", "Orwell", "UID001" },
                    { 2, "jk.rowling@example.com", true, "J.K.", "rowling.jpg", "Rowling", "UID002" },
                    { 3, "agatha.christie@example.com", false, "Agatha", "christie.jpg", "Christie", "UID003" },
                    { 4, "mark.twain@example.com", false, "Mark", "twain.jpg", "Twain", "UID004" },
                    { 5, "f.scott.fitzgerald@example.com", true, "F. Scott", "fitzgerald.jpg", "Fitzgerald", "UID005" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Image", "Price", "Sale", "Title", "Uid" },
                values: new object[,]
                {
                    { 1, 1, "A dystopian novel set in a totalitarian society ruled by Big Brother.", "1984.jpg", 14.99m, true, "1984", "BID001" },
                    { 2, 1, "A political satire that allegorizes the rise of Stalinism.", "animal_farm.jpg", 9.99m, false, "Animal Farm", "BID002" },
                    { 3, 2, "The first book in the Harry Potter series about a young wizard.", "hp_sorcerer_stone.jpg", 12.99m, false, "Harry Potter and the Sorcerer's Stone", "BID003" },
                    { 4, 2, "The second book in the Harry Potter series.", "hp_chamber_secrets.jpg", 13.99m, true, "Harry Potter and the Chamber of Secrets", "BID004" },
                    { 5, 3, "A famous detective novel featuring Hercule Poirot.", "orient_express.jpg", 11.99m, false, "Murder on the Orient Express", "BID005" },
                    { 6, 3, "Another thrilling mystery from Agatha Christie.", "abc_murders.jpg", 10.99m, true, "The ABC Murders", "BID006" },
                    { 7, 4, "A novel about the adventures of Huck Finn along the Mississippi River.", "huck_finn.jpg", 8.99m, false, "The Adventures of Huckleberry Finn", "BID007" },
                    { 8, 4, "A story about the mischievous adventures of Tom Sawyer.", "tom_sawyer.jpg", 7.99m, true, "The Adventures of Tom Sawyer", "BID008" },
                    { 9, 5, "A novel about the mysterious Jay Gatsby and his love for Daisy Buchanan.", "gatsby.jpg", 10.99m, true, "The Great Gatsby", "BID009" },
                    { 10, 5, "A novel about the rise and fall of a glamorous American couple.", "tender_night.jpg", 12.49m, false, "Tender Is the Night", "BID010" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
