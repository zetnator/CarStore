using CarStore_BL.Services;

namespace CarStore.Test
{
    internal class StoreService
    {
        private CarService carService;
        private BuyerService buyerService;

        public StoreService(CarService carService, BuyerService buyerService)
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