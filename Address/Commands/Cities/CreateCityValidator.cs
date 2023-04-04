//using Address.Context;
//using FluentValidation;

//namespace Address.Commands.Cities;

//public class CreateCityValidator : AbstractValidator<CreateCityCommand>
//{
//    public CreateCityValidator()
//    {
//        RuleFor(c => c.Name).NotNull().WithMessage("Заполните название города!").MaximumLength(50);

//        RuleFor(c => c.PostIndex).NotNull().WithMessage("Поля индекс не заполнено");
//    }
//}
