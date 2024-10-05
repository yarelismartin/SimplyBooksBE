using Microsoft.EntityFrameworkCore;
using SimplyBooks.DTOs;
using SimplyBooks.Models;

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
            app.MapPost("/books", (SimplyBooksDbContext db, Book newBook) =>
            {
                if (!db.Authors.Any(a => a.Id == newBook.AuthorId))
                {
                    return Results.NotFound($"There are not authors with the following id: {newBook.AuthorId}");
                }

                Book book = new()
                {
                    Title = newBook.Title,
                    Description = newBook.Description,
                    AuthorId = newBook.AuthorId,
                    Image = newBook.Image,
                    Price = newBook.Price,
                    Sale = newBook.Sale,
                    Uid = newBook.Uid,

                };
                db.Books.Add(book);
                db.SaveChanges();
                return Results.Created($"/books/{newBook.Id}", newBook);
            });


            //UPDATE BOOK
            app.MapPut("/books", (SimplyBooksDbContext db, Book book, int bookId) =>
            {
                Book updateBook = db.Books.SingleOrDefault(b => b.Id == bookId);

                if(updateBook == null)
                {
                    return Results.NotFound($"There is not book matching the following id: {bookId}");
                }

                else if (!db.Authors.Any(a => a.Id == book.AuthorId))
                {
                    return Results.NotFound($"There are not authors with the following id: {book.AuthorId}");
                }


                updateBook.Title = book.Title;
                updateBook.Description = book.Description;
                updateBook.AuthorId = book.AuthorId;
                updateBook.Image = book.Image;
                updateBook.Price = book.Price;
                updateBook.Sale = book.Sale;

                db.SaveChanges();
                return Results.Ok(updateBook);
            });


            //DELETE BOOK
            app.MapDelete("/books", (SimplyBooksDbContext db, int bookId) =>
            {
                Book removeBook = db.Books.SingleOrDefault(b => b.Id == bookId);

  

                if (removeBook == null)
                {
                    return Results.NotFound($"There is not book with the following id: {bookId}");
                }

                db.Books.Remove(removeBook);
                db.SaveChanges();
                return Results.Ok(removeBook);
            });
        }
    }
}
