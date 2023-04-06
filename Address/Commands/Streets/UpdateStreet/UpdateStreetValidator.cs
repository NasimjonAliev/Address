using FluentValidation;

namespace Address.Commands.Streets;

public class UpdateStreetValidator : AbstractValidator<UpdateStreetCommand>
{
    public UpdateStreetValidator()
    {
        RuleFor(s => s.Number).NotNull().MinimumLength(30);
        RuleFor(s => s.Name).NotNull().MinimumLength(50);
    }
}
