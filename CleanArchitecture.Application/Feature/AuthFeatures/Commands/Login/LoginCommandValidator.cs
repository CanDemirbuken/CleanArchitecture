using FluentValidation;

namespace CleanArchitecture.Application.Feature.AuthFeatures.Commands.Login;

public sealed class LoginCommandValidator : AbstractValidator<LoginCommand>
{
    public LoginCommandValidator()
    {
        RuleFor(r => r.UserNameOrEmail).NotEmpty().WithMessage("Kullanıcı adı ya da mail bilgisi boş olamaz!");
        RuleFor(r => r.UserNameOrEmail).NotNull().WithMessage("Kullanıcı adı ya da mail bilgisi boş olamaz!");
        RuleFor(r => r.UserNameOrEmail).MinimumLength(3).WithMessage("Kullanıcı adı ya da mail bilgisi en az 3 karakter olmalıdır!");

        RuleFor(r => r.Password).NotEmpty().WithMessage("Şifre boş olamaz!");
        RuleFor(r => r.Password).NotNull().WithMessage("Şifre boş olamaz!");
        RuleFor(r => r.Password).Matches("[A-Z]").WithMessage("Şifre en az bir adet büyük harf içermelidir!");
        RuleFor(r => r.Password).Matches("[a-z]").WithMessage("Şifre en az bir adet küçük harf içermelidir!");
        RuleFor(r => r.Password).Matches("[0-9]").WithMessage("Şifre en az bir adet rakam içermelidir!");
        RuleFor(r => r.Password).Matches("[^a-zA-Z0-9]").WithMessage("Şifre en az bir özel karakter içermelidir!");
    }
}
