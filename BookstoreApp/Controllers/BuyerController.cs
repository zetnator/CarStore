using CarStore_Models.Models;
using CarStore_BL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookstoreApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BuyerController : ControllerBase
    {
        private readonly IBuyerService _buyerService;
    

        public BuyerController(IBuyerService authorService)
        {
            _buyerService = authorService;
        }

        [HttpGet( "GetAll")]
        public IEnumerable<Buyer> GetAll()
        {
            return _buyerService.GetAll();
        }
        [HttpGet("GetById")]
        public Buyer? GetById(int id) 
        { 
            return _buyerService.GetById(id);
        }

        [HttpGet("Add")]
        public void Add([FromBody] Buyer author)
        { 
            _buyerService.Add(author);
        }

        [HttpGet("Delete")]
        public void Delete(int id)
        {
            _buyerService.Delete(id);
        }
    }
}
