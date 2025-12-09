using FluentValidation;
using SGPL.Domain.Entities;

namespace SGPL.Service.Validators
{
    public class ProductionValidator : AbstractValidator<Production>
    {
        public ProductionValidator()
        {
            RuleFor(p => p.Product)
                .NotEmpty().WithMessage("O nome do produto é obrigatório.")
                .MaximumLength(100).WithMessage("O nome do produto não pode ultrapassar 100 caracteres.");

            RuleFor(p => p.Quantity);
                

            RuleFor(p => p.Feed)
                .NotNull().WithMessage("O alimento (Feed) é obrigatório.");
        }
    }
}