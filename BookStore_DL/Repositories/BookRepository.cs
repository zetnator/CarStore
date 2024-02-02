using CarStore_Models.Models;
using CarStore_DL.Interfaces;
using CarStore_DL.MemoryDB;

namespace CarStore_DL.Repositories
{
    public class BookRepository : IBookRepository
    {
        public void Add(Book book)
        {
            InMemoryDB.BookData.Add(book);
        }

        public void Delete(int id)
        {
            var book = GetById(id);
            if (book != null)
            {
                InMemoryDB.BookData.Remove(book);
            }

        }

        public List<Book> GetAll()
        {
            return InMemoryDB.BookData;
        }

        public Book? GetById(int id)
        {
            return InMemoryDB.BookData.FirstOrDefault(a => a.Id == id);
        }

        void IBookRepository.Add(Book author)
        {
            throw new NotImplementedException();
        }

        void IBookRepository.Delete(int id)
        {
            throw new NotImplementedException();
        }

        List<Book> IBookRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        List<Book> IBookRepository.GetAllBooksByAuthor(int authorId)
        {
            return InMemoryDB.BookData.Where(b => b.AuthorId == authorId).ToList();
        }

        Book? IBookRepository.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
