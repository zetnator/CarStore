using CarStore_Models.Responses;
using CarStore_Models.Requests;
using CarStore_BL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarStoreApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private readonly ICarStoreService _storeService;
        public StoreController(ICarStoreService storeService)
        {
            _storeService = storeService;
        }

        
        [HttpPost("GetCarsByBuyerId")]
        public GetCarsByBuyerIdResponse? GetAllCarsByBuyerId(GetCarsByBuyerIdRequest request)
        {
            return _storeService.GetCarsByBuyerId(request);
        }
    }
}
