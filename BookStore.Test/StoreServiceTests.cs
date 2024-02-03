using CarStore_BL.Services;
using CarStore_DL.Interfaces;
using CarStore_Models.Models;
using Moq;

namespace CarStore_Test
{
    public class StoreServiceTests
    {
        public static List<Car> CarData = new List<Car>()
        {
            new Car()
            {
                Id = 1,
                BuyerId = 1,
                ReleaseDate = new DateTime(2005,02, 12),
                Brand = "Book 1"
            },
            new Car()
            {
                Id = 2,
                BuyerId = 1,
                ReleaseDate = new DateTime(2007,02, 12),
                Brand = "Book 2"
            }
        };

        public static List<Buyer> AuthorData =
            new List<Buyer>()
            {
                new Buyer()
                {
                    Id = 1,
                    Name = "",
                    BirthDay = DateTime.Now
                },
                new Buyer()
                {
                    Id = 2,
                    Name = "",
                    BirthDay = DateTime.Now
                },
                new Buyer()
                {
                    Id = 3,
                    Name = "",
                    BirthDay = DateTime.Now
                }
            };
        [Fact]
        public void GetAllBooksCount_OK()
        {
            //setup
            var input = 10;
            var buyerId = 1;
            var expectedCount = 12;

            var mockedCarRepository =
                new Mock<ICarRepository>();
            var mockedAuthorRepository =
                new Mock<IBuyerRepository>();

            mockedCarRepository.Setup(
                x =>
                    x.GetAllBooksByAuthor(authorId))
                .Returns(BookData.Where(b => b.AuthorId == authorId).ToList());

            //inject
            var carService =
                new CarService(mockedCarRepository.Object);
            var buyerService =
                new BuyerService(mockedBuyerRepository.Object);
            var storeService =
                new StoreService(carService, buyerService);

            //act
            var result =
                storeService.GetAllBooksCount(input, buyerId);

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

            mockedBookRepository.Setup(x => x.GetAllCarsByBuyer(buyerId))
                                .Returns(CarData.Where(b => b.BuyerId == buyerId).ToList());

            //inject
            var bookService =
                new CarService(mockedBookRepository.Object);
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
            var buyerId = 111;
            var expectedCount = 0;

            var mockedBookRepository =
                new Mock<ICarRepository>();
            var mockedAuthorRepository =
                new Mock<IBuyerRepository>();

            mockedBookRepository.Setup(x => x.GetAllCarsByBuyerId(buyerId))
                                .Returns(CarData.Where(b =>b.BuyerId == BuyerId).ToList());

            //inject
            var bookService =
                new CarService(mockedCarRepository.Object);
            var authorService =
                new BuyerService(mockedBuyerRepository.Object);
            var libraryService =
                new StoreService(carService, buyerService);

            //act
            var result =
                storeService.GetAllBooksCount(input, authorId);

            //Assert
            Assert.Equal(expectedCount, result);
        }
    }
}