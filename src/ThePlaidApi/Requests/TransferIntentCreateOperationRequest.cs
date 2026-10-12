using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransferIntentCreate operation.
/// </summary>
public sealed record TransferIntentCreateOperationRequest
{
    public required TransferIntentCreateRequest Body { get; init; }
}
