using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CraPartnerInsightsGet operation.
/// </summary>
public sealed record CraPartnerInsightsGetOperationRequest
{
    public required CraPartnerInsightsGetRequest Body { get; init; }
}
