using CarStore_Models.Models;

namespace CarStore_BL.Interfaces
{
    public interface IBookService
    {
        List<Book> GetAll();

        Book? GetBooksById(int id);

        void Add(Book book);

        void Delete(int id);
    }
}
