using CarStore_Models.Models;
using CarStore_DL.Interfaces;
using CarStore_BL.Interfaces;


namespace BookStore_BL.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void Add(Book book)
        {
            _bookRepository.Add(book);
        }

        public void Delete(int id)
        {
            _bookRepository.Delete(id);
        }

        public List<Book> GetAll()
        {
            return _bookRepository.GetAll();
        }

        public Book? GetBooksById(int id)
        {
            throw new NotImplementedException();
        }

        public Book? GetById(int id)
        {
            return _bookRepository.GetById(id);
        }

       
    }
}
