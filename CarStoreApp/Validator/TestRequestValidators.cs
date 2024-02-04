using FluentValidation;

namespace CarStoreApp.Validators
{
    public class TestRequestValidation : AbstractValidator<GetAllCarsByBuyerRequest>
    {

        public TestRequestValidation()
        {
            RuleFor(x => x.BuyerId)
                .NotEmpty().NotNull();

            RuleFor(x => x.AfterDate)
                .NotEmpty().NotNull();
        }
    }
}