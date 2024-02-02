using CarStore_Models.Models;

namespace CarStore_BL.Interfaces
{
    public interface IAuthorService
    {
        List<Author> GetAll();

        Author? GetById(int id);

        void Add(Author author);

        void Delete(int id);
    }
}
