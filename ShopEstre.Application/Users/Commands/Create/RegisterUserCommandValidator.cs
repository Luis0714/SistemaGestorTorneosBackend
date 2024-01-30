using FluentValidation;

namespace ShopEstre.Application.Users.Commands.Create
{
    public class RegisterUserCommandValidator : AbstractValidator<RegisterUserCommand>
    {
        public RegisterUserCommandValidator() { 
            RuleFor(property =>  property.Name).NotEmpty();
            RuleFor(property => property.Email).EmailAddress().NotEmpty();
            RuleFor(property => property.Password).NotEmpty().MinimumLength(8);
            RuleFor(property => property.PhoneNumber).Matches(@"^\+\d{1,3}\d{6,14}$").NotEmpty().MinimumLength(10);
        }
    }
}
