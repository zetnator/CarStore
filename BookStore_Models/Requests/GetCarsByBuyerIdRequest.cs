namespace CarStore_Models.Requests
{
    public class GetCarsByBuyerIdRequest
    {
        public int BuyerId { get; set; }

        public DateTime AfterDate { get; set; }
    }
}
