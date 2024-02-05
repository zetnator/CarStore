using CarStore_Models.Models;
using CarStore_BL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarStoreApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BuyerController : ControllerBase
    {
        private readonly IBuyerService _buyerService;
    
        public BuyerController(IBuyerService buyerService)
        {
            _buyerService = buyerService;
        }

        [HttpGet( "GetAllBuyers")]
        public IEnumerable<Buyer> GetAllBuyers()
        {
            return _buyerService.GetAllBuyers();
        }
        [HttpGet("GetBuyerById")]
        public Buyer? GetBuyerById(int id) 
        { 
            return _buyerService.GetBuyerById(id);
        }

        [HttpGet("AddBuyer")]
        public void AddBuyer([FromBody] Buyer buyer)
        { 
            _buyerService.Add(buyer);
        }

        [HttpGet("DeleteBuyer")]
        public void DeleteBuyer(int id)
        {
            _buyerService.DeleteBuyer(id);
        }
    }
}
