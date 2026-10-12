using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransferCreate operation.
/// </summary>
public sealed record TransferCreateOperationRequest
{
    public required TransferCreateRequest Body { get; init; }
}
