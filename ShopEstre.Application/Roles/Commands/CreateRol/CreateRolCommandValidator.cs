using FluentValidation;

namespace ShopEstre.Application.Roles.Commands.CreateRol
{
    public class CreateRolCommandValidator : AbstractValidator<CreateRolCommand>
    {
        public CreateRolCommandValidator()
        {
            RuleFor(x => x.Name).NotEmpty().NotNull();
            RuleFor(x => x.Description).NotEmpty();
        }
    }
}
