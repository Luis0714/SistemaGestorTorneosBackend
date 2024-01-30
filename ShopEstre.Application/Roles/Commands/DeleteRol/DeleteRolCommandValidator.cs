using FluentValidation;

namespace ShopEstre.Application.Roles.Commands.DeleteRol
{
    public class DeleteRolCommandValidator : AbstractValidator<DeleteRolCommand>
    {
        public DeleteRolCommandValidator() { 
            RuleFor(p => p.RolId).NotEmpty().NotNull();
        }
    }
}
