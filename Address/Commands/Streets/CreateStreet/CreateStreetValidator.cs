using FluentValidation;

namespace Address.Commands.Streets;

public class CreateStreetValidator : AbstractValidator<CreateStreetCommand>
{
    public CreateStreetValidator()
    {
        RuleFor(s => s.Number).NotNull().MinimumLength(30);
        RuleFor(s => s.Name).NotNull().MinimumLength(50);
    }
}
