using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the BankTransferBalanceGet operation.
/// </summary>
public sealed record BankTransferBalanceGetOperationRequest
{
    public required BankTransferBalanceGetRequest Body { get; init; }
}
