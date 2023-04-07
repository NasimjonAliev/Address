using FluentValidation;

namespace Address.Commands.Streets;

public class CreateStreetValidator : AbstractValidator<CreateStreetCommand>
{
    public CreateStreetValidator()
    {
        RuleFor(s => s.Number).NotNull().MaximumLength(30);
        RuleFor(s => s.Name).NotNull().MaximumLength(50);
    }
}
