using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the WalletGet operation.
/// </summary>
public sealed record WalletGetOperationRequest
{
    public required WalletGetRequest Body { get; init; }
}
