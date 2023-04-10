using FluentValidation;

namespace Address.Commands.Regions;

public class UpdateRegionValidator : AbstractValidator<UpdateRegionCommand>
{
    public UpdateRegionValidator()
    {
        RuleFor(r => r.Name).NotNull().MaximumLength(50);
        RuleFor(r => r.DistrictName).NotNull().MaximumLength(50);
    }
}
