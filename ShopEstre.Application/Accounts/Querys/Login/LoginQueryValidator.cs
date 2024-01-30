using FluentValidation;

namespace ShopEstre.Application.Accounts.Querys.Login
{
    public class LoginQueryValidator : AbstractValidator<LoginQuery>
    {
        public LoginQueryValidator() { 
            RuleFor(property => property.Email).NotEmpty().WithMessage("El correo es obligatorio")
                                               .EmailAddress().WithMessage("No es una direccion de correo electronico");
            RuleFor(property => property.Password).NotEmpty().WithMessage("La contraseña es obligatoria")
                                                  .NotNull().WithMessage("La contraseña es obligatoria");
        }
    }
}
