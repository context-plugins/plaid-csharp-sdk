using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the WalletList operation.
/// </summary>
public sealed record WalletListOperationRequest
{
    public required WalletListRequest Body { get; init; }
}
