using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the BankTransferCancel operation.
/// </summary>
public sealed record BankTransferCancelOperationRequest
{
    public required BankTransferCancelRequest Body { get; init; }
}
