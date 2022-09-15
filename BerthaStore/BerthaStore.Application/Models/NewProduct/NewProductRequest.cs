using FluentValidation;

namespace BerthaStore.Application.Models.NewProduct
{
    public class NewProductRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Storage { get; set; }
    }

    public class NewProductRequestValidator : AbstractValidator<NewProductRequest>
    {
        public NewProductRequestValidator()
        {
            RuleFor(r => r.Name)
                .NotEmpty()
                .WithMessage("\'Name\' cannot be empty.")
                .NotNull()
                .WithMessage("\'Name\' cannot be null.");
            RuleFor(r => r.Price)
                .NotEmpty()
                .WithMessage("\'Price\' cannot be empty.")
                .NotNull()
                .WithMessage("\'Price\' cannot be null.");
            RuleFor(r => r.Storage)
                .NotEmpty()
                .WithMessage("\'Storage\' cannot be empty.")
                .NotNull()
                .WithMessage("\'Storage\' cannot be null.");
        }
    }
}
