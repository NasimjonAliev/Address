//using FluentValidation;

//namespace Address.Commands.Cities;

//public class UpdateCityValidator : AbstractValidator<UpdateCityCommand>
//{
//    public UpdateCityValidator()
//    {
//        RuleFor(c => c.Id).NotEmpty().WithMessage("Заполните Id Region");

//        RuleFor(c => c.Name).NotNull().WithMessage("Заполните название города!").MaximumLength(50);

//        RuleFor(c => c.PostIndex).NotNull().WithMessage("Поля индекс не заполнено");
//    }
//}
