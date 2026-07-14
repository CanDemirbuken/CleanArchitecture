using FluentValidation;
using FluentValidation.Results;
using MediatR;

namespace CleanArchitecture.Application.Behaviors;

public class ValidationBehavior<TRequest, TResponse>(IEnumerable<IValidator<TRequest>> validators) : IPipelineBehavior<TRequest, TResponse> where TRequest : class, IRequest<TResponse>
{
    private readonly IEnumerable<IValidator<TRequest>> validators = validators;

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        if (!validators.Any())
            return await next();

        var context = new ValidationContext<TRequest>(request);
        var errorDictionary = validators
            .Select(v => v.Validate(context))
            .SelectMany(v => v.Errors)
            .Where(v => v != null)
            .GroupBy(
            v => v.PropertyName,
            v => v.ErrorMessage, (propertyName, errorMessage) => new
            {
                Key = propertyName,
                Values = errorMessage.Distinct().ToArray()
            }).ToDictionary(v => v.Key, v => v.Values[0]);

        if (errorDictionary.Any())
        {
            var errors = errorDictionary.Select(v => new ValidationFailure
            {
                PropertyName = v.Value,
                ErrorCode = v.Key
            });

            throw new ValidationException(errors);
        }

        return await next();
    }
}