using CarStore_Models.Responses;
using CarStore_Models.Requests;
using CarStore_BL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarStoreApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarStoreController : ControllerBase
    {
        private readonly ICarStoreService _storeService;
        public CarStoreController(ICarStoreService storeService)
        {
            _storeService = storeService;
        }


        [HttpPost("GetCarsByBuyerId")]
        public GetCarsByBuyerIdResponse? GetAllCarsByBuyerId(GetCarsByBuyerIdRequest request) => _storeService.GetCarsByBuyerId(request);
    }
}
