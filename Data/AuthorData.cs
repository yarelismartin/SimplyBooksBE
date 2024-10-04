using SimplyBooks.Models;

namespace SimplyBooks.Data
{
    public class AuthorData
    {
        public static List<Author> Authors = new()
        {
            new()
            {
                Id = 1,
                FirstName = "George",
                LastName = "Orwell",
                Email = "george.orwell@example.com",
                Image = "orwell.jpg",
                Favorite = true,
                Uid = "UID001"
            },
            new()
            {
                Id = 2,
                FirstName = "J.K.",
                LastName = "Rowling",
                Email = "jk.rowling@example.com",
                Image = "rowling.jpg",
                Favorite = true,
                Uid = "UID002"
            },
            new()
            {
                Id = 3,
                FirstName = "Agatha",
                LastName = "Christie",
                Email = "agatha.christie@example.com",
                Image = "christie.jpg",
                Favorite = false,
                Uid = "UID003"
            },
            new()
            {
                Id = 4,
                FirstName = "Mark",
                LastName = "Twain",
                Email = "mark.twain@example.com",
                Image = "twain.jpg",
                Favorite = false,
                Uid = "UID004"
            },
            new()
            {
                Id = 5,
                FirstName = "F. Scott",
                LastName = "Fitzgerald",
                Email = "f.scott.fitzgerald@example.com",
                Image = "fitzgerald.jpg",
                Favorite = true,
                Uid = "UID005"
            }

        };

    }
}

