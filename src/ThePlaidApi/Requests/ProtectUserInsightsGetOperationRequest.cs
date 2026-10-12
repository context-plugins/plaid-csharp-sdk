using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the ProtectUserInsightsGet operation.
/// </summary>
public sealed record ProtectUserInsightsGetOperationRequest
{
    public required ProtectUserInsightsGetRequest Body { get; init; }
}
