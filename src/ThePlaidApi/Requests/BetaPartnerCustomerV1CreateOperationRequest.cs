using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the BetaPartnerCustomerV1Create operation.
/// </summary>
public sealed record BetaPartnerCustomerV1CreateOperationRequest
{
    public required BetaPartnerCustomerV1CreateRequest Body { get; init; }
}
