using FluentValidation;

namespace CleanArchitecture.Application.Feature.CarFeatures.Commands.CreateCar;

public sealed class CreateCarCommandValidator : AbstractValidator<CreateCarCommand>
{
    public CreateCarCommandValidator()
    {
        RuleFor(c => c.Name).NotEmpty().WithMessage("Araç adı boş olamaz!");
        RuleFor(c => c.Name).NotNull().WithMessage("Araç adı boş olamaz!");
        RuleFor(c => c.Name).MinimumLength(3).WithMessage("Araç adı en az 3 karakter olmalıdır!");

        RuleFor(c => c.Model).NotEmpty().WithMessage("Araç modeli boş olamaz!");
        RuleFor(c => c.Model).NotNull().WithMessage("Araç modeli boş olamaz!");
        RuleFor(c => c.Model).MinimumLength(3).WithMessage("Araç modeli en az 3 karakter olmalıdır!");

        RuleFor(c => c.EnginePower).NotEmpty().WithMessage("Araç motor gücü boş olamaz!");
        RuleFor(c => c.EnginePower).NotNull().WithMessage("Araç motor gücü boş olamaz!");
        RuleFor(c => c.EnginePower).GreaterThan(0).WithMessage("Araç motor gücü 0'dan büyük olmalıdır!");
    }
}