namespace CarStore_Models.Requests
{
    public class GetBooksByAuthorRequest
    {
        public int AuthorId { get; set; }

        public DateTime AfterDate { get; set; }
    }
}
