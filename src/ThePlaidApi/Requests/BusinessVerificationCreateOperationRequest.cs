using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the BusinessVerificationCreate operation.
/// </summary>
public sealed record BusinessVerificationCreateOperationRequest
{
    public required BusinessVerificationCreateRequest Body { get; init; }
}
