using CarStore_BL.Services;

namespace BookStore.Test
{
    internal class StoreService
    {
        private CarService bookService;
        private AuthorService authorService;

        public StoreService(CarService bookService, AuthorService authorService)
        {
            this.bookService = bookService;
            this.authorService = authorService;
        }

        internal IEnumerable<object> GetAllBooksCount(int input, int authorId)
        {
            throw new NotImplementedException();
        }
    }
}