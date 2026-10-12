using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the WalletCreate operation.
/// </summary>
public sealed record WalletCreateOperationRequest
{
    public required WalletCreateRequest Body { get; init; }
}
