using BookStore_Models.Models;

namespace BookStore_Models.Responses
{
    public class GetBooksByAuthorResponse
    {
        public Author Author { get; set; }

        public List<Book> Book { get; set; }
    }
}