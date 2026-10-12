using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CreditSessionsGet operation.
/// </summary>
public sealed record CreditSessionsGetOperationRequest
{
    public required CreditSessionsGetRequest Body { get; init; }
}
