using CarStore.Test;
using CarStore_BL.Services;
using CarStore_DL.Interfaces;
using CarStore_Models.Models;
using Moq;

namespace CarStore_Test
{
    public class CarStoreServiceTests
    {
        public static List<Car> CarData = new List<Car>()
        {
            new Car()
            {
                Id = 1,
                Brand = "Renault",
                Model = "Clio IV",
                ReleaseDate = new DateTime(2014,02, 12),
                BuyerId = 1,
            },
            new Car()
            {
                Id = 2,
                Brand = "Volkswager",
                Model = "Golf Mk5 Variant",
                ReleaseDate = new DateTime(2007,02, 12),
                BuyerId = 2,
            },
            new Car()
            {
                Id = 3,
                Brand = "Mercedes",
                Model = "CLA 45 AMG",
                ReleaseDate = new DateTime(2022,04, 21),
                BuyerId = 3,
            },
            new Car()
            {
                Id = 4,
                Brand = "BMW",
                Model = "i8",
                ReleaseDate = new DateTime(2018,06, 15),
                BuyerId = 4,
            },
            new Car()
            {
                Id = 5,
                Brand = "Audi",
                Model = "RS7",
                ReleaseDate = new DateTime(2023,06, 16),
                BuyerId = 5,
            },
            new Car()
            {
                Id = 6,
                Brand = "Nissan",
                Model = "Micra K12",
                ReleaseDate = new DateTime(2007,06, 16),
                BuyerId = 6,
            }
        };

        public static List<Buyer> BuyerData = new List<Buyer>()
        {
            new Buyer()
            {
                Id = 1,
                Name = "Buyer 1",
                BirthDay = DateTime.Now
            },
            new Buyer()
            {
                Id = 2,
                Name = "Buyer 2",
                BirthDay = DateTime.Now
            },
            new Buyer()
            {
                Id = 3,
                Name = "Buyer 3",
                BirthDay = DateTime.Now
            },
            new Buyer()
            {
                Id = 4,
                Name = "Buyer 4",
                BirthDay = DateTime.Now
            },
            new Buyer()
            {
                Id = 5,
                Name = "Buyer 5",
                BirthDay = DateTime.Now
            },
            new Buyer()
            {
                Id = 6,
                Name = "Buyer 6",
                BirthDay = DateTime.Now
            }
        };

        [Fact]
        public void GetAllCarsCount_OK()
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
                    x.GetAllCarsByBuyerId(buyerId))
                .Returns(CarData.Where(b => b.BuyerId == buyerId).ToList());

            //inject
            var carService =
                new CarService(mockedCarRepository.Object);
            var buyerService =
                new BuyerService(mockedBuyerRepository.Object);
            var storeService =
                new CarStoreService(carService, buyerService);

            //act
            var result =
                storeService.GetAllCarsCount(input, buyerId);

            //Assert
            Assert.Equal(expectedCount, result);
        }

        [Fact]
        public void GetAllCarsCount_WrongBuyerId()
        {
            //setup
            var input = 10;
            var buyerId = 111;
            var expectedCount = 10;

            var mockedBookRepository =
                new Mock<ICarRepository>();
            var mockedAuthorRepository =
                new Mock<IBuyerRepository>();

            mockedBookRepository.Setup(x => x.GetAllCarsByBuyerId(buyerId))
                                .Returns(CarData.Where(b => b.BuyerId == buyerId).ToList());

            //inject
            var bookService =
                new CarService(mockedBookRepository.Object);
            var buyerService =
                new BuyerService(mockedAuthorRepository.Object);
            var storeService =
                new CarStoreService(carService, buyerService);

            //act
            var result = storeService.GetAllCarsCount(input, buyerId);

            //Assert
            Assert.Equal(expectedCount, result);
        }

        [Fact]
        public void GetAllCarsCount_NegativeInput()
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
                                .Returns(CarData.Where(b =>b.BuyerId == buyerId).ToList());

            //inject
            var bookService =
                new CarService(mockedCarRepository.Object);
            var authorService =
                new BuyerService(mockedBuyerRepository.Object);
            var libraryService =
                new CarStoreService(carService, buyerService);

            //act
            var result =
                storeService.GetAllCarsCount(input, buyerId);

            //Assert
            Assert.Equal(expectedCount, result);
        }
    }
}