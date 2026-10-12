using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the BankTransferCreate operation.
/// </summary>
public sealed record BankTransferCreateOperationRequest
{
    public required BankTransferCreateRequest Body { get; init; }
}
