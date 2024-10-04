using SimplyBooks.Models;

namespace SimplyBooks.Data
{
    public class BookData
    {
        public static List<Book> Books = new()
        {
            new()
            {
                Id = 1,
                Title = "1984",
                Description = "A dystopian novel set in a totalitarian society ruled by Big Brother.",
                AuthorId = 1, // George Orwell
                Image = "1984.jpg",
                Price = 14.99m,
                Sale = true,
                Uid = "BID001"
            },
            new()
            {
                Id = 2,
                Title = "Animal Farm",
                Description = "A political satire that allegorizes the rise of Stalinism.",
                AuthorId = 1, // George Orwell
                Image = "animal_farm.jpg",
                Price = 9.99m,
                Sale = false,
                Uid = "BID002"
            },
            new()
            {
                Id = 3,
                Title = "Harry Potter and the Sorcerer's Stone",
                Description = "The first book in the Harry Potter series about a young wizard.",
                AuthorId = 2, // J.K. Rowling
                Image = "hp_sorcerer_stone.jpg",
                Price = 12.99m,
                Sale = false,
                Uid = "BID003"
            },
            new()
            {
                Id = 4,
                Title = "Harry Potter and the Chamber of Secrets",
                Description = "The second book in the Harry Potter series.",
                AuthorId = 2, // J.K. Rowling
                Image = "hp_chamber_secrets.jpg",
                Price = 13.99m,
                Sale = true,
                Uid = "BID004"
            },
            new()
            {
                Id = 5,
                Title = "Murder on the Orient Express",
                Description = "A famous detective novel featuring Hercule Poirot.",
                AuthorId = 3, // Agatha Christie
                Image = "orient_express.jpg",
                Price = 11.99m,
                Sale = false,
                Uid = "BID005"
            },
            new()
            {
                Id = 6,
                Title = "The ABC Murders",
                Description = "Another thrilling mystery from Agatha Christie.",
                AuthorId = 3, // Agatha Christie
                Image = "abc_murders.jpg",
                Price = 10.99m,
                Sale = true,
                Uid = "BID006"
            },
            new()
            {
                Id = 7,
                Title = "The Adventures of Huckleberry Finn",
                Description = "A novel about the adventures of Huck Finn along the Mississippi River.",
                AuthorId = 4, // Mark Twain
                Image = "huck_finn.jpg",
                Price = 8.99m,
                Sale = false,
                Uid = "BID007"
            },
            new()
            {
                Id = 8,
                Title = "The Adventures of Tom Sawyer",
                Description = "A story about the mischievous adventures of Tom Sawyer.",
                AuthorId = 4, // Mark Twain
                Image = "tom_sawyer.jpg",
                Price = 7.99m,
                Sale = true,
                Uid = "BID008"
            },
            new()
            {
                Id = 9,
                Title = "The Great Gatsby",
                Description = "A novel about the mysterious Jay Gatsby and his love for Daisy Buchanan.",
                AuthorId = 5, // F. Scott Fitzgerald
                Image = "gatsby.jpg",
                Price = 10.99m,
                Sale = true,
                Uid = "BID009"
            },
            new()
            {
                Id = 10,
                Title = "Tender Is the Night",
                Description = "A novel about the rise and fall of a glamorous American couple.",
                AuthorId = 5, // F. Scott Fitzgerald
                Image = "tender_night.jpg",
                Price = 12.49m,
                Sale = false,
                Uid = "BID010"
            }
        };
    }
}
