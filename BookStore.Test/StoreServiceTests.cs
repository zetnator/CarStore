using BookStore_BL.Services;
using CarStore_DL.Interfaces;
using CarStore_Models.Models;
using Moq;

namespace BookStore.Test
{
    public class StoreServiceTests
    {
        public static List<Car> BookData = new List<Car>()
        {
            new Car()
            {
                Id = 1,
                AuthorId = 1,
                ReleaseDate = new DateTime(2005,02, 12),
                Title = "Book 1"
            },
            new Car()
            {
                Id = 2,
                AuthorId = 1,
                ReleaseDate = new DateTime(2007,02, 12),
                Title = "Book 2"
            }
        };

        public static List<Buyer> AuthorData =
            new List<Buyer>()
            {
                new Buyer()
                {
                    Id = 1,
                    Name = "Author 1",
                    BirthDay = DateTime.Now
                },
                new Buyer()
                {
                    Id = 2,
                    Name = "Author 2",
                    BirthDay = DateTime.Now
                },
                new Buyer()
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
                new Mock<ICarRepository>();
            var mockedAuthorRepository =
                new Mock<IBuyerRepository>();

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
                new StoreService(bookService, authorService);

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
                new Mock<ICarRepository>();
            var mockedAuthorRepository =
                new Mock<IBuyerRepository>();

            mockedBookRepository.Setup(x => x.GetAllBooksByAuthor(authorId))
                                .Returns(BookData.Where(b => b.AuthorId == authorId).ToList());

            //inject
            var bookService =
                new BookService(mockedBookRepository.Object);
            var authorService =
                new AuthorService(mockedAuthorRepository.Object);
            var libraryService =
                new StoreService(bookService, authorService);

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
                new Mock<ICarRepository>();
            var mockedAuthorRepository =
                new Mock<IBuyerRepository>();

            mockedBookRepository.Setup(x => x.GetAllBooksByAuthor(authorId))
                                .Returns(BookData.Where(b =>b.AuthorId == authorId).ToList());

            //inject
            var bookService =
                new BookService(mockedBookRepository.Object);
            var authorService =
                new AuthorService(mockedAuthorRepository.Object);
            var libraryService =
                new StoreService(bookService, authorService);

            //act
            var result =
                libraryService.GetAllBooksCount(input, authorId);

            //Assert
            Assert.Equal(expectedCount, result);
        }
    }
}