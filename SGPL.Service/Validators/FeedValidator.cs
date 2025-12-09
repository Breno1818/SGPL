using FluentValidation;
using SGPL.Domain.Entities;

namespace SGPL.Service.Validators
{
    public class FeedValidator : AbstractValidator<Feed>
    {
        public FeedValidator()
        {
            RuleFor(feed => feed.FeedType)
                .NotEmpty().WithMessage("O tipo de ração é obrigatório.")
                .MaximumLength(100).WithMessage("O tipo de ração não pode ultrapassar 100 caracteres.");
            RuleFor(feed => feed.Quantity)
                .GreaterThan(0).WithMessage("A quantidade deve ser maior que zero.")
                .LessThanOrEqualTo(10000).WithMessage("Quantidade muito alta.");
        }
    }
}