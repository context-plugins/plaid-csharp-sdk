using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CreditFreddieMacReportsGet operation.
/// </summary>
public sealed record CreditFreddieMacReportsGetOperationRequest
{
    public required CreditFreddieMacReportsGetRequest Body { get; init; }
}
