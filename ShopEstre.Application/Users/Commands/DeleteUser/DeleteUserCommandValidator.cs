using FluentValidation;

namespace ShopEstre.Application.Users.Commands.DeleteUser
{
    public class DeleteUserCommandValidator : AbstractValidator<DeleteUserCommand>
    {
        public DeleteUserCommandValidator() 
        {
            RuleFor(p => p.UserId).NotEmpty();
        }
    }
}
