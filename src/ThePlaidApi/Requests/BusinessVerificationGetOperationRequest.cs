using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the BusinessVerificationGet operation.
/// </summary>
public sealed record BusinessVerificationGetOperationRequest
{
    public required BusinessVerificationGetRequest Body { get; init; }
}
