using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the BetaPartnerCustomerV1Get operation.
/// </summary>
public sealed record BetaPartnerCustomerV1GetOperationRequest
{
    public required BetaPartnerCustomerV1GetRequest Body { get; init; }
}
