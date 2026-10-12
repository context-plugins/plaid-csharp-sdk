using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransferIntentGet operation.
/// </summary>
public sealed record TransferIntentGetOperationRequest
{
    public required TransferIntentGetRequest Body { get; init; }
}
