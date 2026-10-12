using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the InvestmentsHoldingsGet operation.
/// </summary>
public sealed record InvestmentsHoldingsGetOperationRequest
{
    public required InvestmentsHoldingsGetRequest Body { get; init; }
}
