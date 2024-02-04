using CarStore_Models.Models;

namespace CarStore_DL.MemoryDB
{
    public static class InMemoryDB
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
    }
}
