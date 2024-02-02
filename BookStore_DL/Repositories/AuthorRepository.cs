using CarStore_DL.Interfaces;
using CarStore_DL.MemoryDB;
using CarStore_Models.Models;

namespace CarStore_DL.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        public void Add(Author author)
        {
            InMemoryDB.AuthorData.Add(author);
        }

        public void Delete(int id)
        {
            var author = GetById(id);
            if (author != null)
            {
                InMemoryDB.AuthorData.Remove(author);
            }
            
        }

        public List<Author> GetAll()
        {
            return InMemoryDB.AuthorData;
        }

        public Author? GetById(int id)
        {
            return InMemoryDB.AuthorData.FirstOrDefault(a => a.Id == id);
        }
    }
}
