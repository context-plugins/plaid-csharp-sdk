using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the PartnerCustomerRemove operation.
/// </summary>
public sealed record PartnerCustomerRemoveOperationRequest
{
    public required PartnerCustomerRemoveRequest Body { get; init; }
}
