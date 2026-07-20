using FluentValidation;

namespace CleanArchitecture.Application.Feature.RoleFeatures.Commands.CreateRole;

public sealed class CreateRoleCommandValidator : AbstractValidator<CreateRoleCommand>
{
    public CreateRoleCommandValidator()
    {
        RuleFor(r => r.Name).NotEmpty().WithMessage("Rol adı boş olamaz!");
        RuleFor(r => r.Name).NotNull().WithMessage("Rol adı boş olamaz!");
    }
}
