using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the BankTransferSweepList operation.
/// </summary>
public sealed record BankTransferSweepListOperationRequest
{
    public required BankTransferSweepListRequest Body { get; init; }
}
