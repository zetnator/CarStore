using CarStore_Models.Models;

namespace CarStore_Models.Responses
{
    public class GetBooksByAuthorResponse
    {
        public Buyer Author { get; set; }

        public List<Car> Book { get; set; }
    }
}