using Microsoft.EntityFrameworkCore;
using SimplyBooks.DTOs;

namespace SimplyBooks.APIs
{
    public class BookAPI
    {
        public static void Map(WebApplication app)
        {
            // GET ALL BOOKS
            app.MapGet("/books", (SimplyBooksDbContext db) =>
            {
                var allBooks = db.Books
                .ToList();

                var bookDtos = allBooks.Select(book => new BookDto(book)).ToList();

                if(!bookDtos.Any()) 
                {
                    return Results.Ok("There are no books");
                }
                return Results.Ok(bookDtos);
            });

            //GET ALL BOOKS BY UID 
            app.MapGet("/books/users/{uid}", (SimplyBooksDbContext db, string uid) =>
            {
                var allBooks = db.Books
                .Where(book => book.Uid == uid)
                .ToList();

                var bookDtos = allBooks.Select(book => new BookDto(book)).ToList();

                if(!bookDtos.Any()) 
                {
                    return Results.Ok("You have no books to display");
                }
                return Results.Ok(bookDtos);


            });

            //GET SINGLE BOOK
            app.MapGet("/books/{bookId}", (SimplyBooksDbContext db, int bookId) =>
            {
                var book = db.Books
                .Include(b => b.Author)
                .SingleOrDefault(b => b.Id == bookId);

                if (book == null)
                {
                    return Results.NotFound($"There is no book matching the following id: {bookId}");
                }

                return Results.Ok(new
                {
                    book.Id,
                    book.Title,
                    book.Description,
                    book.Image,
                    book.Price,
                    book.Sale,
                    book.Uid,
                    Author =  new AuthorDto(book.Author),
                });

            });

            //CREATE BOOK


            //UPDATE BOOK


            //DELETE BOOK
        }
    }
}
