using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the WalletTransactionList operation.
/// </summary>
public sealed record WalletTransactionListOperationRequest
{
    public required WalletTransactionListRequest Body { get; init; }
}
