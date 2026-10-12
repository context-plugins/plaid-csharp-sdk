using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransferGet operation.
/// </summary>
public sealed record TransferGetOperationRequest
{
    public required TransferGetRequest Body { get; init; }
}
