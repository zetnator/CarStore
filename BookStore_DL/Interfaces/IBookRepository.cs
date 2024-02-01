using BookStore_Models.Models;

namespace BookStore_DL.Interfaces
{
    public interface IBookRepository
    {
        List<Book> GetAll();

        List<Book> GetAllBooksByAuthor(int authorId);

        Book? GetById(int id);

        void Add(Book author);

        void Delete(int id);
    }
}
