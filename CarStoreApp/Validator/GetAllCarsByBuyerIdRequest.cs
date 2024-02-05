namespace CarStoreApp.Validators
{
    public class GetAllCarsByBuyerIdRequest
    {
        public object? BuyerId { get; internal set; }
        public object? AfterDate { get; internal set; }

    }
}