using Grpc.Core;

namespace FinanceSystem.Search.Services;

public class SearchService : FinanceSystemSearch.FinanceSystemSearchBase
{
    private readonly ILogger<SearchService> _logger;

    public SearchService(ILogger<SearchService> logger)
    {
        _logger = logger;
    }

    public override Task<IndexResponse> ReindexPayment(PaymentIndex request, ServerCallContext context)
    {
        _logger.LogInformation($"Get message payment {request}");

        return Task.FromResult(new IndexResponse { IsSuccess = true });
    }
}