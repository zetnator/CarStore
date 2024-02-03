using CarStore_Models.Responses;
using CarStore_Models.Requests;
using CarStore_BL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookstoreApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private readonly IStoreService _storeService;
        public StoreController(IStoreService storeService)
        {
            _storeService = storeService;
        }

        
        [HttpPost("GetAllCarsByBuyerId")]
        public GetCarsByBuyerIdResponse? GetAllCarsByBuyerId(GetCarsByBuyerRequest requst)
        {
            return _storeService.GetCarsByBuyer(requst);
        }
    }
}
