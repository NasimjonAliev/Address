using FluentValidation;

namespace Address.Commands.Cities;

public class UpdateCityValidator : AbstractValidator<UpdateCityCommand>
{
    public UpdateCityValidator()
    {
        RuleFor(c => c.Name).NotNull().MaximumLength(50);

        RuleFor(c => c.PostIndex).NotNull();
    }
}
