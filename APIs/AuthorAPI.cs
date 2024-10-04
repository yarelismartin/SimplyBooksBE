using Microsoft.EntityFrameworkCore;
using SimplyBooks.DTOs;
using SimplyBooks.Models;

namespace SimplyBooks.APIs
{
    public class AuthorAPI
    {
        public static void Map(WebApplication app)
        {
            // GET ALL 
            app.MapGet("/authors", (SimplyBooksDbContext db) =>
            {
                //Retrieve all authors from the database 
                var allAuthors = db.Authors
                .ToList();

                // Map each Author entity to an AuthorDto using the constructor defined in AuthorDto
                // This allows us to create a simplified structure for our API response
                var authorDtos = allAuthors.Select(author => new AuthorDto(author)).ToList();

                if (!authorDtos.Any())
                {
                    return Results.Ok("There are no authors");
                }
                return Results.Ok(authorDtos);
            });

            // GET SINGLE 
            app.MapGet("/authors/{authorId}", (SimplyBooksDbContext db, int authorId) =>
            {
                var author = db.Authors
                .Include(author => author.Books)
                .SingleOrDefault(author => author.Id == authorId);
                if (author == null)
                {
                    return Results.NotFound($"No author was found with the following id: {authorId}");
                }
                return Results.Ok(new
                {
                    author.Id, 
                    author.FirstName,
                    author.LastName,
                    author.Email,
                    author.Image,
                    author.Favorite,
                    author.Uid,
                    Books = author.Books?.Select(book => new BookDto(book)).ToList()
                });
            });

            // GET BY UID
            app.MapGet("/authors/user/{uid}", (SimplyBooksDbContext db, string uid) =>
            {
                var allUserAuthors = db.Authors 
                .Where(author => author.Uid == uid)
                .ToList();

                var authorDtos = allUserAuthors.Select(author => new AuthorDto(author)).ToList();

                if(!authorDtos.Any())
                {
                    return Results.Ok("You correctly don't have any authors");
                }
                return Results.Ok(authorDtos);
            });


            // CREATE AUTHOR
            app.MapPost("/authors", (SimplyBooksDbContext db, Author newAuthor) =>
            {
                Author addAuthor = new()
                {
                    FirstName = newAuthor.FirstName,
                    LastName = newAuthor.LastName,
                    Email = newAuthor.Email,
                    Image = newAuthor.Image,
                    Favorite = newAuthor.Favorite,
                    Uid = newAuthor.Uid,
                };
                db.Authors.Add(addAuthor);
                db.SaveChanges();
                return Results.Created($"author/{addAuthor.Id}", addAuthor);

            });

            // UPDATE AUTHOR
            app.MapPut("/authors", (SimplyBooksDbContext db, Author author, int authorId) =>
            {
                Author updateAuthor = db.Authors
                .SingleOrDefault(a => a.Id == authorId);

                if(updateAuthor == null)
                {
                    return Results.NotFound($"No author was found with the following id: {authorId}");
                }

                updateAuthor.FirstName = author.FirstName;
                updateAuthor.LastName = author.LastName;
                updateAuthor.Email = author.Email;
                updateAuthor.Image = author.Image;
                updateAuthor.Favorite = author.Favorite;
                updateAuthor.Uid = author.Uid;

                db.SaveChanges();
                return Results.Ok(updateAuthor);

            });


            // DELETE AUTHOR
            app.MapDelete("/authors", (SimplyBooksDbContext db, int authorId) =>
            {
                Author authorToDelete = db.Authors
                .SingleOrDefault(a => a.Id == authorId);

                if (authorToDelete == null) 
                {
                    return Results.NotFound($"No author was found with the following id: {authorId}");
                }
                db.Authors.Remove(authorToDelete);
                db.SaveChanges();
                return Results.Ok(authorToDelete);
            });


        }
    }
}
