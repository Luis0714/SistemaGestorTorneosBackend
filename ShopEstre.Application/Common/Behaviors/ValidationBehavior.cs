using FluentValidation;
using MediatR;
using ShopEstre.Application.Common.Dtos;

namespace ShopEstre.Application.Common.Behaviors
{
    public class ValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
                                                                                                  where TResponse : ResponseCustom<TResponse>
    {
        private readonly IValidator<TRequest>? _validator;
        public ValidationBehavior(IValidator<TRequest>? validator)
        {
            _validator = validator;
        }
        public async Task<TResponse> Handle(
            TRequest request,
            RequestHandlerDelegate<TResponse> next, 
            CancellationToken cancellationToken)
        {
            if (_validator is null) return await next();
            var validatorResult = await _validator.ValidateAsync(request,cancellationToken);
            if(validatorResult.IsValid) return await next();

            var errors = validatorResult.Errors
                                    .Select(validationFailLure => new ResponseCustom<TResponse>(validationFailLure.ErrorMessage, Convert.ToInt32(validationFailLure.ErrorCode)));
            return (dynamic)errors;
        }
    }
}
