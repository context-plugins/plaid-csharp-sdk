using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the LinkOauthCorrelationIdExchange operation.
/// </summary>
public sealed record LinkOauthCorrelationIdExchangeOperationRequest
{
    public required LinkOAuthCorrelationIdExchangeRequest Body { get; init; }
}
