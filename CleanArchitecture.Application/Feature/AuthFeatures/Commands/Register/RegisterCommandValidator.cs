using FluentValidation;

namespace CleanArchitecture.Application.Feature.AuthFeatures.Commands.Register;

public sealed class RegisterCommandValidator : AbstractValidator<RegisterCommand>
{
    public RegisterCommandValidator()
    {
        RuleFor(r => r.Email).NotEmpty().WithMessage("Mail bilgisi boş olamaz!");
        RuleFor(r => r.Email).NotNull().WithMessage("Mail bilgisi boş olamaz!");
        RuleFor(r => r.Email).EmailAddress().WithMessage("Geçerli bir mail adresi girin!");

        RuleFor(r => r.UserName).NotEmpty().WithMessage("Kullanıcı adı boş olamaz!");
        RuleFor(r => r.UserName).NotNull().WithMessage("Kullanıcı adı boş olamaz!");
        RuleFor(r => r.UserName).MinimumLength(3).WithMessage("Kullanıcı adı en az 3 karakter olmalıdır!");

        RuleFor(r => r.Password).NotEmpty().WithMessage("Şifre boş olamaz!");
        RuleFor(r => r.Password).NotNull().WithMessage("Şifre boş olamaz!");
        RuleFor(r => r.Password).Matches("[A-Z]").WithMessage("Şifre en az bir adet büyük harf içermelidir!");
        RuleFor(r => r.Password).Matches("[a-z]").WithMessage("Şifre en az bir adet küçük harf içermelidir!");
        RuleFor(r => r.Password).Matches("[0-9]").WithMessage("Şifre en az bir adet rakam içermelidir!");
        RuleFor(r => r.Password).Matches("[^a-zA-Z0-9]").WithMessage("Şifre en az bir özel karakter içermelidir!");
    }
}
