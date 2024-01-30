using FluentValidation;

namespace ShopEstre.Application.Users.Commands.UpdateUser
{
    public class UpdateUserCommandValidator : AbstractValidator<UpdateUserCommand>
    {
        public UpdateUserCommandValidator() {
            RuleFor(p => p.UserId).NotEmpty();
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.LastName).NotEmpty();
            RuleFor(p => p.Email).NotEmpty();
            RuleFor(p => p.PhoneNumber).Matches(@"^\d{10}$").NotEmpty();
            RuleFor(p => p.RoleId).NotEmpty();
        }
    }

}
