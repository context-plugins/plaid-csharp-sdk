using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransferOriginatorFundingAccountCreate operation.
/// </summary>
public sealed record TransferOriginatorFundingAccountCreateOperationRequest
{
    public required TransferOriginatorFundingAccountCreateRequest Body { get; init; }
}
