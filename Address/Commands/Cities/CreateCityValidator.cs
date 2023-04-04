using Address.Context;
using FluentValidation;

namespace Address.Commands.Cities;

public class CreateCityValidator : AbstractValidator<CreateCityCommand>
{
    public CreateCityValidator()
    {
        RuleFor(c => c.Name).NotNull().MaximumLength(50);

        RuleFor(c => c.PostIndex).NotNull();
    }
}
