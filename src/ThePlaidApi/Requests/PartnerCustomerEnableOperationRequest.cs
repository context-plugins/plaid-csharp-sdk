using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the PartnerCustomerEnable operation.
/// </summary>
public sealed record PartnerCustomerEnableOperationRequest
{
    public required PartnerCustomerEnableRequest Body { get; init; }
}
