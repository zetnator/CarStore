using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarStore_Models.Models;

namespace CarStore_DL.Interfaces
{
    public interface IAuthorRepository
    {
        List<Author> GetAll();

        Author? GetById(int id);

        void Add(Author author);

        void Delete(int id);
    }
}
