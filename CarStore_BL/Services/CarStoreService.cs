using CarStore_BL.Interfaces;
using CarStore_Models.Requests;
using CarStore_Models.Responses;

namespace CarStore_BL.Services
{
    internal class CarStoreService : ICarStoreService
    {
        private readonly ICarStoreService _carService;
        private readonly IBuyerService _buyerService;

        public CarStoreService(IBuyerService buyerService, ICarStoreService carService)
        {
            _buyerService = buyerService;
            _carService = carService;
        }

        public int CheckBuyerCount(int input)
        {
            var carsCount = _carService.GetAllCars();
            return carsCount.Count + input;
        }

        public GetCarsByBuyerIdResponse? GetByBuyer(GetCarsByBuyerIdRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
