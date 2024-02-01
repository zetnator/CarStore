using BookStore_BL.Services;
using BookStore_DL.Interfaces;
using BookStore_Models.Models;
using Moq;

namespace BookStore.Test
{
    public class LibraryServiceTests
    {
        public static List<Book> BookData = new List<Book>()
        {
            new Book()
            {
                Id = 1,
                AuthorId = 1,
                ReleaseDate = new DateTime(2005,02, 12),
                Title = "Book 1"
            },
            new Book()
            {
                Id = 2,
                AuthorId = 1,
                ReleaseDate = new DateTime(2007,02, 12),
                Title = "Book 2"
            }
        };

        public static List<Author> AuthorData =
            new List<Author>()
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
        [Fact]
        public void GetAllBooksCount_OK()
        {
            //setup
            var input = 10;
            var authorId = 1;
            var expectedCount = 12;

            var mockedBookRepository =
                new Mock<IBookRepository>();
            var mockedAuthorRepository =
                new Mock<IAuthorRepository>();

            mockedBookRepository.Setup(
                x =>
                    x.GetAllBooksByAuthor(authorId))
                .Returns(BookData.Where(b => b.AuthorId == authorId).ToList());

            //inject
            var bookService =
                new BookService(mockedBookRepository.Object);
            var authorService =
                new AuthorService(mockedAuthorRepository.Object);
            var libraryService =
                new LibraryService(bookService, authorService);

            //act
            var result =
                libraryService.GetAllBooksCount(input, authorId);

            //Assert
            Assert.Equal(expectedCount, result);
        }

        [Fact]
        public void GetAllBooksCount_WrongAuthorId()
        {
            //setup
            var input = 10;
            var authorId = 111;
            var expectedCount = 10;

            var mockedBookRepository =
                new Mock<IBookRepository>();
            var mockedAuthorRepository =
                new Mock<IAuthorRepository>();

            mockedBookRepository.Setup(x => x.GetAllBooksByAuthor(authorId))
                                .Returns(BookData.Where(b => b.AuthorId == authorId).ToList());

            //inject
            var bookService =
                new BookService(mockedBookRepository.Object);
            var authorService =
                new AuthorService(mockedAuthorRepository.Object);
            var libraryService =
                new LibraryService(bookService, authorService);

            //act
            var result = libraryService.GetAllBooksCount(input, authorId);

            //Assert
            Assert.Equal(expectedCount, result);
        }

        [Fact]
        public void GetAllBooksCount_NegativeInput()
        {
            //setup
            var input = -10;
            var authorId = 111;
            var expectedCount = 0;

            var mockedBookRepository =
                new Mock<IBookRepository>();
            var mockedAuthorRepository =
                new Mock<IAuthorRepository>();

            mockedBookRepository.Setup(x => x.GetAllBooksByAuthor(authorId))
                                .Returns(BookData.Where(b =>b.AuthorId == authorId).ToList());

            //inject
            var bookService =
                new BookService(mockedBookRepository.Object);
            var authorService =
                new AuthorService(mockedAuthorRepository.Object);
            var libraryService =
                new LibraryService(bookService, authorService);

            //act
            var result =
                libraryService.GetAllBooksCount(input, authorId);

            //Assert
            Assert.Equal(expectedCount, result);
        }
    }
}