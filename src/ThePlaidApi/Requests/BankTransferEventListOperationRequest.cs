using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the BankTransferEventList operation.
/// </summary>
public sealed record BankTransferEventListOperationRequest
{
    public required BankTransferEventListRequest Body { get; init; }
}
