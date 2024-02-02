using CarStore_Models.Models;

namespace CarStore_Models.Responses
{
    public class GetBooksByAuthorResponse
    {
        public Author Author { get; set; }

        public List<Book> Book { get; set; }
    }
}