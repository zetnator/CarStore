using CarStore_BL.Services;

namespace CarStore.Test
{
    internal class CarStoreService
    {
        private CarService carService;
        private BuyerService buyerService;

        public CarStoreService(CarService carService, BuyerService buyerService)
        {
            this.carService = carService;
            this.buyerService = buyerService;
        }

        internal IEnumerable<object> GetAllCarsCount(int input, int buyerId)
        {
            throw new NotImplementedException();
        }
    }
}