using FluentValidation;

namespace ShopEstre.Application.Accounts.Querys.AutheticateWithGoogle
{
    public class AuthenticateUserWithGoogleValidator : AbstractValidator<AuthenticateUserWithGoogleQuery>
    {
        public AuthenticateUserWithGoogleValidator()
        {
            RuleFor(property => property.HttpContext).NotEmpty().WithMessage("Token requerido!").NotNull().WithMessage("Token requerido!");
        }
    }
}
