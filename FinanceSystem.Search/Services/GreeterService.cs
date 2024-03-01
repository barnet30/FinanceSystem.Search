using Grpc.Core;
using FinanceSystem.Search;

namespace FinanceSystem.Search.Services;

public class GreeterService : Greeter.GreeterBase
{
    private readonly ILogger<GreeterService> _logger;

    public GreeterService(ILogger<GreeterService> logger)
    {
        _logger = logger;
    }

    public override Task<TestReply> SayHello(HelloRequest request, ServerCallContext context)
    {
        Console.WriteLine("Hello " + request.Name);
        
        return Task.FromResult(new TestReply
        {
            Query = "Hello " + request.Name
        });
    }
}