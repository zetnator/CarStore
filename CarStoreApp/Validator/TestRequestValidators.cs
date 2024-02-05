using CarStore_Models.Requests;
using Microsoft.AspNetCore.Mvc;
using FluentValidation;

namespace CarStoreApp.Validators
{
    public class CarController : ControllerBase
    {
        public class TestRequestValidation : AbstractValidator<GetCarsByBuyerIdRequest>
        {

            public TestRequestValidation()
            {
                RuleFor(x => x.BuyerId)
                    .NotEmpty()
                    .NotNull()
                    .GreaterThan(0).WithMessage("> 0");

                RuleFor(x => x.AfterDate)
                    .NotEmpty()
                    .NotNull();
            }
        }
    }
}