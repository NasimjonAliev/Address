using Address.Context;
using FluentValidation;

namespace Address.Commands.Countries;

public class CreateCountryValidator : AbstractValidator<CreateCountryCommand>
{
    public CreateCountryValidator()
    {
        RuleFor(c => c.Name).NotNull().MaximumLength(50);

        RuleFor(c => c.Code).NotNull().MaximumLength(15);

        RuleFor(c => c.Area).MaximumLength(50);

        RuleFor(c => c.Mainland).MaximumLength(50);

        RuleFor(c => c.Population).NotNull().MaximumLength(30);
    }
}