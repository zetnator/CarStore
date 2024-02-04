namespace CarStoreApp.Validators
{
    public class GetAllCarsByBuyerRequest
    {
        public object? BuyerId { get; internal set; }
        public object? AfterDate { get; internal set; }

    }
}