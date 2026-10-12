using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransferBalanceGet operation.
/// </summary>
public sealed record TransferBalanceGetOperationRequest
{
    public required TransferBalanceGetRequest Body { get; init; }
}
