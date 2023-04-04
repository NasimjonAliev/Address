using FluentValidation;

namespace Address.Commands.Countries;

public class UpdateCountryValidator : AbstractValidator<UpdateCountryCommand>
{
    public UpdateCountryValidator()
    {
        RuleFor(c => c.Name).NotNull().MaximumLength(50);

        RuleFor(c => c.Code).NotNull().MaximumLength(15);

        RuleFor(c => c.Area).MaximumLength(50);

        RuleFor(c => c.Mainland).MaximumLength(50);

        RuleFor(c => c.Population).NotNull().MaximumLength(30);
    }
}