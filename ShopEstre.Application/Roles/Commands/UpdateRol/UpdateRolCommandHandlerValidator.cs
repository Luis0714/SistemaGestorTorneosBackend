using FluentValidation;

namespace ShopEstre.Application.Roles.Commands.UpdateRol
{
    public class UpdateRolCommandHandlerValidator : AbstractValidator<UpdateRolCommand>
    {
        public UpdateRolCommandHandlerValidator() 
        {
            RuleFor(p => p.RolId).NotEmpty().NotNull();
            RuleFor(p => p.Name).NotEmpty().NotNull();
            RuleFor(p => p.Description).NotEmpty().NotNull();
        }
    }
}
