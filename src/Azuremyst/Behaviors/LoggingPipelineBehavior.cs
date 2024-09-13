using MediatR;

namespace Azuremyst.Behaviors;

public class LoggingPipelineBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
{
    public async Task<TResponse> Handle(
        TRequest request,
        RequestHandlerDelegate<TResponse> next,
        CancellationToken cancellationToken
    )
    {
        // Pre-processing logic
        Console.WriteLine($"Handling {typeof(TRequest).Name}");

        var response = await next();

        // Post-processing logic
        Console.WriteLine($"Handled {typeof(TRequest).Name}");

        return response;
    }
}
