using FluentValidation;

namespace CleanArchitecture.Application.Feature.UserRoleFeatures.Commands.CreateUserRole;

public sealed class CreateUserRoleCommandValidator : AbstractValidator<CreateUserRoleCommand>
{
    public CreateUserRoleCommandValidator()
    {
        RuleFor(u => u.UserId).NotEmpty().WithMessage("Kullanıcı bilgisi boş olamaz!");
        RuleFor(u => u.UserId).NotNull().WithMessage("Kullanıcı bilgisi boş olamaz!");
        RuleFor(u => u.RoleId).NotEmpty().WithMessage("Rol bilgisi boş olamaz!");
        RuleFor(u => u.RoleId).NotNull().WithMessage("Rol bilgisi boş olamaz!");
    }
}