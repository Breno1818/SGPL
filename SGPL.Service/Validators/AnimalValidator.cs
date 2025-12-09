using FluentValidation;
using SGPL.Domain.Entities;

namespace SGPL.Service.Validators
{
    public class AnimalValidator : AbstractValidator<Animal>
    {
        public AnimalValidator()
        {
            RuleFor(animal => animal.Name)
                .NotEmpty().WithMessage("Nome do animal é obrigatório.")
                .MaximumLength(100).WithMessage("Nome do animal não pode ultrapassar 100 caracteres.");
            RuleFor(animal => animal.Age)
                .GreaterThanOrEqualTo(0).WithMessage("Idade não pode ser negativa.")
                .LessThanOrEqualTo(50).WithMessage("Idade do animal é muito alta.");
            RuleFor(animal => animal.Production)
                .NotNull().WithMessage("A produção do animal deve ser informada.");
            When(animal => animal.Producer, () =>
            {
                RuleFor(animal => animal.Production)
                    .NotNull().WithMessage("Animais produtores devem ter uma produção vinculada.");
            });
        }
    }
}