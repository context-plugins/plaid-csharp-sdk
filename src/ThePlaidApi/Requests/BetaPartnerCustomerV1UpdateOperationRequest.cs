using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the BetaPartnerCustomerV1Update operation.
/// </summary>
public sealed record BetaPartnerCustomerV1UpdateOperationRequest
{
    public required BetaPartnerCustomerV1UpdateRequest Body { get; init; }
}
