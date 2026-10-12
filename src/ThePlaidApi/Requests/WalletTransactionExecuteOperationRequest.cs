using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the WalletTransactionExecute operation.
/// </summary>
public sealed record WalletTransactionExecuteOperationRequest
{
    public required WalletTransactionExecuteRequest Body { get; init; }
}
