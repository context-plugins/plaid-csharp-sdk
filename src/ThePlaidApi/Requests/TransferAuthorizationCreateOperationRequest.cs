using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransferAuthorizationCreate operation.
/// </summary>
public sealed record TransferAuthorizationCreateOperationRequest
{
    public required TransferAuthorizationCreateRequest Body { get; init; }
}
