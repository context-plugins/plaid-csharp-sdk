using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the ProcessorInvestmentsHoldingsGet operation.
/// </summary>
public sealed record ProcessorInvestmentsHoldingsGetOperationRequest
{
    public required ProcessorInvestmentsHoldingsGetRequest Body { get; init; }
}
