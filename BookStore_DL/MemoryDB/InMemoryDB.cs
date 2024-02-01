using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore_Models.Models;

namespace BookStore_DL.MemoryDB
{
    public static class InMemoryDB
    {
        public static List<Author> AuthorData = new List<Author>()
        {
            new Author()
            {
                Id = 1,
                Name = "Author 1",
                BirthDay = DateTime.Now
            },
              new Author()
            {
                Id = 2,
                Name = "Author 2",
                BirthDay = DateTime.Now
            },
                new Author()
            {
                Id = 3,
                Name = "Author 3",
                BirthDay = DateTime.Now
            }
        };

        public static List<Book> BookData = new List<Book>()
        {
            new Book()
            {
                Id = 1,
                Title = "Book 1",
                ReleaseDate = new DateTime(2005,02, 12),
                AuthorId = 1,
            },
            new Book()
            {
                Id = 2,
                Title = "Book 2",
                ReleaseDate = new DateTime(2007,02, 12),
                AuthorId = 2,
            },
            new Book()
            {
                Id = 3,
                Title = "Book 3",
                ReleaseDate = DateTime.Now,
                AuthorId = 3,
            }
        };
    }
}
