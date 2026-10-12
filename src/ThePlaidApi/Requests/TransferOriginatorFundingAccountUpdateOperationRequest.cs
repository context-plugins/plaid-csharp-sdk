using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransferOriginatorFundingAccountUpdate operation.
/// </summary>
public sealed record TransferOriginatorFundingAccountUpdateOperationRequest
{
    public required TransferOriginatorFundingAccountUpdateRequest Body { get; init; }
}
