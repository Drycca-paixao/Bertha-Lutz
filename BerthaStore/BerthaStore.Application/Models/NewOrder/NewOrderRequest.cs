using FluentValidation;
using System.Collections.Generic;

namespace BerthaStore.Application.Models.NewOrder
{
    public class NewOrderRequest
    {
        public int IdClient { get; set; }
        public string PaymentType { get; set; }
        public List<AddItemOrderRequest> ItensOrder { get; set; }
    }

    public class NewOrderRequestValidator : AbstractValidator<NewOrderRequest>
    {
        public NewOrderRequestValidator()
        {
            RuleFor(r => r.IdClient)
                .NotEmpty()
                .WithMessage("\'IdClient\' cannot be empty.")
                .NotNull()
                .WithMessage("\'IdClient\' cannot be null.");
            RuleFor(r => r.PaymentType)
                .NotEmpty()
                .WithMessage("\'PaymentType\' cannot be empty.")
                .NotNull()
                .WithMessage("\'PaymentType\' cannot be null.");
            RuleForEach(r => r.ItensOrder)
                .NotEmpty()
                .WithMessage("\'ItensOrder\' cannot be empty.")
                .NotNull()
                .WithMessage("\'ItensOrder\' cannot be null.");
        }
    }
}
