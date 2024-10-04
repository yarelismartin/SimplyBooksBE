using SimplyBooks.Models;

namespace SimplyBooks.DTOs
{
    public class AuthorDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Favorite { get; set; }
        public string Uid { get; set; }

        public AuthorDto(Author author)
        {
            Id = author.Id;
            FirstName = author.FirstName;
            LastName = author.LastName;
            Favorite = author.Favorite;
            Uid = author.Uid;
        }
    }

}
