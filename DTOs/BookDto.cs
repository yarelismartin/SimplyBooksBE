using SimplyBooks.Models;

namespace SimplyBooks.DTOs
{
    public class BookDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public bool Sale { get; set; }
        public string Uid { get; set; }

        public BookDto(Book book)
        {
            Id = book.Id;
            Title = book.Title;
            Image = book.Image;
            Price = book.Price;
            Sale = book.Sale;
            Uid = book.Uid;
        }

    }
}
