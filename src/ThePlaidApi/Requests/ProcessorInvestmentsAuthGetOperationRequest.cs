using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the ProcessorInvestmentsAuthGet operation.
/// </summary>
public sealed record ProcessorInvestmentsAuthGetOperationRequest
{
    public required ProcessorInvestmentsAuthGetRequest Body { get; init; }
}
