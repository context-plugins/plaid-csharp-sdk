using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the BetaPartnerCustomerV1Enable operation.
/// </summary>
public sealed record BetaPartnerCustomerV1EnableOperationRequest
{
    public required BetaPartnerCustomerV1EnableRequest Body { get; init; }
}
