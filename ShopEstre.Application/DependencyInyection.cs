using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using ShopEstre.Application.Common.Behaviors;
using System.Reflection;

namespace ShopEstre.Application
{
    public static class DependencyInyection
    {
        public static void AddApplication(this IServiceCollection services)
        {
            #region Mapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            #endregion

            services.AddValidatorsFromAssemblyContaining<ApplicationAssemblyReference>(); //Inyectado fluent Validation
           // services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddMediatR(config => config.RegisterServicesFromAssemblyContaining<ApplicationAssemblyReference>()); //Inyectando MidiaR
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
           

           
        }
    }
}
