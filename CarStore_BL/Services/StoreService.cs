using CarStore_DL.Interfaces;

namespace CarStore_BL.Services
{
    internal class IStoreService : IStoreRepository
    {
        private readonly IStoreService _storeService;

        public IStoreService(IStoreService storeService)
        {
            _storeService = storeService;
        }

        public string GetStoreName()
        {
            throw new NotImplementedException();
        }
    }
}