using FluentValidation;

namespace Address.Commands.Regions;

public class CreateRegionValidator : AbstractValidator<CreateRegionCommand>
{
    public CreateRegionValidator()
    {
        RuleFor(r => r.Name).NotNull().MaximumLength(50);
        RuleFor(r => r.DistrictName).NotNull().MaximumLength(50);
    }
}
