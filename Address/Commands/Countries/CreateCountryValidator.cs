using FluentValidation;

namespace Address.Commands.Countries;

public class CreateCountryValidator : AbstractValidator<CreateCountryCommand>
{
    public CreateCountryValidator()
    {
        RuleFor(c => c.Name).NotNull().WithMessage("Заполните название города!").MaximumLength(50);

        RuleFor(c => c.Code).NotNull().WithMessage("Поля код страны не заполнено").MaximumLength(15);

        RuleFor(c => c.Area).MaximumLength(50);

        RuleFor(c => c.Mainland).MaximumLength(50);

        RuleFor(c => c.Population).NotNull().WithMessage("Заполните число население").MaximumLength(30);
    }
}