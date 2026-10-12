using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the BankTransferSweepGet operation.
/// </summary>
public sealed record BankTransferSweepGetOperationRequest
{
    public required BankTransferSweepGetRequest Body { get; init; }
}
