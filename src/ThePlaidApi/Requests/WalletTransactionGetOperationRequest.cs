using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the WalletTransactionGet operation.
/// </summary>
public sealed record WalletTransactionGetOperationRequest
{
    public required WalletTransactionGetRequest Body { get; init; }
}
