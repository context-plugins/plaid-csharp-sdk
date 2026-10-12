using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the BankTransferList operation.
/// </summary>
public sealed record BankTransferListOperationRequest
{
    public required BankTransferListRequest Body { get; init; }
}
