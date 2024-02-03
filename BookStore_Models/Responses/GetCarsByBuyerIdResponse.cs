using CarStore_Models.Models;

namespace CarStore_Models.Responses
{
    public class GetCarsByBuyerIdResponse
    {
        public Buyer Buyer{ get; set; }

        public List<Car> Car { get; set; }
    }
}