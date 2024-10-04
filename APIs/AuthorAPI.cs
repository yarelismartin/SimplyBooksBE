using SimplyBooks.DTOs;

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

            });

            // GET BY UID
            app.MapGet("/authors/{uid}", (SimplyBooksDbContext db, string uid) =>
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


            // UPDATE AUTHOR


            // DELETE AUTHOR



        }
    }
}
