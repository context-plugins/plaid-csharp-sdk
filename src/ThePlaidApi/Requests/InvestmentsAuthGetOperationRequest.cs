using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the InvestmentsAuthGet operation.
/// </summary>
public sealed record InvestmentsAuthGetOperationRequest
{
    public required InvestmentsAuthGetRequest Body { get; init; }
}
