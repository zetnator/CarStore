using BookStore_BL.Services;

namespace BookStore.Test
{
    internal class StoreService
    {
        private BookService bookService;
        private AuthorService authorService;

        public StoreService(BookService bookService, AuthorService authorService)
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